
# 离线翻译服务代码
from flask import Flask, request
from gevent import pywsgi
import warnings
warnings.filterwarnings('ignore')
from transformers import (
    T5Tokenizer,
    MT5ForConditionalGeneration,
    Text2TextGenerationPipeline,
)
print('正在加载翻译模型... ...')
#path = "F:\\K024\\mt5-zh-ja-en-trimmed"
path = 'K024/mt5-zh-ja-en-trimmed'
pipe = Text2TextGenerationPipeline(
    model=MT5ForConditionalGeneration.from_pretrained(path),
    tokenizer=T5Tokenizer.from_pretrained(path),
)
app = Flask(__name__)


@app.route('/wesky-translater', methods=['POST'])
def translate():
    mod = request.form['mod']
    text = request.form['text']
    if mod == 'zh2en':
        result = pipe("zh2en:" + text, max_length=10240, num_beams=4)[0]['generated_text']
        return result
    elif mod == 'en2zh':
        result = pipe("en2zh:" + text, max_length=10240, num_beams=4)[0]['generated_text']
        return result
    elif mod == 'ja2zh':
        result = pipe("ja2zh:" + text, max_length=10240, num_beams=4)[0]['generated_text']
        return result
    elif mod == 'zh2ja':
        result = pipe("zh2ja:" + text, max_length=10240, num_beams=4)[0]['generated_text']
        return result


print('翻译服务已启动，请通过api形式访问该服务地址：http://ip:16888/wesky-translater')
server = pywsgi.WSGIServer(('0.0.0.0', 16888), app)
server.serve_forever()

# nuitka --standalone --show-memory --show-progress --nofollow-import-to=transformers,email,numpy,torch,gevent,flask,urlib3,http,requests  --output-dir=out  translation.py

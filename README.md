# tianruoocr-cl

#### 介绍
天若ocr开源版本的本地版，采用Chinese-lite和Paddle识别，再也不用网络啦
主要fork了以下仓库：
> https://gitee.com/ZZK-1989/tianruoocr

> https://github.com/DayBreak-u/chineseocr_lite/tree/onnx/dotnet_projects/OcrLiteOnnxCs

> https://github.com/RapidAI/RapidOCR

添加了ocr设置

64位应该可以直接使用，可能需要.net4.7

本程序主要靠粘贴复制，要是有大佬帮忙改改就好了

中文识别率还是很舒服的

线程设的4，可以修改

由于我也是白小白，可能需要在本项目根目录和tianruoocr-master下各放置一个packages，不然OcrLiteLib无法识别到tianruoocr-master里面的packages...


## 版本更新
### V1.1
1. 添加了paddle-ocr支持，模型并不大，速度快！
2. 可以切换接口了，虽然工程里面名字还是其他名字，但是编译出来的不会显示搜狗和腾讯了
3. 优化了内存占用（每次识别完自动清理内存）

### V1.0
1.添加了Chineseocr-lite支持，使用原来搜狗的接口选项

# tianruoocr-cl

#### 介绍
天若ocr开源版本的本地版，采用Chinese-lite和paddle-ocr识别，再也不用网络啦

推荐paddle-ocr识别，可以在识别结果里面切换接口


主要fork了以下仓库：
> https://gitee.com/ZZK-1989/tianruoocr

> https://github.com/DayBreak-u/chineseocr_lite/tree/onnx/dotnet_projects/OcrLiteOnnxCs

> https://github.com/RapidAI/RapidOCR

> https://github.com/Guila767/GoogleTranslateApi

添加了ocr设置

64位应该可以直接使用，可能需要.net4.7

本程序主要靠粘贴复制，要是有大佬帮忙改改就好了

中文识别率还是很舒服的

线程设的4，可以修改

由于我也是白小白，编译的话可能需要在本项目根目录和tianruoocr-master下各放置一个packages，不然OcrLiteLib无法识别到tianruoocr-master里面的packages...
## 问题汇总
1. win7无法使用，基本无解
2. 如果出现`Exception from HRESULT: 0x8007007E`可以使用dx修复工具进行修复，一般能够启动

## 版本更新
### v1.2.5
1. 把原来删除的百度在线ocr给撤销回来了，现在可以使用了，并且加入了错误检测，避免崩溃
2. 段落翻译增加了延时，避免ip被封
### v1.2.4
1. 添加了保留段落翻译，不再合并段落翻译，切换接口即可，由于单独翻译，速度可能稍慢
### v1.2.3
1. 添加了参数帮助（注释）
### v1.2.2
1. 修复了不能重启的bug
### v1.2.1
1. 修复了不能切换模型的bug，初始paddle模型是选的英文
### v1.2
1. 更新了翻译接口，现在谷歌和百度可以用了！换行会自动处理成量起来的，方便pdf。百度需要申请API
2. 添加了几个轻量模型（日文和英文专精），切换需要重启
3. 修复了部分bug，清理了部分源码
4. 应该不会再更新了！

### V1.1
1. 添加了paddle-ocr支持，模型并不大，速度快！
2. 可以切换接口了，虽然工程里面名字还是其他名字，但是编译出来的不会显示搜狗和腾讯了
3. 优化了内存占用（每次识别完自动清理内存）

### V1.0
1. 添加了Chineseocr-lite支持，使用原来搜狗的接口选项

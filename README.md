# tianruoocr-cl

#### 介绍
天若ocr开源版本的本地版，采用Chinese-lite识别，再也不用网络啦

下载地址
> https://gitee.com/wanglifree/tianruoocr-cl/releases/v1.0

主要fork了以下仓库：
> https://gitee.com/ZZK-1989/tianruoocr
> https://github.com/DayBreak-u/chineseocr_lite/tree/onnx/dotnet_projects/OcrLiteOnnxCs

添加了ocr设置

64位应该可以直接使用，可能需要.net4.7

本程序主要靠粘贴复制，要是有大佬帮忙改改就好了

中文识别率还是很舒服的

但是内存占用很大！线程设的4，可以修改

由于我也是白小白，可能需要在本项目根目录和tianruoocr-master下各放置一个packages，不然OcrLiteLib无法识别到tianruoocr-master里面的packages...

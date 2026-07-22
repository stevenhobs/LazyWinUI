# LazyWinUI：快速开发WinUI3 App

## 项目模板

优化了 VS默认创建的WinUI3 项目结构，方便快速开发**未打包**项目

## 注意

- 如果启用Publish AOT功能项，编译出的程序仍需要运行时依赖 **WindowsApp Runtime**
- Nuget包默认拉取最新版本，开发建议固定包的版本

## 编译环境

- VisualStudio Build Tools 2022+ 构建工具   勾选 C++桌面开发，以下可选项勾选三个：
  - MSVC生成工具（最新版）
  - Windows11 SDK
  - C++ ALT for x64/x86（最新MSVC）
- DotNet Desktop SDK 最新

## 维护规划

- [ ] 明确 **AI Agent** 开发规范，便于Vibe Coding
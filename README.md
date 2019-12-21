# uni-l2d-extension

## サマリ
UnityでLive2Dを扱うためのカスタムコマンドをまとめたパッケージ

## 導入手順

1. 新規のプロジェクトに`uni-l2d-extension/package/UniL2dExtension.package`を導入
2. Live2DSDKを入れてUnityを再起動
3. 公式のサンプルなどからLive2Dモデルをインポート(古いSDKで作ったモデルを新しいSDKで入れると動かないことがあるため、なるべく最新のモデルを使用すること)
4. UniL2dExtension/Animationsを複製し、Live2DモデルのAnimationを各Layerに設定する。
5. UniL2dExtension/Scripts/MotionBlendHelper.csをモデルにアタッチする
6. MotionBlendHelperのLayersにAnimationConstollerのLayer名を設定をする。
7. UniL2dExtension/Scripts/SampleController.csを参考に利用側スクリプトを書く。

## 機能要件
Live2Dのレイヤ構造の影響を受けないため、直接レイヤ構造を記述しない。

## 開発

### 開発環境

下記の存在を前提とする。

- Live2DSDK(バージョン問わず/今回はCubismSdkForUnity-4-beta.2.unitypackageを使用)
- UnityLive2DExtension

### 開発時の注意
Live2DSDKの特定のバージョンによらないように開発する
特定のAnimationレイヤ構造によらないように開発する

### Package

#### Package出力先
uni-l2d-extension/package/UniL2dExtension.package

#### Package出力手順
packageとして出力するディレクトリ（Utage,Live2D）
unity-l2d-extension/dev/Asset/UnityL2dExtension以下


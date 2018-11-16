# ASP.NET CoreのIDスキャフォールディング後にRoleを追加するサンプル

ASP.NET Coreで、認証無しのテンプレートにID スキャフォールディングで追加した後に、
IdentityRoleを追加するサンプルです。 

## 環境
- Visual Studio 2017
- .NET Core 2.1
- ASP.NET Core 2.1
- Razor Pages

## 追加手順
1. ASP.NET Core WEbアプリケーションの作成
2. ID スキャフォールディング Login, Logout, AccessDenied, Registerを実装。
3. NuGetパッケージ更新。
4. app.UseAuthentication()追加。
5. Loginメニュー追加。
6. EmailをUserNameに変更。外部ログイン認証へのリンク削除。
7. 簡単のため、UseInMemoryDatabase()を使用。
8. Contactを認証が必要なページとする。
9. IdentityRoleを追加。
10. 起動時にAdministrator Roleを生成。
11. Register時にRoleの項目(IsAdministrator)追加。
12. Policy = "RequireAdministratorRole"追加。
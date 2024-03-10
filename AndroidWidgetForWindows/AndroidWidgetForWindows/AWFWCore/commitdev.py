import subprocess

def commit_to_github():
    # ローカルのdevelopブランチに変更
    subprocess.run(["git", "checkout", "develop"], check=True)
    # 変更をステージングエリアに追加
    subprocess.run(["git", "add", "."], check=True)
    # コミットメッセージを付けてコミット
    subprocess.run(["git", "commit", "-m", "developブランチに変更をコミット"], check=True)
    # GitHubのdevelopブランチにプッシュ
    subprocess.run(["git", "push", "origin", "develop"], check=True)

# コミット処理を実行
commit_to_github()

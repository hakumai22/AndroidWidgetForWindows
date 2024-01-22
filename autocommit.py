import subprocess

def git_commit_and_push(commit_message,brunch):
    try:
        # git add -A : ステージングエリアに変更を追加
        subprocess.run(["git", "add", "-A"], check=True)

        # git commit -m "コミットメッセージ" : コミットを作成
        subprocess.run(["git", "commit", "-m", commit_message], check=True)

        # git push origin master : リモートリポジトリにプッシュ
        subprocess.run(["git", "push", "origin", brunch], check=True)

        print("コミットとプッシュが成功しました。")
    except subprocess.CalledProcessError as e:
        print("エラーが発生しました。", e)

# コミットメッセージを指定して関数を呼び出す例
commit_message = "自動コミットメッセージ"
git_commit_and_push("python test","develop")
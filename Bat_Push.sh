echo "Push..."
cd $(pwd)
echo "please input your comment:"
read input
git add .
git commit -m "$input"
git push
echo "Push end"

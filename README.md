# How to Run

Make sure you are in the main folder of the project in the terminal when running the app.

```dotnet run``` to run the app without hot reload.

```dotnet Watch``` to run the app with hot reload. To reload after changes, refresh the webpage.

```dotnet --help``` to see all dotnet options.

# Basic Bash Commands

##### Changing directory/folder

```cd <directory_name>```

```cd ..``` -> goes back 1 folder

```ls``` -> Displays all contents of folder

```ls -a``` -> Displays all contents of folder including hidden files

##### Git Commands

```git status``` -> Shows status of modified files, added/removed files, and files that are ready to be committed

```git add <file path>``` -> Adds file to list of files to be committed. You can also use a folder instead of a filename to add all files in that folder, or use ```.``` to add all untracked files found in ```git status```.

```git pull``` -> Pull down the latest code from source control for the selected branch

```git commit -m "COMMIT MSG"``` -> Commits all files that have been added to commit list

```git push``` -> Pushes all committed files to source control

```git checkout <BRANCH_NAME>``` -> Move to branch

```git branch``` -> Tells you which branch you are working in

```git checkout -b <NEW_BRANCH_NAME>``` -> Makes new branch and checks it out

```git merge <BRANCH_TO_MERGE>``` -> Merges the branch into the currently checked out branch

```git checkout .``` -> Resets current branch thereby removing any local changes

```git checkout <FILE_OR_FOLDER_NAME>```-> Resets File or entire Folder, removing those specific local changes















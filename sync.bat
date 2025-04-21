:: Set repo path (customize this if it's not in your home directory)
set "REPO=%USERPROFILE%\dotfiles"

echo Linking .ideavimrc to home directory
mklink "%USERPROFILE%\.ideavimrc" "%REPO%\.ideavimrc"


echo Done.
ENDLOCAL
pause

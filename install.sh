#!/bin/bash

mkdir -p "$HOME/.config"

echo "Linking .ideavimrc"
[ ! -L ~/.ideavimrc ] && rm -f ~/.ideavimrc && ln -s ~/dotfiles/ideavimrc ~/.ideavimrc

echo "Linking Godot config"
[ ! -L ~/.config/godot ] && rm -rf ~/.config/godot && ln -s ~/dotfiles/godot ~/.config/godot

echo "Linking Ghostty config"
[ ! -L ~/.config/ghostty ] && rm -rf ~/.config/ghostty && ln -s ~/dotfiles/ghostty ~/.config/ghostty


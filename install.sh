#!/bin/bash

mkdir -p "$HOME/.config"

echo "Linking .ideavimrc"
[ ! -L ~/.ideavimrc ] && rm -f ~/.ideavimrc && ln -s ~/dotfiles/ideavimrc ~/.ideavimrc

echo "Linking Godot config"
[ ! -L ~/.config/godot ] && rm -rf ~/.config/godot && ln -s ~/dotfiles/godot ~/.config/godot

echo "Linking .bashrc"
[ ! -L ~/bash/.bashrc ] && rm -f ~/.bashrc && ln -s ~/bash/.bashrc ~/.bashrc

echo "Linking nvim config"
[ ! -L ~/.config/nvim ] && rm -rf ~/.config/nvim && ln -s ~/dotfiles/nvim ~/.config/nvim

echo "Linking Ghostty config"
[ ! -L ~/.config/ghostty ] && rm -rf ~/.config/ghostty && ln -s ~/dotfiles/ghostty ~/.config/ghostty


#!/bin/sh
echo -ne '\033c\033]0;OWASDsharp\a'
base_path="$(dirname "$(realpath "$0")")"
"$base_path/realise_linux.x86_64" "$@"

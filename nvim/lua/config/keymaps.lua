local opts = { noremap = true, silent = true }
local function map(mode, lhs, rhs, o)
  vim.keymap.set(mode, lhs, rhs, o or opts)
end

-- Movement / windows
map("n", "<leader>j", "<C-d>")
map("n", "<leader>k", "<C-u>")
map("n", "<leader>h", "<C-w>h")
map("n", "<leader>l", "<C-w>l")
map("n", "<leader>sv", "<cmd>vsplit<cr>")

-- Insert escape
map("i", "jj", "<Esc>")

-- Telescope
map("n", "<leader>ff", "<cmd>Telescope find_files<cr>")
map("n", "<leader>g",  "<cmd>Telescope live_grep<cr>")
map("n", "<leader>b",  "<cmd>Telescope buffers<cr>")

-- Jump list
map("n", "<leader>o", "<C-o>")
map("n", "<leader>i", "<C-i>")
map("n", "<leader>J", "<cmd>jumps<cr>")

-- NvimTree
map("n", "<leader>e", "<cmd>NvimTreeToggle<cr>")


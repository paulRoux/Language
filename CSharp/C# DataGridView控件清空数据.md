###C# DataGridView控件清空数据完美解决方法

####1.方法1

1. 在清除`DataGridview`的数据时的问题：

	>1. `DataSource`为 NULL`（DataGridView.DataSource=null;）`这样会将DataGridView的列也删掉。
	>2. 用`DataGridview.Rows.Clear();` 提示“不能清除此列表”！！！！！

2. 以上都不是想要的结果。想要满足保持原有的列，就是重新绑定之前的`DataTable`，然后清除`DataTable`中的数据，如下：

```c
DataTable dt = (DataTable)dataGridView1.DataSource;

dt.Rows.Clear();

dataGridView1.DataSource = dt;
```

####2.方法2

1. 利用循环删除 DataGridViewRow 的方法，代码如下：

```c
while (this.DataGridView.Rows.Count != 0)
{
	this.DataGridView.Rows.RemoveAt(0);
}
```

####3.方法3

1. 我们知道 DataGridView 有个`DataSource`，可以直接放数据进去，那么当我们放一个特定的空 Table 进去，那么也可以清空了。但是，注意如果 DataGridView 显示的列名是自己在设计时做好的，那么放进去的空Table一定得是你`DataGridView.DataSource=Table`这个表。只要清空该表的数据，而再一次向让`DataGridView.DataSource=Table`就可以清空 DataGridView 了，而它的列名没有删除掉。例如：

```c
DataGridView.Source=Table

Table.Clear();

DataGridView.Source=Table
```

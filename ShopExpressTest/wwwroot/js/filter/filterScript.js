async function filterTodo(event) {
    const filter = event.target.value;

    const obj = await getTaskList();
    const tasks = obj.tasks;

        if (filter === "all") {
            updateTaskList(tasks);
        } else if (filter === "completed") {
            updateTaskList(tasks.filter(task => task.isCompleted)); // Показує лише виконані завдання

        } else if (filter === "uncompleted") {
            updateTaskList(tasks.filter(task => !task.isCompleted)); // Показує лише невиконання завдання
        }
}

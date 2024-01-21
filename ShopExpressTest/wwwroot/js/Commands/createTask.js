async function createTask(title) {
    try {
        $.ajax({
            type: "POST",
            url: "/Task/CreateTask",
            data: { Title: title }
        })
            .then(result => {
                return getTaskList(); // Викликаємо getTaskList() асинхронно
            })
            .then(tasks => {
                updateTaskList(tasks.tasks);
                console.log("Task add successfully!");
            })
            .catch(error => {
                console.error("Error add task:", error);
            });
    } catch (error) {
        console.error("Error creating task:", error);
    }
}

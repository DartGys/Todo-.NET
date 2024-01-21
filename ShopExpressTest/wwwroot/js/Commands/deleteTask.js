async function deleteTask(id) {
    try {
        $.ajax({
            type: "POST",
            url: "/Task/DeleteTask",
            data: { Id: id }
        })
            .then(result => {
                return getTaskList(); // ��������� getTaskList() ����������
            })
            .then(tasks => {
                updateTaskList(tasks.tasks);
                console.log("Task delete successfully!");
            })
            .catch(error => {
                console.error("Error delete task:", error);
            });
    } catch (error) {
        console.error("Error creating task:", error);
    }
}
function completeTask(id) {
    try {
        $.ajax({
            type: "POST",
            url: "/Task/CompleteTask",
            data: { Id: id }
        })
            .then(result => {
                return getTaskList(); // ��������� getTaskList() ����������
            })
            .then(tasks => {
                updateTaskList(tasks.tasks);
                console.log("Task complete successfully!");
            })
            .catch(error => {
                console.error("Error complete task:", error);
            });
    } catch (error) {
        console.error("Error complete task:", error);
    }
}
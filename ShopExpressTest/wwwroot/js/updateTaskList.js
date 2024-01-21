function updateTaskList(tasks) {
    var taskList = $("#task-list");
    taskList.empty();

    // Додайте нові завдання до списку з використанням нового формату HTML.
    if (tasks) {
        console.log("success");
        tasks.forEach(function (task) {
            var listItem = $("<li>").addClass("list-group-item");

            var badgeClass = task.isCompleted ? "success" : "danger";
            var badge = $("<span>").addClass("badge badge-" + badgeClass)
                .text(task.isCompleted ? "done" : "undone")
                .hover(
                    function () {
                        // Функція, яка викликається при наведенні курсора
                        $(this).css("cursor", "pointer");
                    },
                    function () {
                        // Функція, яка викликається при виїзді курсора
                        $(this).css("cursor", "auto");
                    })
                .click(function () {
                    completeTask(task.id);
                });

            listItem.append(badge);

            var title = $("<strong>").text(task.title);
            listItem.append(title);

            var deleteButton = $("<button>").addClass("btn btn-danger btn-sm float-right").text("Видалити").click(function () {
                deleteTask(task.id);
            });
            listItem.append(deleteButton);

            taskList.append(listItem);
        });
    }
}

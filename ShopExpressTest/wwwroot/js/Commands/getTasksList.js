async function getTaskList() {
    return new Promise(function (resolve, reject) {
        $.ajax({
            type: "POST",
            url: "/Task/GetTaskList",
            success: function (result) {
                console.log("Task get successfully!");
                console.log(result);
                resolve(result);
            },
            error: function (error) {
                console.error("Error get task:", error);
                reject(error);
            }
        });
    });
}
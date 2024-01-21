document.addEventListener("DOMContentLoaded", async function () {
    try {
        var tasks = await getTaskList();
        updateTaskList(tasks.tasks);
    } catch (error) {
        console.error("Error:", error);
    }
});
function toggleBadge(badge, isCompleted) {
    var text = isCompleted ? "undone" : "done";
    badge.text(text);

    var currentClass = badge.hasClass("badge-success") ? "badge-success" : "badge-danger";
    var newClass = currentClass === "badge-success" ? "badge-danger" : "badge-success";

    badge.removeClass(currentClass).addClass(newClass);
}
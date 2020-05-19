var bttn = document.createElement("button");
bttn.value = "Change bgcolor";
bttn.clientWidth = 100;
bttn.clientHeight = 100;
bttn.addEventListener("click", () => { document.body.style.backgroundColor = "#ddd"; });
document.body.appendChild(bttn);
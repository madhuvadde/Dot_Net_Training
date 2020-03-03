const welcome = document.getElementById('welcome');
const hero = document.getElementById('hero_div');

const ui = document.getElementById('ui');
const ui_training  = document.getElementById('ui_training');
const ui_learning = document.getElementById('ui_learning');
const ui_support  = document.getElementById('ui_support');
const ui_learning_url = "https://unisyscorp.sharepoint.com/sites/SDG-APPS/UFSS/NonLinc/Shared%20Documents/Forms/AllItems.aspx?id=%2Fsites%2FSDG%2DAPPS%2FUFSS%2FNonLinc%2FShared%20Documents%2FTraining%2FUFSS%20UI&viewid=8bae1899%2D1b59%2D49af%2D9a8f%2D9cb27e1c32d0";

const id_arr = [ui_training,ui_learning,ui_support];
const url_arr = [ui_learning_url,"#","#"];
const name = ["UI Training","UI Learning","UI Support"]

for(let i = 0;i<id_arr.length;i++){
	id_arr[i].addEventListener('click',function(){viewInfo(name[i],url_arr[i])},false);
}

const cus_Anc = document.createElement('a');
function viewInfo(text,url){
	welcome.textContent = "Welcome to " + text;
	cus_Anc.href = url;
	cus_Anc.target = "_blank";
	cus_Anc.className = "btn-get-started scrollto";
	cus_Anc.textContent = "Get Started";
	hero.appendChild(cus_Anc);
}

 
$(document).ready(()=>{

    //Slider de la primera pagina
    if(window.location.href.indexOf('index') > 1){
    $(function(){
        $('.galeria').bxSlider({
          mode: 'fade',
          captions: true,
          slideWidth: 1200
        });
      });
    }

      // Informacion que aparece en la primera pagina con el boton ver mas
      if(window.location.href.indexOf('index') > 1){ // Esta condicion te dice que esta parte del codigo se ejecutara solamente en el index de la url

        var posts =[
            {
                title:'Karen anda de vaga',
                date: 'Publicado el dia ' +moment().date()+' de '+moment().format("MMMM")+' del '+moment().format("YYYY"),
                content:'Lorem ipsum dolor sit, amet consectetur adipisicing elit. Consectetur, at, sapiente facilis cumque voluptate mollitia fugiat quidem illo, repudiandae nobis corrupti! Distinctio vero expedita corrupti quas explicabo delectus minima nobis? Lorem ipsum dolor sit, amet consectetur adipisicing elit. Aliquid odio aliquam id sunt mollitia eos alias maiores soluta cupiditate recusandae repudiandae sit nihil modi, error, asperiores quidem nostrum, voluptatum quis. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Recusandae amet maxime suscipit porro mollitia necessitatibus cum beatae, impedit neque, omnis repellendus molestias? Earum blanditiis quae incidunt placeat? Ipsum, quam ipsam.'
            },
            { 
                title:'Karen anda de vaga 2',
                date: 'Publicado el dia ' +moment().date()+' de '+moment().format("MMMM")+' del '+moment().format("YYYY"),
                content:'Lorem ipsum dolor sit, amet consectetur adipisicing elit. Consectetur, at, sapiente facilis cumque voluptate mollitia fugiat quidem illo, repudiandae nobis corrupti! Distinctio vero expedita corrupti quas explicabo delectus minima nobis? Lorem ipsum dolor sit, amet consectetur adipisicing elit. Aliquid odio aliquam id sunt mollitia eos alias maiores soluta cupiditate recusandae repudiandae sit nihil modi, error, asperiores quidem nostrum, voluptatum quis. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Recusandae amet maxime suscipit porro mollitia necessitatibus cum beatae, impedit neque, omnis repellendus molestias? Earum blanditiis quae incidunt placeat? Ipsum, quam ipsam.'
            },
            {
                title:'Karen anda de vaga 3',
                date: 'Publicado el dia ' +moment().date()+' de '+moment().format("MMMM")+' del '+moment().format("YYYY"),
                content:'Lorem ipsum dolor sit, amet consectetur adipisicing elit. Consectetur, at, sapiente facilis cumque voluptate mollitia fugiat quidem illo, repudiandae nobis corrupti! Distinctio vero expedita corrupti quas explicabo delectus minima nobis? Lorem ipsum dolor sit, amet consectetur adipisicing elit. Aliquid odio aliquam id sunt mollitia eos alias maiores soluta cupiditate recusandae repudiandae sit nihil modi, error, asperiores quidem nostrum, voluptatum quis. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Recusandae amet maxime suscipit porro mollitia necessitatibus cum beatae, impedit neque, omnis repellendus molestias? Earum blanditiis quae incidunt placeat? Ipsum, quam ipsam.'
            },
            {
                title:'Karen anda de vaga 4',
                date: 'Publicado el dia ' +moment().date()+' de '+moment().format("MMMM")+' del '+moment().format("YYYY"), 
                content:'Lorem ipsum dolor sit, amet consectetur adipisicing elit. Consectetur, at, sapiente facilis cumque voluptate mollitia fugiat quidem illo, repudiandae nobis corrupti! Distinctio vero expedita corrupti quas explicabo delectus minima nobis? Lorem ipsum dolor sit, amet consectetur adipisicing elit. Aliquid odio aliquam id sunt mollitia eos alias maiores soluta cupiditate recusandae repudiandae sit nihil modi, error, asperiores quidem nostrum, voluptatum quis. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Recusandae amet maxime suscipit porro mollitia necessitatibus cum beatae, impedit neque, omnis repellendus molestias? Earum blanditiis quae incidunt placeat? Ipsum, quam ipsam.'
            },
            {
                title:'Karen anda de vaga 5',
                date: 'Publicado el dia ' +moment().date()+' de '+moment().format("MMMM")+' del '+moment().format("YYYY"),
                content:'Lorem ipsum dolor sit, amet consectetur adipisicing elit. Consectetur, at, sapiente facilis cumque voluptate mollitia fugiat quidem illo, repudiandae nobis corrupti! Distinctio vero expedita corrupti quas explicabo delectus minima nobis? Lorem ipsum dolor sit, amet consectetur adipisicing elit. Aliquid odio aliquam id sunt mollitia eos alias maiores soluta cupiditate recusandae repudiandae sit nihil modi, error, asperiores quidem nostrum, voluptatum quis. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Recusandae amet maxime suscipit porro mollitia necessitatibus cum beatae, impedit neque, omnis repellendus molestias? Earum blanditiis quae incidunt placeat? Ipsum, quam ipsam.'
            },
            {
                title:'Karina charlatana',
                date: 'Publicado el dia ' +moment().date()+' de '+moment().format("MMMM")+' del '+moment().format("YYYY"),
                content:'Lorem ipsum dolor sit, amet consectetur adipisicing elit. Consectetur, at, sapiente facilis cumque voluptate mollitia fugiat quidem illo, repudiandae nobis corrupti! Distinctio vero expedita corrupti quas explicabo delectus minima nobis? Lorem ipsum dolor sit, amet consectetur adipisicing elit. Aliquid odio aliquam id sunt mollitia eos alias maiores soluta cupiditate recusandae repudiandae sit nihil modi, error, asperiores quidem nostrum, voluptatum quis. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Recusandae amet maxime suscipit porro mollitia necessitatibus cum beatae, impedit neque, omnis repellendus molestias? Earum blanditiis quae incidunt placeat? Ipsum, quam ipsam.'
            }
            ];

            //Aqui llenas en cuadro que de la primera pagina sacando la informacion del json que esta arriba
            posts.forEach((item, index)=>{
                var post = `
                    <article class="post">
                        <h2>${item.title}</h2>
                        <span class="date">${item.date}</span>
                        <p>
                            ${item.content}
                        </p>
                        <a href="#" class="button-more">Leer mas</a>
                    </article>
                    `;

                $("#posts").append(post);
            });
        }// Aqui cierra la condicion

        //selector de tema
        var theme = $("#theme");
        $("#to-green").click(()=>{
            theme.attr("href", "css/gree.css");
        });

        $("#to-red").click(()=>{
            theme.attr("href", "css/red.css");
        });

        $("#to-blue").click(()=>{
            theme.attr("href", "css/blue.css");
        });

        //scroll arriba de la web
        $('.subir').click(function(e){
            e.preventDefault();

            $('html, body').animate({
                scrollTop: 0
            }, 2000);

            return false;
        });

        //login falso
        $("#login form").submit(function(){
            var form_name = $("#form_name").val();

            localStorage.setItem("form_name",form_name);
        });

        var form_name = localStorage.getItem("form_name");
        if(form_name != null && form_name != 'undefined'){
            var about_parrafo = $("#about p");
            about_parrafo.html("<br><stron>Bienvenido/a, "+ form_name+"</strong>");
            about_parrafo.append("<a href='#' id='logout'>(Cerrar Seccion)</a>")
            $("#login").hide();

            $("#logout").click(function(){
                localStorage.clear();
                location.reload();
            });
        }

        //acordeon es donde dice Karen Vaga y to eso
        if(window.location.href.indexOf('about') > 1){
            $("#acordeon").accordion();
        }

        //reloj que va pasando solo, usando la libreria moments.js
        if(window.location.href.indexOf('reloj') > 1){
            setInterval(()=>{
                var reloj = moment().format("h:mm:ss");
                $("#reloj").html(reloj);
            },1000);
        }

        //Validacion del formulario con Jquery

        if(window.location.href.indexOf('contact') > 1){

            $("form input[name='date']").datepicker({
                dateFormat: 'dd/mm/yy'
            });

        $.validate({
            lang:'es',
            errorMessagePosition: 'top',
            scrollToTopOnError: true
        });
    }
});
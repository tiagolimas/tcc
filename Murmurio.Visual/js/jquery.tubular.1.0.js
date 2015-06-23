//eLjYGV2vOpc  tiago will
//z1aEQhvsFAQ  Moska
//aA6ome0TWd4 Céu

//short videos:
//fCeeLnQP0ls
//S9lRdmfCw3I
//drCJ27FA3-Y

//window.player.destroy();
//window.player.setOption(cc, option, null);
//window.player.stopVideo(0);
//player.clearVideo();
//window.player.nextVideo();

function tub(info) {
    
    var tamanhoInfo = (info.length / 3);
	var i = 0;
	var vetor = new Array();
	var indiceInfo = 0;
    
    //Instacia o vetor
	for (i = 0; i < tamanhoInfo; i++) {
	    vetor[i] = new Array();
	}

    //Popula o vetor
	for (i = 0; i < tamanhoInfo; i++) {
        for (j = 0; j < 3; j++) {

            if (info[indiceInfo] != null) {
                vetor[i][j] = info[indiceInfo];
                indiceInfo++;
            }
	    }
    }

    //Randomiza o vetor
     var vetorAmigo = trataInfoVideos();
                var idAmigo = 1; //Id recebido
                var qtdVideosAmigo = 2;//= $("#qtdVideos").val();

                flag = 0;
				video_url = player.getVideoUrl();
				tam = video_url.length;
				dif = tam - 11;
				video_url = video_url.substring(dif,tam);
				randomId = (Math.floor(Math.random()*qtdVideosAmigo)); 
				randomId = (Math.floor(Math.random()*qtdVideosAmigo));
				
				while(flag < 1)
				{
					if(video_url === vetorAmigo[randomId][0])
					{
						randomId = (Math.floor(Math.random()*qtdVideosAmigo)); 
						flag = 0;			
					}else
					{
						flag = 1;
					}
				}



    //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%





    var txt = document.getElementById("cantor").firstChild.nodeValue = vetor[randomId][1];
    var txt = document.getElementById("faixa").firstChild.nodeValue = vetor[randomId][2];
    window.player.loadVideoById({ videoId: vetor[randomId][0], startSeconds: 0 }); // load and play the ID 

}

//%%%%%%%% Trata as informações dos vídeos contida no hidden serializado
function trataInfoVideos() {

    var info = $("#myLabel").val();  
    var tamanhoInfo = (info.length / 3);
    var i = 0, j=0;
    var vetor = new Array();
    var indiceInfo = 0;

    //Instacia o vetor
    for (i = 0; i < tamanhoInfo; i++) {
        vetor[i] = new Array();
    }

    //Popula o vetor
    for (i = 0; i < tamanhoInfo; i++) {
        for (j = 0; j < 3; j++) {

            if (info[indiceInfo] != null) {
                vetor[i][j] = info[indiceInfo];
                indiceInfo++;
            }
        }
    }
    
    $("#qtdVideos").val(indiceInfo);
    return vetor;
}
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5%%%



;(function ($, window) {
    
    console.log("passou" + window.toString());

	//playlist
	var i = 0;
	var vetor = new Array();
	for(i = 0; i <41; i++)
	vetor[i] = new Array();
	
	vetor[0][0] = "z1aEQhvsFAQ";
	vetor[0][1] = "Paulinho Moska ";
	vetor[0][2] = " - Provavelmente Você";
	vetor[1][0] = "zocxTQjcR9w";
	vetor[1][1] = "Nielson Alves ";
	vetor[1][2] = " - Café Amargo";
	vetor[2][0] = "nQ84WtdxcIo";
	vetor[2][1] = "Céu";
	vetor[2][2] = " - Eu amo Você";
	vetor[3][0] = "7Qqtqj1odfw";
	vetor[3][1] = "Tiago Iorc";
	vetor[3][2] = " - Story of a Man";
	vetor[4][0] = "-Lb557lk060";
	vetor[4][1] = "Tiago Iorc";
	vetor[4][2] = " - Nothing But a Song";
	vetor[5][0] = "NnTkVZCxHHs";
	vetor[5][1] = "John Mayer";
	vetor[5][2] = " - Gravity";
	vetor[6][0] = "1EHGHzgq72Y";
	vetor[6][1] = "Falamansa";
	vetor[6][2] = " - Indiferente-Xote ecológico";
	vetor[7][0] = "5ejLWCE_esg";
	vetor[7][1] = "Maria Gadú";
	vetor[7][2] = " - Lanterna dos afogados";
	vetor[8][0] = "KiPGXOP2dbg";
	vetor[8][1] = "Vanessa da Mata";
	vetor[8][2] = " - Viagem";
	vetor[9][0] = "OTgZovD03EU";
	vetor[9][1] = "Luciana Mello";
	vetor[9][2] = " - Simples Desejo";
	vetor[10][0] = "CrAti3aG1a8";
	vetor[10][1] = "João Sabiá";
	vetor[10][2] = " - Biriba";
	vetor[11][0] = "Ijb2ZMPxRoI";
	vetor[11][1] = "Roberta Sá e Ney Matogrosso";
	vetor[11][2] = " - Peito Vazio";
	vetor[12][0] = "rw3bXJgqKnc";
	vetor[12][1] = "SOJA";
	vetor[12][2] = " - Not Done Yet";
	vetor[13][0] = "iy7X1clA640";
	vetor[13][1] = "Leo Fressato";
	vetor[13][2] = " - Não há nada mais lindo";
	vetor[14][0] = "FX9s_RfEzJE";
	vetor[14][1] = "Cícero";
	vetor[14][2] = " - Tempo de Pipa";
	vetor[15][0] = "dCJMbcIheFs";
	vetor[15][1] = "Pitty";
	vetor[15][2] = " - Dançando";
	vetor[16][0] = "z9ZLZpcUS0o";
	vetor[16][1] = "Adriana Calcanhotto ";
	vetor[16][2] = " - Do fundo do meu coração";
	vetor[17][0] = "pNdo6ZCCTTo";
	vetor[17][1] = "Paulinho Moska e Milton Nascimento";
	vetor[17][2] = " - Nos bailes da vida";
	vetor[18][0] = "bQXpH83xO8w";
	vetor[18][1] = "João Sabiá";
	vetor[18][2] = " - Mesmo que seja longe";
	vetor[19][0] = "W6H_4YAF4zI";
	vetor[19][1] = "Caetano Veloso";
	vetor[19][2] = " - Voce é linda";
	vetor[20][0] = "P7mHf-UCZp0";
	vetor[20][1] = "Chico Buarque";
	vetor[20][2] = " - Construção";
	vetor[21][0] = "a60fJzqh0NE";
	vetor[21][1] = "Paula Lima ";
	vetor[21][2] = " - Agua de beber";
	vetor[22][0] = "BiacOLRsQtM";
	vetor[22][1] = "Ponto de Equilíbrio";
	vetor[22][2] = " - Aonde Vai Chegar";
	vetor[23][0] = "ZMVawc1TWpM";
	vetor[23][1] = "Natiruts ";
	vetor[23][2] = " - Quero Ser Feliz Também";
	vetor[24][0] = "j44DmnBR_08";
	vetor[24][1] = "Thiago Thomé";
	vetor[24][2] = " - Da Pele Preta";
	vetor[25][0] = "8MKtAbQPMWU";
	vetor[25][1] = "Chimarruts";
	vetor[25][2] = " - Em busca da fé";
	vetor[26][0] = "lk-2xoJ_FJ4";
	vetor[26][1] = "Chimarruts";
	vetor[26][2] = " - O Outono";
	vetor[27][0] = "TYY7KVgLS_A";
	vetor[27][1] = "Onze:20";
	vetor[27][2] = " - Não Vai Voltar";
	vetor[28][0] = "ZQHnlPhovf8";
	vetor[28][1] = "Onze:20";
	vetor[28][2] = " - Nossa Canção";
	vetor[29][0] = "qQdJGKUwcNE";
	vetor[29][1] = "Djavan ";	
	vetor[29][2] = " - Faltando um Pedaço";
	vetor[30][0] = "o7w5TsVOoQI";
	vetor[30][1] = "Marcelo Jeneci";
	vetor[30][2] = " - Pra sonhar";
	vetor[31][0] = "l2-aGZ0DWWA";
	vetor[31][1] = "Djavan";
	vetor[31][2] = " - Cair em si";
	vetor[32][0] = "rev2G-7ktYI";
	vetor[32][1] = "Djavan";
	vetor[32][2] = " - Doidice";
	vetor[33][0] = "JzmS0ShC5nE";
	vetor[33][1] = "Maria Gadú";
	vetor[33][2] = " - Tudo diferente";	
	vetor[34][0] = "t_BfvzGHJGA";
	vetor[34][1] = "5 a seco e Maria Gadú";
	vetor[34][2] = " - em paz";
	vetor[35][0] = "wWs2dqKRgdI";
	vetor[35][1] = "O Teatro Mágico";
	vetor[35][2] = " - Nosso Pequeno Castelo";
	vetor[36][0] = "w63Aqyht2Cg";
	vetor[36][1] = "Vanessa Da Mata";
	vetor[36][2] = " - Amado";
	vetor[37][0] = "dHEtbkzpI_8";
	vetor[37][1] = "Vanessa Da Mata";
	vetor[37][2] = " - Palavras";
	vetor[38][0] = "sKSEOMy0_wE";	
	vetor[38][1] = "Natiruts";
	vetor[38][2] = " - Pérola Negra";
	vetor[39][0] = "y9cRw23bbnk";
	vetor[39][1] = "Paulinho Moska";	
	vetor[39][2] = " - Somente nela";
	vetor[40][0] = "DHCQBsyJ_jE";
	vetor[40][1] = "Moska e Lisandro";
	vetor[40][2] = " - Waiting for the Sun to Shine";
	
	
    // defaults
    var defaults = {
        ratio: 16/9, // usually either 4/3 or 16/9 -- tweak as needed
        videoId: vetor, 
        mute: false,
        repeat: false,
        width: $(window).width(),
        wrapperZIndex: 99,
        playButtonClass: 'tubular-play',
        pauseButtonClass: 'tubular-pause',
        muteButtonClass: 'tubular-mute',
        volumeUpClass: 'tubular-volume-up',
        volumeDownClass: 'tubular-volume-down',
        increaseVolumeBy: 10,
        start: 0
    };
	
    // methods

    var tubular = function(node, options) { // should be called on the wrapper div
        var options = $.extend({}, defaults, options), //Faz um merge entre defaults e options
            $body = $('body') // cache body node
            $node = $(node); // cache wrapper node
			
		//---------- RANDOM -----------------------------------------
			var randomIdStart = 0; // set randomstart
			var randomIdEnd = 0; // set total in set (end)
			
			if( Object.prototype.toString.call( options.videoId ) === '[object Array]' ) { // check if options.videoId is an array
				randomIdEnd = options.videoId.length; // get object array count

			} else {
				console.log('RANDOM videoId is not a legal object array, please give me an array'); //tell them its not
				return false; // stop trying
			}
			
			var randomId = (Math.floor(Math.random()*randomIdEnd)); //set the random videoId
			
			console.log('Valor do RANDOM ' + randomId);
		
		//------------------------------------------------------------	
			
		
        // build container
        var tubularContainer = '<div id="tubular-container" style="overflow: hidden; position: fixed; z-index: 1; width: 100%; height: 100%"><div id="tubular-player" style="position: absolute"></div></div><div id="tubular-shield" style="width: 100%; height: 100%; z-index: 2; position: absolute; left: 0; top: 0;"></div>';

        // set up css prereq's, inject tubular container and set up wrapper defaults
        $('html,body').css({'width': '100%', 'height': '100%'});
        $body.prepend(tubularContainer);
        $node.css({position: 'relative', 'z-index': options.wrapperZIndex});

        // set up iframe player, use global scope so YT api can talk
        window.player;

        window.onYouTubeIframeAPIReady = function() {
            player = new YT.Player('tubular-player', {
                width: options.width,
                height: Math.ceil(options.width / options.ratio),
                videoId: options.videoId[randomId],
                playerVars: {
                    controls: 0,
                    showinfo: 0,
                    modestbranding: 1,
                    wmode: 'transparent'
                },
                events: {
                    'onReady': onPlayerReady,
                    'onStateChange': onPlayerStateChange
                }
            });
        }

        window.onPlayerReady = function (e) {
            
            resize();
            if (options.mute) e.target.mute();
			options.start = 0;
            e.target.seekTo(options.start);
            //e.target.playVideo();
			
			console.log("randomIdEnd" + randomIdEnd);
			randomId = (Math.floor(Math.random()*randomIdEnd));
			
			var txt=document.getElementById("cantor").firstChild.nodeValue = vetor[randomId][1];
			var txt=document.getElementById("faixa").firstChild.nodeValue = vetor[randomId][2];			
			player.loadVideoById({videoId: options.videoId[randomId][0], startSeconds: 0});
			
			var currentVolume = player.getVolume();
			currentVolume = 50 - options.increaseVolumeBy;
            player.setVolume(currentVolume + options.increaseVolumeBy);
        }


        //FUNÇÃO ATIVADA EM MUDANÇA DE ESTADOS DOS VÍDEOS
        window.onPlayerStateChange = function(state) {
    
            if (state.data === 0 && options.repeat) { // Video terminou e a opção de repetição está ativada
                player.seekTo(options.start); // restart
            } else if (state.data === 0) { // Se opção de repetição não estiver marcada
			    
				var flag = 0;
				var video_url = player.getVideoUrl();
				var tam = video_url.length;
				var dif = tam - 11;
				video_url = video_url.substring(dif,tam);
				var randomId = (Math.floor(Math.random()*randomIdEnd)); //get a new random ID
				randomId = (Math.floor(Math.random()*randomIdEnd));
				
				while(flag < 1)
				{
					if(video_url === options.videoId[randomId][0])
					{
						var randomId = (Math.floor(Math.random()*randomIdEnd)); //get a new random ID
						flag = 0;			
						console.log("flag = " + flag);
					}else
					{
						flag = 1;
						console.log("flag = " + flag);
					}
				}
                //alert("randomIdEnd " + randomIdEnd);

                //%%%%%%%%%%%%%Tratamento de Random para videos de amigos%%%%%%%%%%%%%%

                var vetorAmigo = trataInfoVideos();
                var idAmigo = 1; //Id recebido
                var qtdVideosAmigo = 2;//= $("#qtdVideos").val();

                //alert("qtdVideosAmigo: "+qtdVideosAmigo);

                if(idAmigo != 0)
                {
                    flag = 0;
				    video_url = player.getVideoUrl();
				    tam = video_url.length;
				    dif = tam - 11;
				    video_url = video_url.substring(dif,tam);
				    randomId = (Math.floor(Math.random()*qtdVideosAmigo)); 
				    randomId = (Math.floor(Math.random()*qtdVideosAmigo));
				
				    while(flag < 1)
				    {
					    if(video_url === vetorAmigo[randomId][0])
					    {
						    randomId = (Math.floor(Math.random()*qtdVideosAmigo)); 
						    flag = 0;			
					    }else
					    {
						    flag = 1;
					    }
				    }

                    alert("Amigo Random" + randomId);

                    var txt=document.getElementById("cantor").firstChild.nodeValue = vetorAmigo[randomId][1];
				    var txt=document.getElementById("faixa").firstChild.nodeValue = vetorAmigo[randomId][2];
				    player.loadVideoById({videoId: vetorAmigo[randomId][0], startSeconds: 0}); 
                }
                else
                {

                    alert("Não Amigo Random" + randomId);
				    var txt=document.getElementById("cantor").firstChild.nodeValue = options.videoId[randomId][1];
				    var txt=document.getElementById("faixa").firstChild.nodeValue = options.videoId[randomId][2];
				    player.loadVideoById({videoId: options.videoId[randomId][0], startSeconds: 0}); 
                }
            }
        }
		
        // resize handler updates width, height and offset of player after resize/init
        var resize = function() {
            var width = $(window).width(),
                pWidth, // player width, to be defined
                height = $(window).height(),
                pHeight, // player height, tbd
                $tubularPlayer = $('#tubular-player');

            // when screen aspect ratio differs from video, video must center and underlay one dimension

            if (width / options.ratio < height) { // if new video height < window height (gap underneath)
                pWidth = Math.ceil(height * options.ratio); // get new player width
                $tubularPlayer.width(pWidth).height(height).css({left: (width - pWidth) / 2, top: 0}); // player width is greater, offset left; reset top
            } else { // new video width < window width (gap to right)
                pHeight = Math.ceil(width / options.ratio); // get new player height
                $tubularPlayer.width(width).height(pHeight).css({left: 0, top: (height - pHeight) / 2}); // player height is greater, offset top; reset left
            }
			
        }

        // events
        jQuery(window).on('resize.tubular', function() {
            resize();
        })

		console.log(options.volumeUpClass);
		
        $('body').on('click','.' + options.playButtonClass, function(e) { // play button
            e.preventDefault();
            player.playVideo();
        }).on('click', '.' + options.pauseButtonClass, function(e) { // pause button
            e.preventDefault();
            player.pauseVideo();
            //player.nextVideo();
        }).on('click', '.' + options.muteButtonClass, function(e) { // mute button
            e.preventDefault();
            (player.isMuted()) ? player.unMute() : player.mute();
        }).on('click', '.' + options.volumeDownClass, function(e) { // volume down button
            e.preventDefault();
            var currentVolume = player.getVolume();
            if (currentVolume < options.increaseVolumeBy) currentVolume = options.increaseVolumeBy;
            player.setVolume(currentVolume - options.increaseVolumeBy);
        }).on('click', '.' + options.volumeUpClass, function(e) { // volume up button
            e.preventDefault();
            if (player.isMuted()) player.unMute(); // if mute is on, unmute
            var currentVolume = player.getVolume();
            if (currentVolume > 100 - options.increaseVolumeBy) currentVolume = 100 - options.increaseVolumeBy;
            player.setVolume(currentVolume + options.increaseVolumeBy);
        })
    }

    // load yt iframe js api

    var tag = document.createElement("SCRIPT");
    tag.src = "https://www.youtube.com/iframe_api";
    var firstScriptTag = document.getElementsByTagName("SCRIPT")[0];
    firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);

	
    // create plugin

    $.fn.tubular = function (options) {
        return this.each(function () {
            if (!$.data(this, 'tubular_instantiated')) { // let's only run one
                $.data(this, 'tubular_instantiated', 
                tubular(this, options));
            }
        });


    }

})(jQuery, window);
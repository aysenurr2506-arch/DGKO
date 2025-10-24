// Kart elementini seçiyoruz
const kart = document.querySelector('.birthday-card');
const mesajAlani = document.getElementById('mesaj');

// Tıklama olayını yönetecek fonksiyon
function kutlamaGoster() {
    // Mesajı değiştiriyoruz
    mesajAlani.innerHTML = "Doğum Günün Kutlu Olsun!\n🎉🎂🎈";
    
    // Kartın stilini değiştirmek için 'acik' sınıfını ekliyoruz
    kart.classList.add('acik');

    // Tıklandığında sadece bir kere çalışması için click olayını kaldırıyoruz
    kart.onclick = null;
}

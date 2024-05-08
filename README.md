# Chain of Responsibility 
Sorumluluk Zinciri, istekleri bir işleyici zinciri boyunca aktarmamıza olanak tanıyan davranışsal bir tasarım modelidir. Bir istek alındığında, her işleyici ya isteği işlemeye ya da zincirdeki bir sonraki işleyiciye iletmeye karar verir.
# Uygulanabilirlik
<ul>
  <li><b>Programın farklı türdeki istekleri çeşitli şekillerde işlemesi beklendiğinde, ancak isteklerin tam türleri ve sıraları önceden bilinmediğinde Sorumluluk Zinciri modeli kullanılabilir.</b></li>
      Desen, birkaç işleyiciyi tek bir zincire bağlamamıza ve bir istek aldığımızda her işleyiciye bunu işleyip işleyemeyeceğini sormamıza olanak tanır. Bu şekilde tüm işleyicilerin isteği işleme alma şansı olur.
  <li><b>Birkaç işleyicinin belirli bir sırayla yürütülmesi gerektiğinde bu model kullanılabilir.</b></li>
      Zincirdeki işleyicileri istediğimiz sırayla bağlayabildiğimiz için tüm istekler zincirden tam olarak planladığımız gibi iletilecektir.
  <li><b>İşleyici kümesinin ve bunların sırasının çalışma zamanında değişmesi gerektiğinde Chain Of Responsibility modeli kullanılabilir.</b></li>
      İşleyici sınıflarının içindeki bir referans alanı için ayarlayıcılar sağlarsak işleyicileri dinamik olarak ekleyebilir, kaldırabilir veya yeniden sıralayabiliriz.
</ul>

# Gerçek Hayattan Bir Örnek
Müşteri hizmetlerini aradığınızda sizi işlemleri sıralayarak ve sesli yanıt veya tuşlama ile ilgili kişiye ulaştırdığı senaryoda sorumluluk prensibi benzeri bir yapı işliyor. Çünkü sırayla kontroller sağlanarak eğer zincirin şuanki halkası isteğinizi karşılayabiliyorsa ona yönlendiriliyor eğer karşılayamıyorsa bir sonraki halkaya aktarılıyorsunuz ta ki isteğinizi karşılayabilecek yetkiliye ulaşana kadar.



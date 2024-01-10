import React from 'react';

const ContactInfo = () => {
  return (
    
<div className="call-to-action border-top border-bottom border-warning">
  <div className="container">
    <div className="row">
      <div className="col-md-4">
        <div className="mx-xl-5">
          <h3 className="text-nowrap info">Informações e contato</h3>
          <ul className="mt-3">
            <li>
              <i className="fas fa-map-marker-alt me-1" aria-hidden="true"></i>
              Avenida das Acácias, 22
              <span>Cidade Ficticia - PE</span>
            </li>
            <li>
              <i className="far fa-envelope me-2 mt-4" aria-hidden="true"></i>
              <a href="mailto:info@example.com">yammetal@hotmail.com</a>
            </li>
            <li>
              <i className="fas fa-phone me-1 mt-4" aria-hidden="true"></i>
              (81)3000-5555
            </li>
            <li>
              <i style={{ color: '#029702' }} className="fab fa-whatsapp me-1 mt-4" aria-hidden="true"></i>
              (81)99999-9999
            </li>
          </ul>
        </div>
      </div>
      <div className="col-md-4">
        <div className="mx-xl-5">
          <h3 className="sobre">Sobre Nós</h3>
          <p className="text-dark mt-2">
            Somos uma nova agência de viagens apaixonada por transformar sonhos em experiências reais. Exploramos destinos únicos, oferecendo um toque pessoal e cuidado excepcional em cada jornada.
          </p>
        </div>
      </div>
      <div className="col-md-4">
        <div className="px-xl-5">
          <h3 className="acei">Aceitamos:</h3>
          <ul className="mt-2">
            <li style={{ display: 'inline-block', marginRight: '10px' }}>
              <a href="#"><img style={{ width: '5em', height: '3em', borderRadius: '5px' }} src="/images/visa.jpg" alt="Ícone do cartão Visa" /></a>
            </li>
            <li style={{ display: 'inline-block', marginRight: '10px', marginBottom: '10px' }}>
              <a href="#"><img style={{ width: '5em', height: '3em', borderRadius: '5px' }} src="/images/master.jpg" alt="Íconedo cartão master" /></a>
            </li>
            <ul className="agileits_w3layouts_footer_grid_list" style={{ listStyle: 'none', padding: '0' }}>
              <li style={{ display: 'inline-block', marginRight: '10px', marginBottom: '10px' }}>
                <a href="#"><img style={{ width: '5em', height: '3em', borderRadius: '5px' }} src="/images/picpay.png" alt="Ícone do picpay" /></a>
              </li>
              <li style={{ display: 'inline-block', marginRight: '10px' }}>
                <a href="#"><img style={{ width: '5em', height: '3em', borderRadius: '5px' }} src="/images/elo.png" alt="Ícone do cartão elo" /></a>
              </li>
              <ul className="agileits_w3layouts_footer_grid_list" style={{ listStyle: 'none', padding: '0' }}>
                <li style={{ display: 'inline-block', marginRight: '10px' }}>
                  <a href="#"><img style={{ width: '5em', height: '3em', borderRadius: '8px' }} src="/images/discover.jpg" alt="Ícone do cartão discover" /></a>
                </li>
                <li style={{ display: 'inline-block', marginRight: '10px' }}>
                  <a href="#"><img style={{ width: '5em', height: '3em', borderRadius: '5px' }} src="/images/pix.jpg" alt="Ícone do pix" /></a>
                </li>
              </ul>
            </ul>
            <p className="text-black">Nossas Redes Sociais</p>
            <ul className="px-4">
              <a href="https://www.linkedin.com/in/erick-maur%C3%ADcio-tavares-425395224/" rel="noopener noreferrer" className="text-decoration-none me-3">
                <i className="fab fa-linkedin"></i>
              </a>
              <a href="#" rel="noopener noreferrer" className="text-decoration-none me-3">
                <i className="fab fa-facebook"></i>
              </a>
              <a href="#" rel="noopener noreferrer" className="text-decoration-none me-3">
                <i className="fab fa-instagram"></i>
              </a>
              <a href="#" rel="noopener noreferrer" className="text-decoration-none">
                <i className="fab fa-twitter"></i>
              </a>
            </ul>
          </ul>
        </div>
      </div>
    </div>
    <div className="mt-5">
      <div className="newles mb-1">
        <h3>Assine a nossa Newsletter</h3>
        <form action="/Newsletter" method="post">
          <input type="email" id="email" name="email" placeholder="Digite seu e-mail..." required />
          <input type="submit" value="Assinar" />
        </form>
      </div>
    </div>
  </div>
</div>


  );
};

export default ContactInfo;

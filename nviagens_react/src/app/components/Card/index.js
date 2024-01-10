import styles from './card.module.css'

export default async function Card() {
  const cards = await fetch('http://localhost:5035/api/Reserva').then(res => res.json());
  console.log(cards);


  return (
    <div className={styles.container}>
      {cards?.map((card) => (
        <div key={card.id} className={styles.card}>

          <img src={card.destinoURL} />
          <div className={styles.card_nome}>
            <p className="text-black mx-3"><b>Nome:</b> {card.nome}</p>
            <p className="text-black mx-3"><b>Destino: </b>{card.destino}</p>
            <p className="text-black mx-3"><b>CPF:</b> {card.cpf}</p>
            <p className="text-black mx-3"><b>Número:</b> {card.numero}</p>
            <p className="text-black mx-3"><b>Data e Hora:</b> {card.checkIn}</p>
            <p className="text-black mx-3"><b>Quantidade de Pessoas:</b> {card.pessoas}</p>
            <p className="text-black mx-3"><b>Passagem:</b> {card.valor}R$</p>

          </div>
        </div>
      ))}
    </div>
  );
}

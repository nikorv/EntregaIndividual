import styles from './card.module.css'

export default async function Details({ params }) {
	console.log("esse e o id enviado: ", params.id)

	const card = await fetch(`http://localhost:5233/api/Agencia/${params.id}`).then((res) =>
		res.json(),
	)


	return (
		<div className={styles.container}>
			<div className={styles.card}>
				<div className={styles.card_title}>
				<img src={card.IconeClient} alt={card.title}/>
					<li>
					<p>{card.name}</p>
					<p>{card.dataNasc}</p>
					<p>{card.email}</p>
					<p>{card.phone}</p>
					</li>
				</div>
			</div>
		</div>
	)
}

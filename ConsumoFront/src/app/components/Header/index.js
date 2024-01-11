import Link from 'next/link'

export default function Header() {
	return (
		<header className="header">
			<img src="/logotipo-removebg-preview.png" alt="logo" />
			<ul>
				<li>
					<Link href="/RotaUm">Link 1</Link>
				</li>
				<li>
					<Link href="/RotaDois">Link 2</Link>
				</li>
				<li>
					<Link href="/RotaTres">Link 3</Link>
				</li>
			</ul>
		</header>
	)
}
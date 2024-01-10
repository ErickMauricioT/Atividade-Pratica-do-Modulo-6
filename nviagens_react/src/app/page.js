
import Link from 'next/link'

export default function Home() {
  return (
    <div className="p-5">
      
    <h1  className="p-5" align="center">Bem-Vindo</h1>
    <h3 align="center">A Pagina de Visualização de Reserva</h3>
    <div className=" bg-light" align="center">
  			
					    <Link href="/RotaUm"><h2 className=" text-info">Lista de Reservas</h2></Link>
				
</div>

    </div>
  )
}

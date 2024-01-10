import Footer from './components/Footer'
import Header from './components/Header'
import ContactInfo from './components/ContactInfo'
import './globals.css'
import './components/styles/animate.css'
import './components/styles/bootstrap.min.css'
import './components/styles/fontawesome.css'
import './components/styles/owl.css'
import './components/styles/flex-slider.css'


export default function RootLayout({ children }) {
	return (
		<html lang="en">
			<body>
				<Header />
				<main>{children}</main>

				 <ContactInfo />
        <Footer/>
			</body>
		</html>
	)
}

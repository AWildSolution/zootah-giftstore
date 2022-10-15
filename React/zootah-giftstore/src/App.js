import './App.css';
import ItemCard from './components/ItemCard';
import zooCup from './images/zootahCup.jpeg';

export default function App() {
  return (
    <>
    <div className='flex flex-auto flex-row flex-wrap'>

      <ItemCard imageLocation={zooCup} product={{name:'New Shirt', price:'50.00', isInStock:true, 
      sizes:[
        {
          size:'S', 
          quantity: 0
        }, 
        {
          size:'M', 
          quantity: 8
        }, 
        {
          size:'L', 
          quantity: 8
        }
            
        ]
        }}/>
      <ItemCard imageLocation={zooCup} product={{name:'Old Shirt', price:'150.00', isInStock:false, sizes:[
        {
          size:'S', 
          quantity: 0
        }, 
        {
          size:'M', 
          quantity: 0
        }, 
        {
          size:'L', 
          quantity: 0
        }
            
        ]}}/>
   </div>
    </>
  )
}


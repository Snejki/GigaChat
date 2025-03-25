import { Button } from '@/components/ui/button'
import React from 'react'

interface ConversationPageProps {

}

const ConversationPage = (props: ConversationPageProps) => {
  return (
    <div className="flex flex-col items-center justify-center min-h-svh">
      <Button>Click me</Button>
    </div>  )
}

export default ConversationPage
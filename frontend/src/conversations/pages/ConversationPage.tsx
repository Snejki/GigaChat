import { GigaChatApiApi } from '@/common/api/api'
import { Button } from '@/components/ui/button'
import React from 'react'

interface ConversationPageProps {

}

const ConversationPage = (props: ConversationPageProps) => {
  const api = new GigaChatApiApi();
  api.apiChatPost
  api.

  return (
    <div className="flex flex-col items-center justify-center min-h-svh">
      <Button>Click me</Button>
    </div>  )
}

export default ConversationPage
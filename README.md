# 개인과제 -CatDungeon

강의를 따라 기본틀을 만든 후 리소스업데이트와 필수요구사항구현, 선택요구사항구현까지 진행했습니다
## 어려웠던 점
### 필수요구사항
카메라가 캐릭터를 따라가는 부분에서 단순하게 MainCamera를 캐릭터 안에 넣어줬는데 맞는 방법인지 조금 헷갈립니다.
### 선택요구사항
캐릭터 애니메이션은 쉽게 적용했지만 캐릭터가 움직이지 않을때는 애니메이션을 멈추고 싶었는데 어려워서 구현하지 못했습니다.

이름 입력 시스템은 playerprefs를 사용하여 구현하였는데 처음에는 데이터를 지울줄 몰라서 자꾸 시작화면이 스킵되는 문제가 발생했고,
이후 구글링을 통해 데이터삭제가 필요하다는것을 보고 시작전 Awake함수에서 playerprefs.deleteall을 사용하여 데이터를 지운후 시작해주었습니다.

캐릭터가 벽에 부딪혔을때 "벽에 부딪혔다..."라는 텍스트를 하단 UI에 출력하는 기능도 넣었는데, 출력만 되고 사라지지 않아서

sleep을 주어봤지만 함수가 2초간 멈추는것이 아닌 게임 자체가 2초간 멈추는 문제가 발생했습니다.

invoke를 통해 출력된 텍스트를 없애는 함수를 2초뒤에 실행해보려고 했지만 어찌된 영문인지 log에 해당 함수를 불러올수 없다는 문구만 떴습니다.

그래서 출력까진 구현했으나 없애는 기능을 구현하지 못한채 마무리 하였습니다.

## 느낀 점
코드를 작성하면서 내가 원하는 기능들을 어떤흐름으로 작업하면 되겠다는 생각은 들었지만, 실제로 어떤 함수를 어떻게 사용해서 작동시키는가에 대해 많은 어려움을 느꼈습니다.

좀더 많은 예제들과 이전에 강의를 들으며 작성했던 코드들을 되돌아보며 꼼꼼한 공부가 더 필요하다는 생각이 들었습니다.

 

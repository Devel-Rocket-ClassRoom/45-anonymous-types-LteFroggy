# ConfigMerge

게임 설정 데이터를 익명 타입으로 관리하며, 타입 동일성과 값 동등성을 비교하는 프로그램을 작성하세요.

## 요구사항

1. 기본 설정과 사용자 설정을 각각 익명 타입으로 생성
   - 기본 설정: ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 50, Difficulty = "보통"
   - 사용자 설정: ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 80, Difficulty = "어려움"

2. 두 설정의 비교 결과 출력
   - `GetType()` 비교로 같은 타입인지 확인
   - `Equals()` 비교로 값이 같은지 확인

3. 기본 설정과 동일한 값을 가진 백업 설정 생성
   - ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 50, Difficulty = "보통"
   - 기본 설정과 `Equals()` 비교

4. 같은 타입인 기본 설정, 사용자 설정, 백업 설정을 배열로 묶어 출력

5. 속성 순서가 다른 설정 생성
   - Volume = 50, Difficulty = "보통", ResolutionWidth = 1920, ResolutionHeight = 1080
   - 기본 설정과 `GetType()` 비교하여 다른 타입인지 확인

## 예상 실행 결과

```
=== 게임 설정 비교 ===

[기본 설정]
{ ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 50, Difficulty = 보통 }

[사용자 설정]
{ ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 80, Difficulty = 어려움 }

[타입 비교]
같은 타입: True (속성 구조가 동일)

[값 비교]
Equals 결과: False (Volume, Difficulty 값이 다름)

[백업 설정]
{ ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 50, Difficulty = 보통 }
기본 설정과 Equals: True (모든 값이 동일)

=== 설정 목록 (배열) ===
설정 1: 1920x1080, 볼륨 50, 난이도 보통
설정 2: 1920x1080, 볼륨 80, 난이도 어려움
설정 3: 1920x1080, 볼륨 50, 난이도 보통

=== 속성 순서가 다른 설정 ===
{ Volume = 50, Difficulty = 보통, ResolutionWidth = 1920, ResolutionHeight = 1080 }
기본 설정과 같은 타입: False (속성 순서가 달라 다른 타입)
```

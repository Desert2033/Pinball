<H1>Pinball</H1>
            
игра под андроид в портретном режиме

<H1>Управление</H1>

Нажимайте на стики(коричневые палки) для того чтобы отбивать мяч

<H1>Сцены и Уровни</H1>

В игре 2 сцены(“Level 1”, “Level 2”)
объект Game - используется для переключение сцен(уровней)

объект Level Root с компонентом Level - есть на каждой сцене уровня. Хранит в себе настройки уровня
и ссылку на Game для переключения уровня метод - EndLevel()

Основные настойки Level

BallStartPoint - точка где появляется мяч

 PointsForFinish - количество очков требуемое для выигрыша

<H1>Ball</H1>

Поделен на 3 класса: Ball, BallPresenter, BallVIew
Ball - модель, хранит количество очков и увеличивает их
BallPresenter - связующий класс между моделью и view.
Там же хранит в себе GamePointsView для отображение текущих очков на мяче
BallView - используется для передвижение и отправки событий

Для создания Ball, используется класс BallSetup, метод - AddBall(Vector3 pointStart) в 
качестве аргумента передается точка, где появится мяч.

<H1>Bonuses</H1>

3 бонуса дающие 5, 10 и 20 очков - класс PointsBonus - в переменную 
“Count Give Points” - передается количество очков который дает данный бонус.

Бонус добавляющий новый мяч при столкновении - класс PlusBall
						
<H1>Finish Of Level</H1>

Поделен на 3 класса: FinishOfLevel, FinishOfLevelPresenter, FinishOfLevelVIew
FinishOfLevel- модель, хранит количество очков и уменьшает их
BallPFinishOfLevelPresenterresenter - связующий класс между моделью и view.
Там же хранит в себе GamePointsView для отображение текущих очков на текстуре
FinishOfLevelVIew - отправки событий о столкновение с мячом

Для создания FinishOfLevel, используется класс FinishOfLevelSetup, метод - 
OnEnable(). OnDisable() - удаляется все связи в ивентами. OnDestroy() - удаляется все связи в ивентами и удаляет сам объект.

<H1>Другие классы</H1>

класс Follow - получает target и offset и следует за target.

класс FallBall - отвечает за выкидывания мячей из ямы, если те туда провалились 

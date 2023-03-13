#   Exploring the universe

![enter image description here](https://i.imgur.com/NdWwvxJ.png)

## Introduce

Game Exploring the universe  thuộc thể loại thể loại game bắn súng (shooter game) hoặc game chiến đấu (combat game). Trong game bắn máy bay, người chơi sẽ điều khiển một chiếc máy bay để tiêu diệt các mục tiêu đang bay trên bầu trời hoặc trên mặt đất. Thường thì game bắn máy bay có cách chơi rất nhanh, đòi hỏi phản xạ nhanh và kỹ năng chiến thuật để vượt qua các cấp độ khó khăn. Nhiều game bắn máy bay cũng có thêm các tính năng như tùy chỉnh máy bay, nâng cấp vũ khí, và chiến đấu với các Enemy đặc biệt.

## how to play

Game xây dựng  trên nền tảng Android, sử dụng Joystick để di chuyển và các nút để thực hiện việc bắn các đạn.
trên PC, máy bay được di chuyển bằng các phím mũi tên, và  các phím Z (đạn lazel), phím X( đạn ném), phím C ( Đạn khói).

## Plane
Được xây dựng trên interface IPlane

![Imgur-Upload](https://i.imgur.com/h082Q7q.png)

IPlane được kế thừa bởi class MyPlane và Enemy


### MyPlane
***trạng thái:*** *Hoàn thành 1/1
 
 * Jet Airplane : Máy bay của  người chơi, có thể di chuyển bằng Joystick hoặc bàn phím.
 
 ### Enemy
 ***trạng thái:*** *Hoàn thành 3/5
* Rock ( thiên thạch): Enemy cấp 1, di chuyển thẳng, được random kích thước 1,2,3 và random tốc độ di chuyển. 
![Không có mô tả.](https://scontent.fsgn2-5.fna.fbcdn.net/v/t1.15752-9/335439013_542583534528025_1606988361769204512_n.png?_nc_cat=104&ccb=1-7&_nc_sid=ae9488&_nc_ohc=SJSJgudsti4AX9_l8lK&_nc_ht=scontent.fsgn2-5.fna&oh=03_AdR_eEU92ulf4eFPujkOWh2fkwE9h1zoVomQJfG_4UbRfw&oe=64364A51)
* Fighter aircraft ( máy bay chiến đấu): Enemy cấp 1, di chuyển hình sine, bắn đan laze.

![Không có mô tả.](https://scontent.fsgn2-9.fna.fbcdn.net/v/t1.15752-9/335129374_1876701106039664_8128558979805074652_n.png?_nc_cat=103&ccb=1-7&_nc_sid=ae9488&_nc_ohc=s4RBIqBgi2oAX-jarEP&_nc_ht=scontent.fsgn2-9.fna&oh=03_AdQoey5t8m1hv6m0Tv2FFSCRiORUNpMIib6u3eVUo5antw&oe=64364726)


* Econnaissance plane ( máy bay trinh sát): Enemy cấp 1, di chuyển đuổi theo player.


![Không có mô tả.](https://scontent.fsgn2-5.fna.fbcdn.net/v/t1.15752-9/335939703_129809886702825_4478663882574387258_n.png?_nc_cat=104&ccb=1-7&_nc_sid=ae9488&_nc_ohc=ie1SAdBBeAYAX_ZRspI&_nc_ht=scontent.fsgn2-5.fna&oh=03_AdR1ENw_tghMSGP3LpoUAI2Ko7Lo_zMJosERUFjHBJtxow&oe=643657AC)
* Stealth aircraft ( máy bay tàn hình): Enemy cấp 2, di chuyển đuổi theo player và bắn súng lazel, material ẩn, sau một khoảng thời gian thì xuất hiện 1 tới 2 giây.
* Space battleship (chiến hạm vũ trụ): Bắn tên lửa hướng theo player, Enemy cấp 3, cần bắn trúng 10 viên đạn để tiêu diệt.

## Bullets:
Được xây dựng trên interface IBullet.

![enter image description here](https://i.imgur.com/MxDrOt4.png) 

IBullet được kế thừa bởi 2 class là BulletPlayer và BulletEnemy.

### BulletPlayer
***trạng thái:*** *Hoàn thành 3/3*
Bao gồm 3 loại bullet: 
* Laser Bullet (đạn laze) đi thẳng, tốc độ chậm. Sát thương cấp 1 (Tiêu diện các enemy loại 1)
* throwing bullets (đạn nén): đi thẳng, tốc độ nhanh, tiêu diệt 3 mục tiêu liên tiếp, sát thương cấp 1.
* Explosive bullet ( đạn nổi): đi theo đường sin, tốc độ chậm, tạo ra vụ nổ tiêu diệt các enemy trong vụ nổi, sát thương cấp 2
* ![Imgur-Upload](https://i.imgur.com/D2GvymF.png)


### BulletEnemy
***trạng thái:*** *Hoàn thành 1/3*
 * AirCraftBullet : đạn của máy bay AirCraft, cấp độ 1, tốc độ trung bình.
 
 * rocket : đạn space battleship, cấp độ 2, tốc độ nhanh, hướng tới player. cần 3 đạn player cấp 1  hoặc 1 đạn player cấp 2 tiêu diệt.

* .....

 
 ## Energy

![Không có mô tả.](https://scontent.fsgn2-7.fna.fbcdn.net/v/t1.15752-9/335131509_732642868333130_8013481193207864005_n.png?_nc_cat=108&ccb=1-7&_nc_sid=ae9488&_nc_ohc=7aJhXQbgAlwAX97X7Vj&_nc_ht=scontent.fsgn2-7.fna&oh=03_AdTRp82sTA43DO61c6lK5vz4dn2nON28B4TlwiLEAj2zJw&oe=6436351A)

- Gồm 4 loại năng lượng: red, blue, yellow và  HP. mỗi loại năm lương sẽ cung cấp khả năng sử dụng các loại đạn tương ứng. Người chơi sử  dụng năng lượng này để  quy đổi các vật phẩm trong store để nâng cấp plane.


## Items
***trạng thái:*** *Chưa  hoàn thành*

Là các vật phẩm giúp cho player tăng cường sức mạnh.
Người chơi sử dụng năng lượng thu thập được để quy đổi thành vật phẩm
![Không có mô tả.](https://scontent.fsgn2-7.fna.fbcdn.net/v/t1.15752-9/335721662_591183022934112_838938544079724028_n.png?_nc_cat=100&ccb=1-7&_nc_sid=ae9488&_nc_ohc=niLGYBYZSBoAX-leKXc&_nc_ht=scontent.fsgn2-7.fna&oh=03_AdSJ2ghCzPdn7UNZI6IN7XK6shor5dW0xhZ5yuYi2hSOrw&oe=643624AB)

* protective circle ( vòng tròn bảo vệ) : sử dụng trong 30s, bảo vệ player khỏi enemy hoặc  đạn cấp 1, bị phá  vở bởi đạn cấp 2.
* machine gun ( súng liên thanh): sử dụng trong 60s, nâng cấp súng lazel cho player từ 1 đạn thành 3 đạn hướng 3 hướng, tốc độ nhanh. Tuy nhiên mỗi lần bắn sẽ hao hụt 3 năng lượng đỏ thay vì 1.
* jet engine (động cơ phản lực): giúp player di chuyển nhanh gấp 3 lần trong 60 giây
* stopwatch time ( đồng hồ làm chậm thời gian) làm cho không gian di chuyển chậm lại, trừ player.

## Object Pool
***trạng thái:*** *Hoàn thành 

## Score Sytem:
***trạng thái:*** *Chưa Hoàn thành 

## Sound Sytem:
***trạng thái:*** *Chưa Hoàn thành 

## UI Sytem:
***trạng thái:*** *Chưa Hoàn thành 

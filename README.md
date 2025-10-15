<div align="center">

# AnatomyAR Explorer

You can read [Russian version of readme.md](https://github.com/lostdata2/AnatomyAR-Explorer/blob/main/README-RU.md)

![AnatomyAR Logo](LOGO)

**Interactive Human Anatomy Learning in Augmented Reality**

</div>

## About The Project

![App Screenshot](LINK)

**Human Anatomy in Augmented Reality** is an innovative educational application developed for Android that transforms the study of human anatomy into an engaging interactive journey using augmented reality technology.

**Key Features:**
- **Interactive 3D models** of human body organs in real scale
- **AR mode** for projecting anatomical structures into real space
- **Detailed body systems**: skeletal, muscular, circulatory, nervous and others
- **Educational content** with verified medical information

The project is designed for teaching anatomy lessons in elementary grades and for anyone interested in human body structure and augmented reality technologies.

## 🛠 Technologies Used

- **Unity** 6000.2.7f2
- **AR Foundation**
- **Google ARCore**
- **Blender** (For 3D modeling)
- **Android SDK/NDK** (for building to target architecture)

## ⚙️ System Requirements
- Android **API level 21** (Android 5.0)
- **Google ARCore** support
- **Rear camera** with HDR support
- **ARM64** architecture processor
- **2GB** RAM

## 🚀 Usage

### Main Features
- **Study Mode**: Explore individual body systems
- **AR Mode**: Project 3D models into real space
- **Anatomy Atlas**: Detailed information about each organ

### Installation
1. **Download** the latest [Release](https://github.com/lostdata2/AnatomyAR-Explorer/releases)
2. **Install** on your Android smartphone

### Application Usage
1. **Open** the application
2. **Select** a grade to start (can be changed later in settings)
3. On the main screen **press** the start button
4. **Choose** surface type (walls and floor/table)
5. **Scan** the surface from multiple angles until the selected surface is fully scanned
6. **Select** an organ in the organ menu
7. **Tap** within the scanned area to place the organ on the surface
8. You can **examine** it from different angles by moving the camera around the model (gesture support planned for future)

## ⌨️ Development

1. Install **Unity** 6000.2.7f2

2. Clone the repository
```bash
git clone https://github.com/lostdata2/AnatomyAR-Explorer
```

3. Open the project in Unity (use "add from disk" in Unity Hub)
    
4. Make necessary changes to the project

5. Build the project (File >> Build Settings >> Build)

## 🗺 Development Goals
- [x] Vertical and horizontal surface recognition
- [x] Ability to place objects on recognized surfaces
- [ ] Selecting surface mode (horizontal or vertical)
- [ ] Learning grade configuration (with saving via PlayerPrefs)
- [ ] Ability to choose organs for placing
- [ ] Ability to place after clicking button
- [ ] Ability to scale and rotate argans by swiping

## 🤝 Contributing

Currently (until July 1, 2026), due to project participation, we **categorically DO NOT** accept any pull requests. All pull requests submitted before this deadline **will NOT be** considered even after. However, you can fork the code for yourself and if desired, submit a pull request **after** the project submission period ends.

## 📄 License

Distributed under the `GPL-3.0 License`. See `LICENSE` for more information. However, with written permission from the copyright holder, you may be granted permission to use under the MIT license.

---

<div align="center">

⭐️ If you found this project useful, give it a star!

</div>

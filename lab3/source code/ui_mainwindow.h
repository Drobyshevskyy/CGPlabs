/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 6.4.1
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtGui/QIcon>
#include <QtWidgets/QApplication>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QRadioButton>
#include <QtWidgets/QWidget>
#include "mywidget.h"

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralwidget;
    MyWidget *widget;
    QPushButton *pushButton;
    QPushButton *pushButton_2;
    QPushButton *pushButton_3;
    QRadioButton *radioButton;
    QLabel *label;
    QRadioButton *radioButton_2;
    QRadioButton *radioButton_3;
    QRadioButton *radioButton_4;
    QRadioButton *radioButton_5;
    QRadioButton *radioButton_6;
    QRadioButton *radioButton_7;
    QRadioButton *radioButton_8;
    QRadioButton *radioButton_9;
    QPushButton *pushButton_4;
    QPushButton *pushButton_5;
    QPushButton *pushButton_6;
    QPushButton *pushButton_7;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName("MainWindow");
        MainWindow->resize(656, 502);
        centralwidget = new QWidget(MainWindow);
        centralwidget->setObjectName("centralwidget");
        widget = new MyWidget(centralwidget);
        widget->setObjectName("widget");
        widget->setGeometry(QRect(80, 70, 561, 421));
        pushButton = new QPushButton(centralwidget);
        pushButton->setObjectName("pushButton");
        pushButton->setGeometry(QRect(10, 10, 75, 23));
        pushButton_2 = new QPushButton(centralwidget);
        pushButton_2->setObjectName("pushButton_2");
        pushButton_2->setGeometry(QRect(90, 10, 75, 23));
        pushButton_3 = new QPushButton(centralwidget);
        pushButton_3->setObjectName("pushButton_3");
        pushButton_3->setGeometry(QRect(10, 40, 75, 23));
        radioButton = new QRadioButton(centralwidget);
        radioButton->setObjectName("radioButton");
        radioButton->setGeometry(QRect(10, 90, 71, 31));
        QIcon icon;
        icon.addFile(QString::fromUtf8(":/new/prefix1/img1/box.bmp"), QSize(), QIcon::Normal, QIcon::Off);
        radioButton->setIcon(icon);
        radioButton->setIconSize(QSize(32, 32));
        radioButton->setChecked(true);
        label = new QLabel(centralwidget);
        label->setObjectName("label");
        label->setGeometry(QRect(10, 70, 47, 13));
        radioButton_2 = new QRadioButton(centralwidget);
        radioButton_2->setObjectName("radioButton_2");
        radioButton_2->setGeometry(QRect(10, 130, 71, 31));
        QIcon icon1;
        icon1.addFile(QString::fromUtf8(":/new/prefix1/img1/1.bmp"), QSize(), QIcon::Normal, QIcon::Off);
        radioButton_2->setIcon(icon1);
        radioButton_2->setIconSize(QSize(32, 32));
        radioButton_3 = new QRadioButton(centralwidget);
        radioButton_3->setObjectName("radioButton_3");
        radioButton_3->setGeometry(QRect(10, 160, 71, 31));
        QIcon icon2;
        icon2.addFile(QString::fromUtf8(":/new/prefix1/img1/2.bmp"), QSize(), QIcon::Normal, QIcon::Off);
        radioButton_3->setIcon(icon2);
        radioButton_3->setIconSize(QSize(32, 32));
        radioButton_4 = new QRadioButton(centralwidget);
        radioButton_4->setObjectName("radioButton_4");
        radioButton_4->setGeometry(QRect(10, 200, 71, 31));
        QIcon icon3;
        icon3.addFile(QString::fromUtf8(":/new/prefix1/img1/3.bmp"), QSize(), QIcon::Normal, QIcon::Off);
        radioButton_4->setIcon(icon3);
        radioButton_4->setIconSize(QSize(32, 32));
        radioButton_5 = new QRadioButton(centralwidget);
        radioButton_5->setObjectName("radioButton_5");
        radioButton_5->setGeometry(QRect(10, 240, 71, 31));
        QIcon icon4;
        icon4.addFile(QString::fromUtf8(":/new/prefix1/img1/4.bmp"), QSize(), QIcon::Normal, QIcon::Off);
        radioButton_5->setIcon(icon4);
        radioButton_5->setIconSize(QSize(32, 32));
        radioButton_6 = new QRadioButton(centralwidget);
        radioButton_6->setObjectName("radioButton_6");
        radioButton_6->setGeometry(QRect(10, 290, 71, 31));
        QIcon icon5;
        icon5.addFile(QString::fromUtf8(":/new/prefix1/img1/cross.bmp"), QSize(), QIcon::Normal, QIcon::Off);
        radioButton_6->setIcon(icon5);
        radioButton_6->setIconSize(QSize(32, 32));
        radioButton_7 = new QRadioButton(centralwidget);
        radioButton_7->setObjectName("radioButton_7");
        radioButton_7->setGeometry(QRect(10, 330, 71, 31));
        QIcon icon6;
        icon6.addFile(QString::fromUtf8(":/new/prefix1/img1/d.bmp"), QSize(), QIcon::Normal, QIcon::Off);
        radioButton_7->setIcon(icon6);
        radioButton_7->setIconSize(QSize(32, 32));
        radioButton_8 = new QRadioButton(centralwidget);
        radioButton_8->setObjectName("radioButton_8");
        radioButton_8->setGeometry(QRect(10, 370, 71, 31));
        QIcon icon7;
        icon7.addFile(QString::fromUtf8(":/new/prefix1/img1/r.bmp"), QSize(), QIcon::Normal, QIcon::Off);
        radioButton_8->setIcon(icon7);
        radioButton_8->setIconSize(QSize(32, 32));
        radioButton_9 = new QRadioButton(centralwidget);
        radioButton_9->setObjectName("radioButton_9");
        radioButton_9->setGeometry(QRect(10, 410, 71, 31));
        QIcon icon8;
        icon8.addFile(QString::fromUtf8(":/new/prefix1/img1/rd.bmp"), QSize(), QIcon::Normal, QIcon::Off);
        radioButton_9->setIcon(icon8);
        radioButton_9->setIconSize(QSize(32, 32));
        pushButton_4 = new QPushButton(centralwidget);
        pushButton_4->setObjectName("pushButton_4");
        pushButton_4->setGeometry(QRect(90, 40, 121, 23));
        pushButton_5 = new QPushButton(centralwidget);
        pushButton_5->setObjectName("pushButton_5");
        pushButton_5->setGeometry(QRect(200, 10, 75, 23));
        pushButton_6 = new QPushButton(centralwidget);
        pushButton_6->setObjectName("pushButton_6");
        pushButton_6->setGeometry(QRect(220, 40, 75, 23));
        pushButton_7 = new QPushButton(centralwidget);
        pushButton_7->setObjectName("pushButton_7");
        pushButton_7->setGeometry(QRect(300, 40, 75, 23));
        MainWindow->setCentralWidget(centralwidget);

        retranslateUi(MainWindow);

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QCoreApplication::translate("MainWindow", "MainWindow", nullptr));
        pushButton->setText(QCoreApplication::translate("MainWindow", "\320\227\320\260\320\263\321\200\321\203\320\267\320\270\321\202\321\214", nullptr));
        pushButton_2->setText(QCoreApplication::translate("MainWindow", "\320\247/\320\221", nullptr));
        pushButton_3->setText(QCoreApplication::translate("MainWindow", "\320\255\321\200\320\276\320\267\320\270\321\217 (min)", nullptr));
        radioButton->setText(QString());
        label->setText(QCoreApplication::translate("MainWindow", "\320\255\320\273\320\265\320\274\320\265\320\275\321\202", nullptr));
        radioButton_2->setText(QString());
        radioButton_3->setText(QString());
        radioButton_4->setText(QString());
        radioButton_5->setText(QString());
        radioButton_6->setText(QString());
        radioButton_7->setText(QString());
        radioButton_8->setText(QString());
        radioButton_9->setText(QString());
        pushButton_4->setText(QCoreApplication::translate("MainWindow", "\320\224\320\270\320\273\320\260\321\202\320\260\321\206\320\270\321\217 (max)", nullptr));
        pushButton_5->setText(QCoreApplication::translate("MainWindow", "\320\237\321\200\320\270\320\274\320\265\320\275\320\270\321\202\321\214", nullptr));
        pushButton_6->setText(QCoreApplication::translate("MainWindow", "\320\240\320\260\320\267\320\274\321\213\320\272\320\260\320\275\320\270\320\265", nullptr));
        pushButton_7->setText(QCoreApplication::translate("MainWindow", "\320\227\320\260\320\274\321\213\320\272\320\260\320\275\320\270\320\265", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H

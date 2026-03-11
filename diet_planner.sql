-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Хост: localhost
-- Время создания: Мар 11 2026 г., 12:50
-- Версия сервера: 5.7.24
-- Версия PHP: 7.1.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `diet_planner`
--

-- --------------------------------------------------------

--
-- Структура таблицы `meals`
--

CREATE TABLE `meals` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `meal_date` date NOT NULL,
  `meal_type` varchar(250) COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'Завтрак, Обед, Ужин, Перекус',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `meals`
--

INSERT INTO `meals` (`id`, `user_id`, `meal_date`, `meal_type`, `created_at`) VALUES
(1, 1, '2026-03-11', 'Завтрак', '2026-03-11 12:16:19'),
(2, 1, '2026-03-11', 'Обед', '2026-03-11 12:16:19'),
(3, 1, '2026-03-11', 'Ужин', '2026-03-11 12:16:19'),
(4, 2, '2026-03-11', 'Завтрак', '2026-03-11 12:16:19'),
(5, 2, '2026-03-11', 'Обед', '2026-03-11 12:16:19');

-- --------------------------------------------------------

--
-- Структура таблицы `meal_items`
--

CREATE TABLE `meal_items` (
  `id` int(11) NOT NULL,
  `meal_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity_grams` decimal(10,2) NOT NULL COMMENT 'Количество в граммах',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `meal_items`
--

INSERT INTO `meal_items` (`id`, `meal_id`, `product_id`, `quantity_grams`, `created_at`) VALUES
(1, 1, 5, '150.00', '2026-03-11 12:16:19'),
(2, 1, 12, '200.00', '2026-03-11 12:16:19'),
(3, 1, 6, '100.00', '2026-03-11 12:16:19'),
(4, 2, 3, '200.00', '2026-03-11 12:16:19'),
(5, 2, 8, '150.00', '2026-03-11 12:16:19'),
(6, 2, 15, '100.00', '2026-03-11 12:16:19'),
(7, 3, 10, '150.00', '2026-03-11 12:16:19'),
(8, 3, 11, '80.00', '2026-03-11 12:16:19'),
(9, 3, 14, '50.00', '2026-03-11 12:16:19'),
(10, 4, 1, '200.00', '2026-03-11 12:16:19'),
(11, 4, 7, '150.00', '2026-03-11 12:16:19'),
(12, 5, 4, '200.00', '2026-03-11 12:16:19'),
(13, 5, 15, '150.00', '2026-03-11 12:16:19'),
(14, 5, 6, '50.00', '2026-03-11 12:16:19');

-- --------------------------------------------------------

--
-- Структура таблицы `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `name` varchar(250) COLLATE utf8mb4_unicode_ci NOT NULL,
  `calories` decimal(10,2) NOT NULL COMMENT 'ккал на 100г',
  `proteins` decimal(10,2) NOT NULL COMMENT 'белки на 100г',
  `fats` decimal(10,2) NOT NULL COMMENT 'жиры на 100г',
  `carbs` decimal(10,2) NOT NULL COMMENT 'углеводы на 100г',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `products`
--

INSERT INTO `products` (`id`, `name`, `calories`, `proteins`, `fats`, `carbs`, `created_at`) VALUES
(1, 'Яблоко', '52.00', '0.30', '0.20', '14.00', '2026-03-11 12:16:19'),
(2, 'Банан', '96.00', '1.50', '0.20', '22.00', '2026-03-11 12:16:19'),
(3, 'Куриная грудка', '165.00', '31.00', '3.60', '0.00', '2026-03-11 12:16:19'),
(4, 'Гречка отварная', '110.00', '4.20', '1.10', '21.00', '2026-03-11 12:16:19'),
(5, 'Овсянка', '68.00', '2.50', '1.40', '12.00', '2026-03-11 12:16:19'),
(6, 'Яйцо куриное', '157.00', '12.70', '11.50', '0.70', '2026-03-11 12:16:19'),
(7, 'Творог 5%', '145.00', '21.00', '5.00', '3.00', '2026-03-11 12:16:19'),
(8, 'Рис отварной', '130.00', '2.70', '0.30', '28.00', '2026-03-11 12:16:19'),
(9, 'Картофель отварной', '82.00', '2.00', '0.40', '18.00', '2026-03-11 12:16:19'),
(10, 'Лосось', '208.00', '20.00', '13.00', '0.00', '2026-03-11 12:16:19'),
(11, 'Авокадо', '160.00', '2.00', '15.00', '9.00', '2026-03-11 12:16:19'),
(12, 'Молоко 2.5%', '52.00', '2.90', '2.50', '4.80', '2026-03-11 12:16:19'),
(13, 'Хлеб ржаной', '165.00', '6.00', '1.00', '30.00', '2026-03-11 12:16:19'),
(14, 'Сыр российский', '364.00', '23.00', '30.00', '0.00', '2026-03-11 12:16:19'),
(15, 'Огурец', '15.00', '0.80', '0.10', '3.00', '2026-03-11 12:16:19');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(250) COLLATE utf8mb4_unicode_ci NOT NULL,
  `age` int(11) NOT NULL,
  `gender` enum('Male','Female') COLLATE utf8mb4_unicode_ci NOT NULL,
  `weight` decimal(10,2) NOT NULL,
  `height` decimal(10,2) NOT NULL,
  `activity_level` decimal(10,2) NOT NULL COMMENT 'Коэффициент активности',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `goal` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'Maintain' COMMENT 'Цель пользователя: Lose, Maintain, Gain'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `name`, `age`, `gender`, `weight`, `height`, `activity_level`, `created_at`, `goal`) VALUES
(1, 'Иван Петров', 30, 'Male', '75.50', '180.00', '1.55', '2026-03-11 12:16:19', 'Maintain'),
(2, 'Мария Иванова', 28, 'Female', '62.00', '165.00', '1.38', '2026-03-11 12:16:19', 'Maintain');

-- --------------------------------------------------------

--
-- Структура таблицы `user_norms`
--

CREATE TABLE `user_norms` (
  `user_id` int(11) NOT NULL,
  `daily_calories` decimal(10,2) NOT NULL COMMENT 'Дневная норма калорий',
  `protein_goal` decimal(10,2) NOT NULL COMMENT 'Цель по белкам (г)',
  `fat_goal` decimal(10,2) NOT NULL COMMENT 'Цель по жирам (г)',
  `carbs_goal` decimal(10,2) NOT NULL COMMENT 'Цель по углеводам (г)',
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `user_norms`
--

INSERT INTO `user_norms` (`user_id`, `daily_calories`, `protein_goal`, `fat_goal`, `carbs_goal`, `updated_at`) VALUES
(1, '2500.00', '150.00', '70.00', '300.00', '2026-03-11 12:16:19'),
(2, '2000.00', '120.00', '55.00', '250.00', '2026-03-11 12:16:19');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `meals`
--
ALTER TABLE `meals`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idx_user_date` (`user_id`,`meal_date`),
  ADD KEY `idx_meal_date` (`meal_date`),
  ADD KEY `idx_user_date_range` (`user_id`,`meal_date`);

--
-- Индексы таблицы `meal_items`
--
ALTER TABLE `meal_items`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idx_meal` (`meal_id`),
  ADD KEY `idx_meal_items_product` (`product_id`);

--
-- Индексы таблицы `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `unique_product_name` (`name`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `user_norms`
--
ALTER TABLE `user_norms`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `meals`
--
ALTER TABLE `meals`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `meal_items`
--
ALTER TABLE `meal_items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT для таблицы `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `meals`
--
ALTER TABLE `meals`
  ADD CONSTRAINT `meals_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `meal_items`
--
ALTER TABLE `meal_items`
  ADD CONSTRAINT `meal_items_ibfk_1` FOREIGN KEY (`meal_id`) REFERENCES `meals` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `meal_items_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `products` (`id`);

--
-- Ограничения внешнего ключа таблицы `user_norms`
--
ALTER TABLE `user_norms`
  ADD CONSTRAINT `user_norms_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

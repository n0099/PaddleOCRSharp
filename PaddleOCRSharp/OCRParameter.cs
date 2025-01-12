﻿// Copyright (c) 2021 raoyutian Authors. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System.Runtime.InteropServices;


//说明：OCRParameter类的数字能够定义顺序不可随便更改，需要与PaddleOCR中的OCRParameter顺序一致

namespace PaddleOCRSharp
{
    /// <summary>
    /// OCR识别参数
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
	public class OCRParameter
	{

		#region 通用参数
		/// <summary>
		/// 是否使用GPU；默认false
		/// </summary>
		public byte use_gpu { get; set; } = 0;
		/// <summary>
		/// GPU id，使用GPU时有效；默认0;
		/// </summary>
		public int gpu_id { get; set; } = 0;
		/// <summary>
		/// 申请的GPU内存;默认4000
		/// </summary>
		public int gpu_mem { get; set; } = 4000;
		/// <summary>
		/// CPU预测时的线程数，在机器核数充足的情况下，该值越大，预测速度越快；默认10
		/// </summary>
		public int numThread { get; set; } = 10;
		/// <summary>
		/// 是否使用mkldnn库；默认true
		/// </summary>
		public byte Enable_mkldnn { get; set; } = 1;
		#endregion

		#region 前向相关
		/// <summary>
		///是否执行文字检测；默认true 
		/// </summary>
		public byte det { get; set; } = 1;
		/// <summary>
		/// 是否执行文字识别；默认true
		/// </summary>
		public byte rec { get; set; } = 1;
		/// <summary>
		/// 是否执行文字方向分类；默认false
		/// </summary>
		public byte cls { get; set; } = 0;
		#endregion

		#region 检测模型相关

		/// <summary>
		/// 输入图像长宽大于960时，等比例缩放图像，使得图像最长边为960,；默认960
		/// </summary>
		public int MaxSideLen { get; set; } = 960;
		/// <summary>
		/// 用于过滤DB预测的二值化图像，设置为0.-0.3对结果影响不明显；默认0.3
		/// </summary>
		public float BoxThresh { get; set; } = 0.3f;
		/// <summary>
		/// DB后处理过滤box的阈值，如果检测存在漏框情况，可酌情减小；默认0.5
		/// </summary>
		public float BoxScoreThresh { get; set; } = 0.5f;
		/// <summary>
		/// 表示文本框的紧致程度，越小则文本框更靠近文本;默认1.6
		/// </summary>
		public float UnClipRatio { get; set; } = 1.6f;
		/// <summary>
		/// 是否在输出映射上使用膨胀,默认false
		/// </summary>
		public byte use_dilation { get; set; } = 0;
		/// <summary>
		/// 1:使用多边形框计算bbox score，0:使用矩形框计算。矩形框计算速度更快，多边形框对弯曲文本区域计算更准确。
		/// </summary>
		public byte det_db_score_mode { get; set; } = 1;
		/// <summary>
		/// 是否对结果进行可视化，为1时，预测结果会保存在output字段指定的文件夹下和输入图像同名的图像上。默认false
		/// </summary>
		public byte visualize { get; set; } = 0;
		#endregion



		#region 方向分类器相关

		/// <summary>
		/// 是否使用方向分类器,默认false
		/// </summary>
		public byte use_angle_cls { get; set; } = 0;
		/// <summary>
		/// 方向分类器的得分阈值，默认0.9
		/// </summary>
		public float cls_thresh { get; set; } = 0.9f;
		/// <summary>
		/// 方向分类器batchsize，默认1
		/// </summary>
		public int cls_batch_num { get; set; } = 1;
		#endregion


		#region 识别模型相关
		/// <summary>
		/// 识别模型batchsize，默认6
		/// </summary>
		public int rec_batch_num { get; set; } = 6;
		/// <summary>
		/// 识别模型输入图像高度，默认48
		/// </summary>
		public int rec_img_h { get; set; } = 48;
		/// <summary>
		/// 识别模型输入图像宽度，默认320
		/// </summary>
		public int rec_img_w { get; set; } = 320;
		#endregion
		/// <summary>
		/// 是否显示预测结果，默认false
		/// </summary>
		public byte show_img_vis { get; set; } = 0;
	}
}



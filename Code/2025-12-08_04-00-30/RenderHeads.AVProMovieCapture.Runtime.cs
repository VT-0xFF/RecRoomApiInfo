using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RenderHeads.Media.AVProMovieCapture
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Ambisonic Source", 601)]
	public class AmbisonicSource : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private AmbisonicWavWriter _sink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Tooltip("Listener is optional but allows positions to be calculated relative to a transform.  This is useful if the listener is not located at 0,0,0.")]
		[SerializeField]
		private Transform _listener;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Vector3 NSLCHFYACDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private AmbisonicOrder QOCCEHCIHRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private AmbisonicChannelOrder VFWJSSSMQWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private AmbisonicNormalisation OMSNNWLDWZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IntPtr IHXGIATHMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int HLPHJWXKYPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float[] DRVEYLSYZSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Queue<float[]> XPSRJUYHDUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Queue<float[]> KWKCUEIVSGM;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6F10", Offset = "0x8DF5710", VA = "0x188DF6F10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6CB0", Offset = "0x8DF54B0", VA = "0x188DF6CB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8DF63A0", Offset = "0x8DF4BA0", VA = "0x188DF63A0")]
		internal void LIRQLNOTZSE(AmbisonicOrder a, AmbisonicChannelOrder b, AmbisonicNormalisation c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6DF0", Offset = "0x8DF55F0", VA = "0x188DF6DF0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6590", Offset = "0x8DF4D90", VA = "0x188DF6590")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6380", Offset = "0x8DF4B80", VA = "0x188DF6380")]
		private void KVNSBOMRCZY(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6190", Offset = "0x8DF4990", VA = "0x188DF6190")]
		private void GPYHMQPKWFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8DF66F0", Offset = "0x8DF4EF0", VA = "0x188DF66F0")]
		private void OnAudioFilterRead(float[] samples, int channelCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5F50", Offset = "0x8DF4750", VA = "0x188DF5F50")]
		internal void FKODNQSGBDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6340", Offset = "0x8DF4B40", VA = "0x188DF6340")]
		internal int IIRZVETOBKF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7090", Offset = "0x8DF5890", VA = "0x188DF7090")]
		internal void PVMKROKNXZU(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7260", Offset = "0x8DF5A60", VA = "0x188DF7260")]
		public AmbisonicSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Ambisonic WAV Writer", 601)]
	public class AmbisonicWavWriter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private CaptureBase _capture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private AmbisonicOrder _order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private AmbisonicFormat _format;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private string _filename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		[Range(4f, 32f)]
		private int _bufferCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private float[] KBKRKXZVIRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private QKUPCXLAKFC MVGGEVHPNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<AmbisonicSource> PMRQCWHNQLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int YROBMXAWQEE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AmbisonicOrder NXTXWHEURFP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4E00", Offset = "0xAA3600", VA = "0x180AA4E00")]
			get
			{
				return default(AmbisonicOrder);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AmbisonicFormat PQVCEFMFGIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB2E980", Offset = "0xB2D180", VA = "0x180B2E980")]
			get
			{
				return default(AmbisonicFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7C80", Offset = "0x8DF6480", VA = "0x188DF7C80")]
		internal void UQDBWJEGZMP(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7450", Offset = "0x8DF5C50", VA = "0x188DF7450")]
		internal void DNQNBXAKNQW(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7B90", Offset = "0x8DF6390", VA = "0x188DF7B90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7BA0", Offset = "0x8DF63A0", VA = "0x188DF7BA0")]
		private void PRAPNAUHSJH(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7C50", Offset = "0x8DF6450", VA = "0x188DF7C50")]
		private void ROTJRQWJYXK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7530", Offset = "0x8DF5D30", VA = "0x188DF7530")]
		private void GEGVZONESYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7350", Offset = "0x8DF5B50", VA = "0x188DF7350")]
		private void CHRTAMDNVHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7960", Offset = "0x8DF6160", VA = "0x188DF7960")]
		private bool HSDDPQVOECU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8DF79C0", Offset = "0x8DF61C0", VA = "0x188DF79C0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7DC0", Offset = "0x8DF65C0", VA = "0x188DF7DC0")]
		private void UXFYFYZVHOK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7A80", Offset = "0x8DF6280", VA = "0x188DF7A80")]
		internal void NRJCXCCJVWG(float[] a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7980", Offset = "0x8DF6180", VA = "0x188DF7980")]
		private void LFNGWLWKPKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8000", Offset = "0x8DF6800", VA = "0x188DF8000")]
		public AmbisonicWavWriter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AddComponentMenu("AVPro Movie Capture/Audio/AudioSource To WAV", 701)]
	public class AudioSourceToWav : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private string _filename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private QKUPCXLAKFC MVGGEVHPNLL;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8130", Offset = "0x8DF6930", VA = "0x188DF8130")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF80F0", Offset = "0x8DF68F0", VA = "0x188DF80F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF80C0", Offset = "0x8DF68C0", VA = "0x188DF80C0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8290", Offset = "0x8DF6A90", VA = "0x188DF8290")]
		public AudioSourceToWav()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Camera Selector", 300)]
	public class CameraSelector : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum SelectByMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			HighestDepthCamera,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			MainCameraTag,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			EditorSceneView,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			Tag,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			Name,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public enum ScanFrequencyMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Manual,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			Frame
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private SelectByMode _selectBy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private ScanFrequencyMode _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private bool _scanHiddenCameras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private string _tag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Camera[] UNLGIJTCDRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int KCQAGHUZMVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int WPOPYQPJKTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool YJVQHNUPRIG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Camera PEXYIXMHTZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAA8580", Offset = "0xAA6D80", VA = "0x180AA8580")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8DF8BB0", Offset = "0x8DF73B0", VA = "0x188DF8BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public SelectByMode JOPWRFIGNCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAB0800", Offset = "0xAAF000", VA = "0x180AB0800")]
			get
			{
				return default(SelectByMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8DF8C00", Offset = "0x8DF7400", VA = "0x188DF8C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ScanFrequencyMode TAQIPDJLBYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AE0", Offset = "0xAC62E0", VA = "0x180AC7AE0")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8DF8BE0", Offset = "0x8DF73E0", VA = "0x188DF8BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool YOFNIHGTWMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC9BBE0", Offset = "0xC9A3E0", VA = "0x180C9BBE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8DF8BF0", Offset = "0x8DF73F0", VA = "0x188DF8BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string WJPJKKPDLEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8DF8C30", Offset = "0x8DF7430", VA = "0x188DF8C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string SWIIMXFLLKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAA7DA0", Offset = "0xAA65A0", VA = "0x180AA7DA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8DF8C10", Offset = "0x8DF7410", VA = "0x188DF8C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF82E0", Offset = "0x8DF6AE0", VA = "0x188DF82E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF88C0", Offset = "0x8DF70C0", VA = "0x188DF88C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF82E0", Offset = "0x8DF6AE0", VA = "0x188DF82E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF89B0", Offset = "0x8DF71B0", VA = "0x188DF89B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8770", Offset = "0x8DF6F70", VA = "0x188DF8770")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8580", Offset = "0x8DF6D80", VA = "0x188DF8580")]
		private void LAKOJFVQUVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8760", Offset = "0x8DF6F60", VA = "0x188DF8760")]
		private void NYJQTLFAGTZ(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8800", Offset = "0x8DF7000", VA = "0x188DF8800")]
		public bool ScanForCameraChange()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8DF82F0", Offset = "0x8DF6AF0", VA = "0x188DF82F0")]
		private Camera DVCJRFCSHQT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8DF88D0", Offset = "0x8DF70D0", VA = "0x188DF88D0")]
		public void UpdateCameraCache(bool forceScanHiddenCameras = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8660", Offset = "0x8DF6E60", VA = "0x188DF8660")]
		private static Camera NCWYICETEOH(int a, Camera[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8DF89D0", Offset = "0x8DF71D0", VA = "0x188DF89D0")]
		private static Camera YOKAYNRKNPI(int a, Camera[] b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8A60", Offset = "0x8DF7260", VA = "0x188DF8A60")]
		private static Camera ZJQIFZHNJMN(int a, Camera[] b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8B00", Offset = "0x8DF7300", VA = "0x188DF8B00")]
		public CameraSelector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Capture Audio (From AudioClip)", 500)]
	public class CaptureAudioFromAudioClip : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private CaptureBase _capture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private AudioClip _audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private bool _restartAudioClipOnCaptureStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int UWNILSECZOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int ZDTBXXNVFGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int CRGSGPJQMZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int JJDKCZRTXNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float[] ATFUJFXRFSX;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9140", Offset = "0x8DF7940", VA = "0x188DF9140")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9200", Offset = "0x8DF7A00", VA = "0x188DF9200")]
		private void XHJMGXWBJAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8E70", Offset = "0x8DF7670", VA = "0x188DF8E70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9160", Offset = "0x8DF7960", VA = "0x188DF9160")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8C50", Offset = "0x8DF7450", VA = "0x188DF8C50")]
		private float[] NTOXNNRPORC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9220", Offset = "0x8DF7A20", VA = "0x188DF9220")]
		public CaptureAudioFromAudioClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Capture Audio (From AudioListener)", 500)]
	[RequireComponent(typeof(AudioListener))]
	public class CaptureAudioFromAudioListener : UnityAudioCapture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private bool _debugLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private bool _muteAudio;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int DTJYBFDWTRS = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float[] ZWRYTMZYRZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float[] GGMORVWVAHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int HMPETPSKODM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private GCHandle UUDIPXDBYKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int UNOSNFCJFNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int WZXMXDBVZFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object FRZNXCSXCJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool KKPIDEIMBVY;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float[] VDPSBGBFOKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int JADBZTPPLTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xACF250", Offset = "0xACDA50", VA = "0x180ACF250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IntPtr CFDYUZVMBNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8DF9CA0", Offset = "0x8DF84A0", VA = "0x188DF9CA0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override int EPTLFHYMKTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x13AC460", Offset = "0x13AAC60", VA = "0x1813AC460", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int XAEVFDILGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8DF9CB0", Offset = "0x8DF84B0", VA = "0x188DF9CB0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override int WXIJEZWUNOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD11100", Offset = "0xD0F900", VA = "0x180D11100", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9590", Offset = "0x8DF7D90", VA = "0x188DF9590", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD19C20", Offset = "0xD18420", VA = "0x180D19C20", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9B20", Offset = "0x8DF8320", VA = "0x188DF9B20", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9580", Offset = "0x8DF7D80", VA = "0x188DF9580", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9A70", Offset = "0x8DF8270", VA = "0x188DF9A70", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9980", Offset = "0x8DF8180", VA = "0x188DF9980", Slot = "13")]
		public override IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9230", Offset = "0x8DF7A30", VA = "0x188DF9230", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF92D0", Offset = "0x8DF7AD0", VA = "0x188DF92D0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9BF0", Offset = "0x8DF83F0", VA = "0x188DF9BF0")]
		public CaptureAudioFromAudioListener()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Capture Audio (From AudioRenderer)", 500)]
	public class CaptureAudioFromAudioRenderer : UnityAudioCapture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private CaptureBase _capture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int CZQWEOTXSOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool GTOTFLJDHFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private NativeArray<float> BUYUYZLQYNG;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CaptureBase NSRZAWNBBBV
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA1370", Offset = "0xA9FB70", VA = "0x180AA1370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override int XAEVFDILGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8DF9CB0", Offset = "0x8DF84B0", VA = "0x188DF9CB0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override int WXIJEZWUNOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAA4E00", Offset = "0xAA3600", VA = "0x180AA4E00", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9E60", Offset = "0x8DF8660", VA = "0x188DF9E60", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9D10", Offset = "0x8DF8510", VA = "0x188DF9D10")]
		private NativeArray<float> KTCPCMYDZRY(int a)
		{
			return default(NativeArray<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		private void PRXFWLOHKNW(NativeArray<float> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9E80", Offset = "0x8DF8680", VA = "0x188DF9E80", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9F90", Offset = "0x8DF8790", VA = "0x188DF9F90", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9CC0", Offset = "0x8DF84C0", VA = "0x188DF9CC0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9FF0", Offset = "0x8DF87F0", VA = "0x188DF9FF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xABC060", Offset = "0xABA860", VA = "0x180ABC060")]
		public CaptureAudioFromAudioRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CaptureAudioFromMultipleSources : UnityAudioCapture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private bool _debugLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private bool _muteAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private List<OnAudioFilterReadForwarder> _onAudioFilterReadForwarders;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private const int DTJYBFDWTRS = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float[] ZWRYTMZYRZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float[] GGMORVWVAHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int KKKJZDXFNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int XRTHMEREFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GCHandle UUDIPXDBYKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int UNOSNFCJFNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool GKXXHOGUYKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int FJIYCVMWWGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int WZXMXDBVZFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private object FRZNXCSXCJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool EUKBWLEEVHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool KKPIDEIMBVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int ZMRQYFATCSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int OXYMVOGDIRW;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public List<OnAudioFilterReadForwarder> HRXBKBKHAFG
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAA1380", Offset = "0xA9FB80", VA = "0x180AA1380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HXPYRYGGPZU
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAB1020", Offset = "0xAAF820", VA = "0x180AB1020")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAB0FF0", Offset = "0xAAF7F0", VA = "0x180AB0FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float[] VDPSBGBFOKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA7DA0", Offset = "0xAA65A0", VA = "0x180AA7DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int JADBZTPPLTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xABD670", Offset = "0xABBE70", VA = "0x180ABD670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IntPtr CFDYUZVMBNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8DFB3E0", Offset = "0x8DF9BE0", VA = "0x188DFB3E0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override int EPTLFHYMKTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1240FA0", Offset = "0x123F7A0", VA = "0x181240FA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override int XAEVFDILGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8DF9CB0", Offset = "0x8DF84B0", VA = "0x188DF9CB0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override int WXIJEZWUNOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xBDFD20", Offset = "0xBDE520", VA = "0x180BDFD20", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8DFADE0", Offset = "0x8DF95E0", VA = "0x188DFADE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA600", Offset = "0x8DF8E00", VA = "0x188DFA600", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8DFAC00", Offset = "0x8DF9400", VA = "0x188DFAC00", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8DFAFB0", Offset = "0x8DF97B0", VA = "0x188DFAFB0", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA5F0", Offset = "0x8DF8DF0", VA = "0x188DFA5F0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8DFAB40", Offset = "0x8DF9340", VA = "0x188DFAB40", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA9F0", Offset = "0x8DF91F0", VA = "0x188DFA9F0", Slot = "13")]
		public override IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA0E0", Offset = "0x8DF88E0", VA = "0x188DFA0E0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA180", Offset = "0x8DF8980", VA = "0x188DFA180")]
		public void OnAudioFilterReadCombiner(float[] data, int channels, bool isMicrophone, int sampleRate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB250", Offset = "0x8DF9A50", VA = "0x188DFB250")]
		private float[] XFWARKUVSHS(float[] a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB330", Offset = "0x8DF9B30", VA = "0x188DFB330")]
		public CaptureAudioFromMultipleSources()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Capture Audio (From Wwise)", 500)]
	public class CaptureAudioFromWwise : UnityAudioCapture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private CaptureBase _capture;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CaptureBase NSRZAWNBBBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAA1370", Offset = "0xA9FB70", VA = "0x180AA1370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override int XAEVFDILGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override int WXIJEZWUNOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB3F0", Offset = "0x8DF9BF0", VA = "0x188DFB3F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xABC060", Offset = "0xABA860", VA = "0x180ABC060")]
		public CaptureAudioFromWwise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Camera", 1)]
	public class CaptureFromCamera : CaptureBase
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class PTPJHPGCGIZ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private object YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public CaptureFromCamera VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object FHSTBNTIQTK
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public PTPJHPGCGIZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A690", Offset = "0x8E08E90", VA = "0x188E0A690", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8E0AAA0", Offset = "0x8E092A0", VA = "0x188E0AAA0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class DQRHCRMQEBI : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private object YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public CaptureFromCamera VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private object FHSTBNTIQTK
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public DQRHCRMQEBI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A230", Offset = "0x8E08A30", VA = "0x188E0A230", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A2D0", Offset = "0x8E08AD0", VA = "0x188E0A2D0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private CameraSelector _cameraSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private Camera _lastCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private Camera[] _contribCameras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private bool _useContributingCameras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private RenderTexture VVGHZSGCJYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private RenderTexture JKVDASWPKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private IntPtr LMESNAJHLWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Texture CLIBKXEHJCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Texture YRBVDZLMXJF;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public CameraSelector VXEGKCOCIBH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xC98190", Offset = "0xC96990", VA = "0x180C98190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xE4E340", Offset = "0xE4CB40", VA = "0x180E4E340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool XRWOGYOLCDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xC98300", Offset = "0xC96B00", VA = "0x180C98300")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xC98480", Offset = "0xC96C80", VA = "0x180C98480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8E03490", Offset = "0x8E01C90", VA = "0x188E03490")]
		public void SetCamera(Camera topCamera, bool useContributingCameras = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8E03440", Offset = "0x8E01C40", VA = "0x188E03440")]
		public void SetCamera(Camera topCamera, Camera[] contributingCameras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8E03360", Offset = "0x8E01B60", VA = "0x188E03360")]
		private bool RONDYDEYHSR(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8E02720", Offset = "0x8E00F20", VA = "0x188E02720")]
		private bool PQCBWNVHJQW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8E024C0", Offset = "0x8E00CC0", VA = "0x188E024C0")]
		private bool IBLUMSIXMFJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8E036A0", Offset = "0x8E01EA0", VA = "0x188E036A0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8E03870", Offset = "0x8E02070", VA = "0x188E03870")]
		[IteratorStateMachine(typeof(DQRHCRMQEBI))]
		private IEnumerator VZILFCXUHEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8E02450", Offset = "0x8E00C50", VA = "0x188E02450")]
		[IteratorStateMachine(typeof(PTPJHPGCGIZ))]
		public IEnumerator Capture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8E024F0", Offset = "0x8E00CF0", VA = "0x188E024F0")]
		private bool IYBGEKSQWFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8E02080", Offset = "0x8E00880", VA = "0x188E02080")]
		private void CULMSEJICAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8E035B0", Offset = "0x8E01DB0", VA = "0x188E035B0", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8E02780", Offset = "0x8E00F80", VA = "0x188E02780")]
		private void PWXXBUMBDWM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E1AD40", Offset = "0x1E19540", VA = "0x181E1AD40", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8E02950", Offset = "0x8E01150", VA = "0x188E02950", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8E02630", Offset = "0x8E00E30", VA = "0x188E02630", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8E038E0", Offset = "0x8E020E0", VA = "0x188E038E0")]
		public CaptureFromCamera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8E02070", Offset = "0x8E00870", VA = "0x188E02070")]
		[CompilerGenerated]
		[DebuggerHidden]
		private void APRODGIGFSB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Camera 360 (VR)", 100)]
	public class CaptureFromCamera360 : CaptureBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private enum CubemapRenderMethod
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			Manual,
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			Unity,
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			Unity2018
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class IVOSRKOWRUB : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private object YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public CaptureFromCamera360 VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private object FHSTBNTIQTK
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public IVOSRKOWRUB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A3C0", Offset = "0x8E08BC0", VA = "0x188E0A3C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A430", Offset = "0x8E08C30", VA = "0x188E0A430", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private CameraSelector _cameraSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private CubemapResolution _cubemapResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private CubemapDepth _cubemapDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private bool _supportGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private bool _supportCameraRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x272")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		private bool _onlyLeftRightRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x273")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Render 180 degree equirectangular instead of 360 degrees")]
		[SerializeField]
		private bool _render180Degrees;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private StereoPacking _stereoRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Makes assumption that 1 Unity unit is 1m")]
		[SerializeField]
		private float _ipd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Percentage cube faces are overdrawn each edge then blended to alleviate screen space FX seams")]
		[SerializeField]
		private float _blendOverlapPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private RenderTexture WIDDVKXKRYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private RenderTexture[] RKYVWOYQHSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private Material MWVRBMJISIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Material XFCGMLLIUIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private RenderTexture DBRHUBIJCXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private RenderTexture ZURMMJYJSLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private IntPtr LMESNAJHLWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int GLHNQGIOOMS;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public CameraSelector VXEGKCOCIBH
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xC98190", Offset = "0xC96990", VA = "0x180C98190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xE4E340", Offset = "0xE4CB40", VA = "0x180E4E340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public CubemapResolution AFISFYOVPGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1781DB0", Offset = "0x17805B0", VA = "0x181781DB0")]
			get
			{
				return default(CubemapResolution);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8E02020", Offset = "0x8E00820", VA = "0x188E02020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CubemapDepth OXCLVPXKKST
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8E01FD0", Offset = "0x8E007D0", VA = "0x188E01FD0")]
			get
			{
				return default(CubemapDepth);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8E02010", Offset = "0x8E00810", VA = "0x188E02010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool CUYFQAPXDMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xC98300", Offset = "0xC96B00", VA = "0x180C98300")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xC98480", Offset = "0xC96C80", VA = "0x180C98480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool PNRHWBGKMDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xC982F0", Offset = "0xC96AF0", VA = "0x180C982F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xC98470", Offset = "0xC96C70", VA = "0x180C98470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool GMSBEDSLNIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8E01FF0", Offset = "0x8E007F0", VA = "0x188E01FF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8E02040", Offset = "0x8E00840", VA = "0x188E02040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool XJMCZQSVSCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8E02000", Offset = "0x8E00800", VA = "0x188E02000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8E02050", Offset = "0x8E00850", VA = "0x188E02050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public StereoPacking EORMPBUFKSB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x24BDB30", Offset = "0x24BC330", VA = "0x1824BDB30")]
			get
			{
				return default(StereoPacking);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8E02060", Offset = "0x8E00860", VA = "0x188E02060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float EHELCZWLILE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8E01FE0", Offset = "0x8E007E0", VA = "0x188E01FE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8E02030", Offset = "0x8E00830", VA = "0x188E02030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8E01F20", Offset = "0x8E00720", VA = "0x188E01F20")]
		public CaptureFromCamera360()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8E01E10", Offset = "0x8E00610", VA = "0x188E01E10")]
		private CubemapRenderMethod YZAIEOVFWTV()
		{
			return default(CubemapRenderMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xE49900", Offset = "0xE48100", VA = "0x180E49900")]
		public void SetCamera(Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8E01820", Offset = "0x8E00020", VA = "0x188E01820", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8E01990", Offset = "0x8E00190", VA = "0x188E01990")]
		[IteratorStateMachine(typeof(IVOSRKOWRUB))]
		private IEnumerator VZILFCXUHEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8DFE310", Offset = "0x8DFCB10", VA = "0x188DFE310")]
		private void NSRZAWNBBBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8DFE180", Offset = "0x8DFC980", VA = "0x188DFE180")]
		private static void KKZKBSVBHIZ(RenderTexture a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8E01A00", Offset = "0x8E00200", VA = "0x188E01A00")]
		private void YHNFULLNHMP(RenderTexture a, RenderTexture b, bool c, Quaternion d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8DFDBE0", Offset = "0x8DFC3E0", VA = "0x188DFDBE0")]
		private void CULMSEJICAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8DFE640", Offset = "0x8DFCE40", VA = "0x188DFE640")]
		private void OKJVHTOQGPU(Camera a, RenderTexture b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8E01E40", Offset = "0x8E00640", VA = "0x188E01E40")]
		private void ZGMSJZKAXTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8E002B0", Offset = "0x8DFEAB0", VA = "0x188E002B0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8DFE140", Offset = "0x8DFC940", VA = "0x188DFE140", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8E01640", Offset = "0x8DFFE40", VA = "0x188E01640", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8E00000", Offset = "0x8DFE800", VA = "0x188E00000", Slot = "6")]
		public override void OnDestroy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Camera 360 Stereo ODS (VR)", 101)]
	public class CaptureFromCamera360ODS : CaptureBase
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			[SerializeField]
			public Camera camera;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			[SerializeField]
			public CameraSelector cameraSelector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			[SerializeField]
			[Tooltip("Render 180 degree equirectangular instead of 360 degrees.  Also faster rendering")]
			public bool render180Degrees;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			[SerializeField]
			[Tooltip("Makes assumption that 1 Unity unit is 1m")]
			public float ipd;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			[SerializeField]
			[Tooltip("Higher value meant less slices to render, but can affect quality.")]
			public int pixelSliceSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			[SerializeField]
			[Range(1f, 31f)]
			[Tooltip("May need to be increased to work with some post image effects. Value is in pixels.")]
			public int paddingSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			[SerializeField]
			public CameraClearFlags cameraClearMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			[SerializeField]
			public Color cameraClearColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			[SerializeField]
			public Behaviour[] cameraImageEffects;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8E0AAE0", Offset = "0x8E092E0", VA = "0x188E0AAE0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class DQWNZYGNNMR : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private object YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public CaptureFromCamera360ODS VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private object FHSTBNTIQTK
			{
				[Cpp2IlInjected.Token(Token = "0x60000D8")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public DQWNZYGNNMR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A310", Offset = "0x8E08B10", VA = "0x188E0A310", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A380", Offset = "0x8E08B80", VA = "0x188E0A380", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private Settings _settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int TQHEBXROKNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int CWOYUAKXKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Transform KVPKYKJEYMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Camera CMNQUOQJARX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Camera CHSPPDRRFZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Camera MKDJNZHOUDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Camera WCYIZKQOJRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private RenderTexture AVDHBHHYIHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IntPtr LMESNAJHLWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Material OJANFXNBMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int ADMVZKFISLC;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Settings LIRQLNOTZSE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xC98190", Offset = "0xC96990", VA = "0x180C98190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DFDAF0", Offset = "0x8DFC2F0", VA = "0x188DFDAF0")]
		public CaptureFromCamera360ODS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8DFCF40", Offset = "0x8DFB740", VA = "0x188DFCF40")]
		public void SetCamera(Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8DFCF70", Offset = "0x8DFB770", VA = "0x188DFCF70", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB450", Offset = "0x8DF9C50", VA = "0x188DFB450")]
		private Camera BLFHLLBISCQ(Camera a, string b, float c, float d, int e, int f, float g, float h, int i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD810", Offset = "0x8DFC010", VA = "0x188DFD810", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD9A0", Offset = "0x8DFC1A0", VA = "0x188DFD9A0")]
		[IteratorStateMachine(typeof(DQWNZYGNNMR))]
		private IEnumerator VZILFCXUHEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBAE0", Offset = "0x8DFA2E0", VA = "0x188DFBAE0")]
		private void NSRZAWNBBBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8DFDA10", Offset = "0x8DFC210", VA = "0x188DFDA10")]
		private void ZGMSJZKAXTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD0A0", Offset = "0x8DFB8A0", VA = "0x188DFD0A0")]
		private void UPGICRGRPZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBAA0", Offset = "0x8DFA2A0", VA = "0x188DFBAA0", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBFF0", Offset = "0x8DFA7F0", VA = "0x188DFBFF0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD740", Offset = "0x8DFBF40", VA = "0x188DFD740")]
		private static void UTXCSHQYIMM(Camera a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBDB0", Offset = "0x8DFA5B0", VA = "0x188DFBDB0", Slot = "6")]
		public override void OnDestroy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Screen", 0)]
	public class CaptureFromScreen : CaptureBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class KSDNQKWIFNB : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private object YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public CaptureFromScreen VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			private object FHSTBNTIQTK
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public KSDNQKWIFNB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A470", Offset = "0x8E08C70", VA = "0x188E0A470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A5A0", Offset = "0x8E08DA0", VA = "0x188E0A5A0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private bool _captureMouseCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private MouseCursor _mouseCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private IntPtr LMESNAJHLWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private RenderTexture JKVDASWPKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private CommandBuffer FLJQWWNPCYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator ZSMQWHUBSPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private bool OCASHFJZJSL;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool ENIBFXDATQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x8E04440", Offset = "0x8E02C40", VA = "0x188E04440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x8E04450", Offset = "0x8E02C50", VA = "0x188E04450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public MouseCursor YWKCBEZYUNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xC98260", Offset = "0xC96A60", VA = "0x180C98260")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xE49900", Offset = "0xE48100", VA = "0x180E49900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8E03A10", Offset = "0x8E02210", VA = "0x188E03A10", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8E03E10", Offset = "0x8E02610", VA = "0x188E03E10")]
		private void SJNQCSXZMKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8E03940", Offset = "0x8E02140", VA = "0x188E03940")]
		private void GESNZHMRZRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8E04230", Offset = "0x8E02A30", VA = "0x188E04230", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8E04370", Offset = "0x8E02B70", VA = "0x188E04370")]
		[IteratorStateMachine(typeof(KSDNQKWIFNB))]
		private IEnumerator VZILFCXUHEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8E04340", Offset = "0x8E02B40", VA = "0x188E04340", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8E043E0", Offset = "0x8E02BE0", VA = "0x188E043E0")]
		public CaptureFromScreen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Texture", 3)]
	public class CaptureFromTexture : CaptureBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class KSIUNRQFOYK : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private object YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public CaptureFromTexture VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private object FHSTBNTIQTK
			{
				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public KSIUNRQFOYK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A5E0", Offset = "0x8E08DE0", VA = "0x188E0A5E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A650", Offset = "0x8E08E50", VA = "0x188E0A650", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("If enabled the method the encoder will only process frames each time UpdateSourceTexture() is called. This is useful if the texture is updating at a different rate compared to Unity, eg for webcam capture.")]
		[SerializeField]
		private bool _manualUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Texture RYJTKSFIAGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private RenderTexture JKVDASWPKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		protected IntPtr LMESNAJHLWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private bool FZFYKBYBNRW;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool UDBLLCNBYLS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8E04440", Offset = "0x8E02C40", VA = "0x188E04440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8E04450", Offset = "0x8E02C50", VA = "0x188E04450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xE49900", Offset = "0xE48100", VA = "0x180E49900")]
		public void SetSourceTexture(Texture texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8E05070", Offset = "0x8E03870", VA = "0x188E05070")]
		private bool RONDYDEYHSR(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8E05340", Offset = "0x8E03B40", VA = "0x188E05340")]
		public void UpdateSourceTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8E05150", Offset = "0x8E03950", VA = "0x188E05150")]
		private bool SBAZPQVOQTF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8E04460", Offset = "0x8E02C60", VA = "0x188E04460")]
		private bool AHCJFYZILCN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8E052A0", Offset = "0x8E03AA0", VA = "0x188E052A0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8E05350", Offset = "0x8E03B50", VA = "0x188E05350")]
		[IteratorStateMachine(typeof(KSIUNRQFOYK))]
		private IEnumerator VZILFCXUHEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8E04570", Offset = "0x8E02D70", VA = "0x188E04570")]
		private void NSRZAWNBBBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8E04AA0", Offset = "0x8E032A0", VA = "0x188E04AA0")]
		private void PWXXBUMBDWM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8E053C0", Offset = "0x8E03BC0", VA = "0x188E053C0")]
		private void ZGMSJZKAXTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8E04480", Offset = "0x8E02C80", VA = "0x188E04480", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8E04C30", Offset = "0x8E03430", VA = "0x188E04C30", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8E051C0", Offset = "0x8E039C0", VA = "0x188E051C0", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8E05470", Offset = "0x8E03C70", VA = "0x188E05470")]
		public CaptureFromTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("AVPro Movie Capture/Capture From WebCamTexture", 3)]
	public class CaptureFromWebCamTexture : CaptureFromTexture
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8E054D0", Offset = "0x8E03CD0", VA = "0x188E054D0", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8E05470", Offset = "0x8E03C70", VA = "0x188E05470")]
		public CaptureFromWebCamTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[DisallowMultipleComponent]
	[AddComponentMenu("AVPro Movie Capture/Utils/Capture GUI", 300)]
	public class CaptureGUI : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private enum Section
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			VideoCodecs,
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			AudioCodecs,
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			AudioInputDevices,
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			ImageCodecs
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private AudioListener UCUQPMFRBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private CaptureBase _movieCapture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private bool _showUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private bool _whenRecordingAutoHideUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private GUISkin _guiSkin;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static readonly string[] WYFAISIVJLZ;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly float[] UQYHVUXJUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private Section ZNQHYTZXTYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private string[] XNIRUFRAVLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string[] UNHOBYESHSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private bool[] GQGESCAWOZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private bool[] SNEAVPTKHUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private string[] TTBDHSJDUEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private string[] UIHJLJBBZEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private string[] HFZDZSHOKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int EQTXEWBWHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private GUIStyle IMBKBKFQIIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private int YKQLCVODOYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Vector2 SHQYFRXEKHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Vector2 TYJXJGMJYZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private Vector2 NGNPDITNEQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Vector2 RRZWUYQPECZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private long OOOIQSTVATV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float QZBMNDVYJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float UGFMLQAYUIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private uint SUCYYQGCLPV;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public CaptureBase YIBHRAYJGDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAA1380", Offset = "0xA9FB80", VA = "0x180AA1380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool NHRVDYSOGFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xC8B640", Offset = "0xC89E40", VA = "0x180C8B640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCD61F0", Offset = "0xCD49F0", VA = "0x180CD61F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool GAZNRJXNHOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xB02810", Offset = "0xB01010", VA = "0x180B02810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xB03320", Offset = "0xB01B20", VA = "0x180B03320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8E08BE0", Offset = "0x8E073E0", VA = "0x188E08BE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8E08C50", Offset = "0x8E07450", VA = "0x188E08C50")]
		private void TMRHTRQFXIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8E08690", Offset = "0x8E06E90", VA = "0x188E08690")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8E066A0", Offset = "0x8E04EA0", VA = "0x188E066A0")]
		private void AKZBMMWSDCZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8E05540", Offset = "0x8E03D40", VA = "0x188E05540")]
		private void ADIWYNPHQRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8E09770", Offset = "0x8E07F70", VA = "0x188E09770")]
		private void YQULGPUKJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8E09660", Offset = "0x8E07E60", VA = "0x188E09660")]
		private void XVKLZQNBTJK(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8E08540", Offset = "0x8E06D40", VA = "0x188E08540")]
		private void GEGVZONESYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8E084B0", Offset = "0x8E06CB0", VA = "0x188E084B0")]
		private void CHRTAMDNVHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8E096F0", Offset = "0x8E07EF0", VA = "0x188E096F0")]
		private void YHMPBUQXYJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8E08B60", Offset = "0x8E07360", VA = "0x188E08B60")]
		private void SMVRBSVYGAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8E08610", Offset = "0x8E06E10", VA = "0x188E08610")]
		private void JOCDKNAYHLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8E09470", Offset = "0x8E07C70", VA = "0x188E09470")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8E09E60", Offset = "0x8E08660", VA = "0x188E09E60")]
		public CaptureGUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Motion Blur", 301)]
	public class MotionBlur : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		private RenderTextureFormat _format;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[SerializeField]
		private int _numSamples;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private RenderTexture RKPSNCGCFRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private RenderTexture OIPTZSDSARB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Material MZZGQPEMJWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Material MWJJPQPRZHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int ANMXDIQLGSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int CZDYZIMPEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int OGDQTGFOINI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private bool GVSBYJSVNIY;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int KYXZHUKGCLQ;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static int EAUOOZDVDMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		public float _bias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private float BDVPDYYXFIK;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool XGRSXDQLXMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x1D6DBE0", Offset = "0x1D6C3E0", VA = "0x181D6DBE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x1D6DC90", Offset = "0x1D6C490", VA = "0x181D6DC90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int SMPFEJRTRGA
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AE0", Offset = "0xAC62E0", VA = "0x180AC7AE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8E1F450", Offset = "0x8E1DC50", VA = "0x188E1F450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int JBLQFBYBNDN
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xD11100", Offset = "0xD0F900", VA = "0x180D11100")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public RenderTexture MOOOTEVOLWA
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8E1EA80", Offset = "0x8E1D280", VA = "0x188E1EA80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F3A0", Offset = "0x8E1DBA0", VA = "0x188E1F3A0")]
		public void SetTargetSize(int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F3C0", Offset = "0x8E1DBC0", VA = "0x188E1F3C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F030", Offset = "0x8E1D830", VA = "0x188E1F030")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8E1EB10", Offset = "0x8E1D310", VA = "0x188E1EB10")]
		private void LIRQLNOTZSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F3D0", Offset = "0x8E1DBD0", VA = "0x188E1F3D0")]
		private void UZPODDTUACT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8E1EE50", Offset = "0x8E1D650", VA = "0x188E1EE50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F090", Offset = "0x8E1D890", VA = "0x188E1F090")]
		public void OnNumSamplesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8381E90", Offset = "0x8380690", VA = "0x188381E90")]
		private static float UYDVAHCVFMF(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F2C0", Offset = "0x8E1DAC0", VA = "0x188E1F2C0")]
		private void PRWHJZDPFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E960", Offset = "0x8E1D160", VA = "0x188E1E960")]
		public void Accumulate(Texture src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F150", Offset = "0x8E1D950", VA = "0x188E1F150")]
		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F430", Offset = "0x8E1DC30", VA = "0x188E1F430")]
		public MotionBlur()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Render Mouse Cursor", 302)]
	public class MouseCursor : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private Texture2D _texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		private Vector2 _hotspotOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		[Range(1f, 16f)]
		private int _sizeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		private int _depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private GUIContent STKJQLITHUV;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F660", Offset = "0x8E1DE60", VA = "0x188E1F660")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F5B0", Offset = "0x8E1DDB0", VA = "0x188E1F5B0")]
		public void SetTexture(Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F460", Offset = "0x8E1DC60", VA = "0x188E1F460")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F720", Offset = "0x8E1DF20", VA = "0x188E1F720")]
		public MouseCursor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class OnAudioFilterReadForwarder : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Action<float[], int, bool, int> DKKALAJQEPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAA1370", Offset = "0xA9FB70", VA = "0x180AA1370")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8E20210", Offset = "0x8E1EA10", VA = "0x188E20210")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA9F980", Offset = "0xA9E180", VA = "0x180A9F980")]
		public OnAudioFilterReadForwarder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Timeline Controller", 300)]
	public class TimelineController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum ScanFrequencyMode
		{
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			Frame
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		internal class FAERWTENXKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private PlayableDirector LXRCOUXZVDS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private DirectorUpdateMode GROICKLUEHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private bool QPXKXWEQKMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private bool HFRJOHOSRWZ;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
			internal FAERWTENXKL(PlayableDirector a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8E1D9B0", Offset = "0x8E1C1B0", VA = "0x188E1D9B0")]
			internal bool DBMJBCNJRLN(PlayableDirector a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8E1DA10", Offset = "0x8E1C210", VA = "0x188E1DA10")]
			internal void GEGVZONESYV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8E1D8E0", Offset = "0x8E1C0E0", VA = "0x188E1D8E0")]
			internal void CHRTAMDNVHB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private ScanFrequencyMode _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<FAERWTENXKL> FLLEMKATBTS;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public ScanFrequencyMode TAQIPDJLBYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xAB0800", Offset = "0xAAF000", VA = "0x180AB0800")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8E22720", Offset = "0x8E20F20", VA = "0x188E22720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8E21DC0", Offset = "0x8E205C0", VA = "0x188E21DC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8E21DC0", Offset = "0x8E205C0", VA = "0x188E21DC0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8E221D0", Offset = "0x8E209D0", VA = "0x188E221D0")]
		internal void JCRDCTVOKJR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8E21FB0", Offset = "0x8E207B0", VA = "0x188E21FB0")]
		internal void GEGVZONESYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8E21DD0", Offset = "0x8E205D0", VA = "0x188E21DD0")]
		internal void CHRTAMDNVHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8E22370", Offset = "0x8E20B70", VA = "0x188E22370")]
		public void ScanForPlayableDirectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8E222D0", Offset = "0x8E20AD0", VA = "0x188E222D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8E221E0", Offset = "0x8E209E0", VA = "0x188E221E0")]
		private void LAKOJFVQUVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8E222C0", Offset = "0x8E20AC0", VA = "0x188E222C0")]
		private void NYJQTLFAGTZ(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8E226A0", Offset = "0x8E20EA0", VA = "0x188E226A0")]
		public TimelineController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public abstract class UnityAudioCapture : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public virtual int EPTLFHYMKTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public abstract int XAEVFDILGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public abstract int WXIJEZWUNOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void PrepareCapture();

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void StartCapture();

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void StopCapture();

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void PauseCapture();

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void ResumeCapture();

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void FlushBuffer();

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8E22BA0", Offset = "0x8E213A0", VA = "0x188E22BA0", Slot = "13")]
		public virtual IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8E22A10", Offset = "0x8E21210", VA = "0x188E22A10")]
		public static int GetUnityAudioChannelCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8E22B30", Offset = "0x8E21330", VA = "0x188E22B30")]
		private static int HTXEWVCYWRB(AudioSpeakerMode a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA9F980", Offset = "0xA9E180", VA = "0x180A9F980")]
		protected UnityAudioCapture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[AddComponentMenu("AVPro Movie Capture/Utils/VideoPlayer Controller", 300)]
	public class VideoPlayerController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public enum ScanFrequencyMode
		{
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			Frame
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		internal class OXFOPBVEKGQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private VideoPlayer QGWVMCVLNHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private bool HFRJOHOSRWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private bool QPXKXWEQKMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private bool KHCUTBHTETJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private double FLGUPONNYPQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private float ZATBNAXSSWD;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
			internal OXFOPBVEKGQ(VideoPlayer a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x8E1F810", Offset = "0x8E1E010", VA = "0x188E1F810")]
			internal bool DBMJBCNJRLN(VideoPlayer a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x8E1F970", Offset = "0x8E1E170", VA = "0x188E1F970")]
			internal void GEGVZONESYV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8E1FE60", Offset = "0x8E1E660", VA = "0x188E1FE60")]
			internal bool QTEPOXJRWYC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8E1FA80", Offset = "0x8E1E280", VA = "0x188E1FA80")]
			internal void LHDDQBNWUOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8E1FDC0", Offset = "0x8E1E5C0", VA = "0x188E1FDC0")]
			private void MGBHJBAQBJA(VideoPlayer a, long b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x8E1F870", Offset = "0x8E1E070", VA = "0x188E1F870")]
			private void FOJNFSXHZYP(VideoPlayer a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x8E1F9F0", Offset = "0x8E1E1F0", VA = "0x188E1F9F0")]
			internal void HVBZHWNQGCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x8E1FEA0", Offset = "0x8E1E6A0", VA = "0x188E1FEA0")]
			internal bool Update(float deltaTime)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x8E1F780", Offset = "0x8E1DF80", VA = "0x188E1F780")]
			internal void CHRTAMDNVHB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class KLZHACCQFNT : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private object YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public VideoPlayerController VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			private object FHSTBNTIQTK
			{
				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public KLZHACCQFNT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x8E1DCC0", Offset = "0x8E1C4C0", VA = "0x188E1DCC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8E1DE00", Offset = "0x8E1C600", VA = "0x188E1DE00", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private ScanFrequencyMode _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<OXFOPBVEKGQ> NMJDCXYVEHW;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public ScanFrequencyMode TAQIPDJLBYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAB0800", Offset = "0xAAF000", VA = "0x180AB0800")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8E24AD0", Offset = "0x8E232D0", VA = "0x188E24AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8E23D40", Offset = "0x8E22540", VA = "0x188E23D40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8E23D40", Offset = "0x8E22540", VA = "0x188E23D40")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8E24200", Offset = "0x8E22A00", VA = "0x188E24200")]
		internal void JCRDCTVOKJR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8E23EE0", Offset = "0x8E226E0", VA = "0x188E23EE0")]
		public bool CanContinue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8E24640", Offset = "0x8E22E40", VA = "0x188E24640")]
		[IteratorStateMachine(typeof(KLZHACCQFNT))]
		internal IEnumerator PLGCYHGCLFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8E24050", Offset = "0x8E22850", VA = "0x188E24050")]
		internal void GEGVZONESYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8E23D50", Offset = "0x8E22550", VA = "0x188E23D50")]
		internal void CHRTAMDNVHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8E246B0", Offset = "0x8E22EB0", VA = "0x188E246B0")]
		public void ScanForVideoPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8E245A0", Offset = "0x8E22DA0", VA = "0x188E245A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8E244B0", Offset = "0x8E22CB0", VA = "0x188E244B0")]
		private void LAKOJFVQUVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8E24590", Offset = "0x8E22D90", VA = "0x188E24590")]
		private void NYJQTLFAGTZ(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8E24A50", Offset = "0x8E23250", VA = "0x188E24A50")]
		public VideoPlayerController()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8E24340", Offset = "0x8E22B40", VA = "0x188E24340")]
		[CompilerGenerated]
		private bool JIWWVWRFZDG()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public enum AmbisonicOrder
	{
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		First = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Second,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Third
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum AmbisonicFormat
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		FuMa,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		ACN_SN3D
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum AmbisonicChannelOrder
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		FuMa,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		ACN
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum AmbisonicNormalisation
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		FuMa,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		SN3D
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class CLTPEDTEBJF
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum Platform
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			Unknown = -2,
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			Current = -1,
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			First = 0,
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			Windows = 0,
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			macOS = 1,
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			iOS = 2,
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			Android = 3,
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			Count = 4
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum PixelFormat
		{
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			RGBA32,
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			BGRA32,
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			YCbCr422_YUY2,
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			YCbCr422_UYVY,
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			YCbCr422_HDYC
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public enum PluginEvent
		{
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			CaptureFrameBuffer,
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			FreeResources,
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			Setup
		}

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static string[] LEAEBDAQGKA;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly string[] KALHYHAUHRP;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly string[] EJDSJKPVGJI;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly string[] YBBMMFFIJSF;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly string[] ZWXZOMKZHCO;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly string[] VVKBOGBADNJ;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly string[] EAZPBLFDNFO;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static IntPtr RRMKMSYFSLW;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private static IntPtr QNBOAREFWRQ;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private static IntPtr CJXCTXJQGER
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8E0DA30", Offset = "0x8E0C230", VA = "0x188E0DA30")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		private static IntPtr VWKUJWOFHED
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8E0DFC0", Offset = "0x8E0C7C0", VA = "0x188E0DFC0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B960", Offset = "0x8E0A160", VA = "0x188E0B960")]
		public static extern IntPtr AddAmbisonicSourceInstance(int maxCoefficients);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D9B0", Offset = "0x8E0C1B0", VA = "0x188E0D9B0")]
		public static extern void RemoveAmbisonicSourceInstance(IntPtr instance);

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DD60", Offset = "0x8E0C560", VA = "0x188E0DD60")]
		public static extern void UpdateAmbisonicWeights(IntPtr instance, float azimuth, float elevation, AmbisonicOrder order, AmbisonicChannelOrder channelOrder, float[] normalisationWeights);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C2F0", Offset = "0x8E0AAF0", VA = "0x188E0C2F0")]
		public static extern void EncodeMonoToAmbisonic(IntPtr instance, float[] inSamples, int inSamplesOffset, int inFrameCount, int inChannelCount, float[] outSamples, int outSamplesOffset, int outSamplesLength, AmbisonicOrder order);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E0C0", Offset = "0x8E0C8C0", VA = "0x188E0E0C0")]
		public static string XEHMYBMIWFB(PixelFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D560", Offset = "0x8E0BD60", VA = "0x188E0D560")]
		public static void MBSORVJCSXX(PluginEvent a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CEF0", Offset = "0x8E0B6F0", VA = "0x188E0CEF0")]
		private static extern IntPtr GetRenderEventFunc();

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CC90", Offset = "0x8E0B490", VA = "0x188E0CC90")]
		private static extern IntPtr GetFreeResourcesEventFunc();

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D2F0", Offset = "0x8E0BAF0", VA = "0x188E0D2F0")]
		public static extern bool Init();

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BF30", Offset = "0x8E0A730", VA = "0x188E0BF30")]
		public static extern void Deinit();

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BE60", Offset = "0x8E0A660", VA = "0x188E0BE60")]
		public static string DFTVIUPHIVV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E190", Offset = "0x8E0C990", VA = "0x188E0E190")]
		public static bool XNSRBCPRZWP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CF60", Offset = "0x8E0B760", VA = "0x188E0CF60")]
		public static extern int GetVideoCodecCount();

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D3E0", Offset = "0x8E0BBE0", VA = "0x188E0D3E0")]
		public static extern bool IsConfigureVideoCodecSupported(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CFD0", Offset = "0x8E0B7D0", VA = "0x188E0CFD0")]
		public static extern MediaApi GetVideoCodecMediaApi(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BA60", Offset = "0x8E0A260", VA = "0x188E0BA60")]
		public static extern void ConfigureVideoCodec(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DE40", Offset = "0x8E0C640", VA = "0x188E0DE40")]
		public static string WJADOGGVMGR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C5F0", Offset = "0x8E0ADF0", VA = "0x188E0C5F0")]
		public static extern int GetAudioCodecCount();

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D360", Offset = "0x8E0BB60", VA = "0x188E0D360")]
		public static extern bool IsConfigureAudioCodecSupported(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C660", Offset = "0x8E0AE60", VA = "0x188E0C660")]
		public static extern MediaApi GetAudioCodecMediaApi(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B9E0", Offset = "0x8E0A1E0", VA = "0x188E0B9E0")]
		public static extern void ConfigureAudioCodec(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BFA0", Offset = "0x8E0A7A0", VA = "0x188E0BFA0")]
		public static string EIOXWRSYOGW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C7B0", Offset = "0x8E0AFB0", VA = "0x188E0C7B0")]
		public static extern int GetAudioInputDeviceCount();

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C470", Offset = "0x8E0AC70", VA = "0x188E0C470")]
		public static string GIABIJBFMUO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C820", Offset = "0x8E0B020", VA = "0x188E0C820")]
		public static extern MediaApi GetAudioInputDeviceMediaApi(int index);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D120", Offset = "0x8E0B920", VA = "0x188E0D120")]
		public static string[] IJTZETUWLVG(int a, int b = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BD00", Offset = "0x8E0A500", VA = "0x188E0BD00")]
		public static extern int CreateRecorderVideo(string filename, uint width, uint height, float frameRate, int format, bool isRealTime, bool isTopDown, int videoCodecIndex, AudioCaptureSource audioSource, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool forceGpuFlush, VideoEncoderHints hints);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BAE0", Offset = "0x8E0A2E0", VA = "0x188E0BAE0")]
		public static extern int CreateRecorderImages(string filename, uint width, uint height, float frameRate, int format, bool isRealTime, bool isTopDown, int imageFormatType, bool forceGpuFlush, int startFrame, ImageEncoderHints hints);

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BC10", Offset = "0x8E0A410", VA = "0x188E0BC10")]
		public static extern int CreateRecorderPipe(string filename, uint width, uint height, float frameRate, int format, bool isTopDown, int transparencyMode, bool forceGpuFlush);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DC50", Offset = "0x8E0C450", VA = "0x188E0DC50")]
		public static extern bool Start(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D4E0", Offset = "0x8E0BCE0", VA = "0x188E0D4E0")]
		public static extern bool IsNewFrameDue(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DB30", Offset = "0x8E0C330", VA = "0x188E0DB30")]
		public static extern int SetEncodedFrameLimit(int handle, uint encodedFrameLimit);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C260", Offset = "0x8E0AA60", VA = "0x188E0C260")]
		public static extern void EncodeFrame(int handle, IntPtr data);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C120", Offset = "0x8E0A920", VA = "0x188E0C120")]
		public static extern void EncodeAudio(int handle, IntPtr data, uint length);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C1C0", Offset = "0x8E0A9C0", VA = "0x188E0C1C0")]
		public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength);

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D930", Offset = "0x8E0C130", VA = "0x188E0D930")]
		public static extern void Pause(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DCD0", Offset = "0x8E0C4D0", VA = "0x188E0DCD0")]
		public static extern void Stop(int handle, bool skipPendingFrames);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D460", Offset = "0x8E0BC60", VA = "0x188E0D460")]
		public static extern bool IsFileWritingComplete(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0")]
		public static bool KEGJQAXCBQO(int a, StringBuilder b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DBC0", Offset = "0x8E0C3C0", VA = "0x188E0DBC0")]
		public static extern void SetTexturePointer(int handle, IntPtr texture);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C3F0", Offset = "0x8E0ABF0", VA = "0x188E0C3F0")]
		public static extern void FreeRecorder(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CD80", Offset = "0x8E0B580", VA = "0x188E0CD80")]
		public static extern uint GetNumDroppedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CD00", Offset = "0x8E0B500", VA = "0x188E0CD00")]
		public static extern uint GetNumDroppedEncoderFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CE00", Offset = "0x8E0B600", VA = "0x188E0CE00")]
		public static extern uint GetNumEncodedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CC10", Offset = "0x8E0B410", VA = "0x188E0CC10")]
		public static extern float GetEncodedSeconds(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C970", Offset = "0x8E0B170", VA = "0x188E0C970")]
		public static extern uint GetBufferSize(int handle);

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C9F0", Offset = "0x8E0B1F0", VA = "0x188E0C9F0")]
		public static extern uint GetBufferedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CE80", Offset = "0x8E0B680", VA = "0x188E0CE80")]
		private static extern IntPtr GetPluginVersion();

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D050", Offset = "0x8E0B850", VA = "0x188E0D050")]
		private static extern bool GetVideoCodecName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C6E0", Offset = "0x8E0AEE0", VA = "0x188E0C6E0")]
		private static extern bool GetAudioCodecName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C8A0", Offset = "0x8E0B0A0", VA = "0x188E0C8A0")]
		private static extern bool GetAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CA70", Offset = "0x8E0B270", VA = "0x188E0CA70")]
		private static extern bool GetContainerFileExtensions(int videoCodecIndex, int audioCodecIndex, StringBuilder extensions, int extensionsBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CB50", Offset = "0x8E0B350", VA = "0x188E0CB50")]
		private static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, [Out] ulong lpFreeBytesAvailable, [Out] ulong lpTotalNumberOfBytes, [Out] ulong lpTotalNumberOfFreeBytes);

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D7D0", Offset = "0x8E0BFD0", VA = "0x188E0D7D0")]
		public static bool MWHUTALBCYB(string a, [Out] ulong b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class LZPYGPMTVJG
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		internal struct PolarCoord
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public float azimuth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public float elevation;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8E20370", Offset = "0x8E1EB70", VA = "0x188E20370")]
			public void TEAYJJRIFOJ(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static float[] BKMFECEIBSG;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static float[] FTYNRVBYKMT;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E1F0", Offset = "0x8E1C9F0", VA = "0x188E1E1F0")]
		public static float[] HUCHNKEMOBW(AmbisonicNormalisation a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E280", Offset = "0x8E1CA80", VA = "0x188E1E280")]
		public static int KEAFPXPDCMZ(AmbisonicOrder a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E270", Offset = "0x8E1CA70", VA = "0x188E1E270")]
		public static AmbisonicChannelOrder VLAUKGFFHTC(AmbisonicFormat a)
		{
			return default(AmbisonicChannelOrder);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E270", Offset = "0x8E1CA70", VA = "0x188E1E270")]
		public static AmbisonicNormalisation IHLFAQVEEAP(AmbisonicFormat a)
		{
			return default(AmbisonicNormalisation);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E8E0", Offset = "0x8E1D0E0", VA = "0x188E1E8E0")]
		static LZPYGPMTVJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8E1DE40", Offset = "0x8E1C640", VA = "0x188E1DE40")]
		private static float[] BDRJIRRIVEV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E170", Offset = "0x8E1C970", VA = "0x188E1E170")]
		private static int GDUNUCSFBKZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E110", Offset = "0x8E1C910", VA = "0x188E1E110")]
		private static int GDETCIKMZCY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E8C0", Offset = "0x8E1D0C0", VA = "0x188E1E8C0")]
		private static int ZAEQPRTQIGG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E6D0", Offset = "0x8E1CED0", VA = "0x188E1E6D0")]
		private static float VYLWJUGOEVX(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E560", Offset = "0x8E1CD60", VA = "0x188E1E560")]
		private static float VYLWJUGOEVX(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E2B0", Offset = "0x8E1CAB0", VA = "0x188E1E2B0")]
		private static float[] UFSNPRKXRGI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class CMOMMWCOHKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private uint NNUEYQXZMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private uint BDUNJWTESHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private uint HOFFVLNZFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private float MDMCOZMBEVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private uint ZEHUSFAUPNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private uint IEZDRIJFEUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private ulong FTVIHFHLEPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private int SNWZDPSJXWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private AudioCaptureSource HRMFDPIPMZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int SKKIXFOQTIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private int CZQWEOTXSOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private float WHFMGGWYMFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private int DZVRWKEAYDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private int ANMXDIQLGSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private float SUOTXRFCZVO;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float YBJTBACWQBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xAF05A0", Offset = "0xAEEDA0", VA = "0x180AF05A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public uint DPUZVETWAZB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xA9E110", Offset = "0xA9C910", VA = "0x180A9E110")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xAA9530", Offset = "0xAA7D30", VA = "0x180AA9530")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public uint REBCMOMFYON
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xB447A0", Offset = "0xB42FA0", VA = "0x180B447A0")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xB446E0", Offset = "0xB42EE0", VA = "0x180B446E0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public uint CPLEDIYNHDV
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xAA3180", Offset = "0xAA1980", VA = "0x180AA3180")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xAA4DF0", Offset = "0xAA35F0", VA = "0x180AA4DF0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float NQMUSCMPLBO
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xAEF760", Offset = "0xAEDF60", VA = "0x180AEF760")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1128B90", Offset = "0x1127390", VA = "0x181128B90")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		internal uint RNDCCADHAOR
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAFA210", Offset = "0xAF8A10", VA = "0x180AFA210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		internal uint TGNGGRYPNPK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xC13A70", Offset = "0xC12270", VA = "0x180C13A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public AudioCaptureSource MMAKCIJHMFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xAEE380", Offset = "0xAECB80", VA = "0x180AEE380")]
			get
			{
				return default(AudioCaptureSource);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1402510", Offset = "0x1400D10", VA = "0x181402510")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public int XCYFRMPUIJI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xACF250", Offset = "0xACDA50", VA = "0x180ACF250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xB350E0", Offset = "0xB338E0", VA = "0x180B350E0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int YHKQFUFXCRS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xADF840", Offset = "0xADE040", VA = "0x180ADF840")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xADEEC0", Offset = "0xADD6C0", VA = "0x180ADEEC0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E830", Offset = "0x8E0D030", VA = "0x188E0E830")]
		internal void RBBNDWLPHYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E7E0", Offset = "0x8E0CFE0", VA = "0x188E0E7E0")]
		internal void OTPPRFELUPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x768D5D0", Offset = "0x768BDD0", VA = "0x18768D5D0")]
		public CMOMMWCOHKG()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Pack = 1, Size = 80)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class VideoEncoderHints
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public enum ColourSpace
		{
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			Unknown = -1,
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			Gamma,
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			Linear
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[Tooltip("Average number of bits per second for the resulting video. Zero uses the codec defaults.")]
		public uint averageBitrate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[Tooltip("Maximum number of bits per second for the resulting video. Zero uses the codec defaults.")]
		public uint maximumBitrate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[Range(0f, 1f)]
		public float quality;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[Tooltip("How often a keyframe is inserted.  Zero uses the codec defaults.")]
		public uint keyframeInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[Tooltip("Move the 'moov' atom in the video file from the end to the start of the file to make streaming start fast.  Also known as 'Fast Start' in some encoders")]
		public bool allowFastStartStreamingPostProcess;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[Tooltip("Hints to the encoder to use the alpha channel for transparency if possible")]
		public bool supportTransparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public bool useHardwareEncoding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[Tooltip("Enable Constant Quality")]
		public bool enableConstantQuality;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[Tooltip("Enable fragmented writing support for QuickTime (mov, mp4) files")]
		public bool enableFragmentedWriting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public bool androidNoCaptureRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool iOSSaveCaptureWhenAppLosesFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public bool padding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[Tooltip("Inject atoms to define stereo video mode")]
		public NoneAutoCustom injectStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[Tooltip("Inject atoms to define stereo video mode")]
		public StereoPacking stereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[Tooltip("Inject atoms to define spherical video layout")]
		public NoneAutoCustom injectSphericalVideoLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[Tooltip("Inject atoms to define spherical video layout")]
		public SphericalVideoLayout sphericalVideoLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[Tooltip("The interval at which to write movie fragments in seconds")]
		[Range(0f, 300f)]
		public double movieFragmentInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ColourSpace colourSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int sourceWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int sourceHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[Tooltip("Transparency mode")]
		public Transparency transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public AndroidVulkanPreTransform androidVulkanPreTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[Tooltip("Use Limited range for maximum compatibility")]
		public ColourRange colourRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[Tooltip("Options for controlling the presentation timestamp for each frame that is captured")]
		public RealtimeFramePresentationTimestampOptions realtimeFramePresentationTimestampOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public OrientationMetadata orientationMetadata;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8E23CD0", Offset = "0x8E224D0", VA = "0x188E23CD0")]
		public VideoEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8E23C70", Offset = "0x8E22470", VA = "0x188E23C70")]
		public void PFQQYWJNOID()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Pack = 1, Size = 25)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ImageEncoderHints
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public enum ColourSpace
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			Unknown = -1,
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			Gamma,
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			Linear
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[Range(0f, 1f)]
		public float quality;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[Tooltip("Hints to the encoder to use the alpha channel for transparency if possible")]
		public bool supportTransparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public ColourSpace colourSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int sourceWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int sourceHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[Tooltip("Transparency mode")]
		public Transparency transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AndroidVulkanPreTransform androidVulkanPreTransform;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8E1DC80", Offset = "0x8E1C480", VA = "0x188E1DC80")]
		public ImageEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8E1DC60", Offset = "0x8E1C460", VA = "0x188E1DC60")]
		public void PFQQYWJNOID()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class EncoderHints
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public VideoEncoderHints videoHints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public ImageEncoderHints imageHints;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8E1D7D0", Offset = "0x8E1BFD0", VA = "0x188E1D7D0")]
		public EncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8E1D6C0", Offset = "0x8E1BEC0", VA = "0x188E1D6C0")]
		public void PFQQYWJNOID()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class CaptureBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public enum Resolution
		{
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			POW2_8192x8192,
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			POW2_8192x4096,
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			POW2_4096x4096,
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			POW2_4096x2048,
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			POW2_2048x4096,
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			UHD_3840x2160,
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			UHD_3840x2048,
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			UHD_3840x1920,
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			UHD_2560x1440,
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			POW2_2048x2048,
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			POW2_2048x1024,
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			HD_1920x1080,
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			HD_1280x720,
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			SD_1024x768,
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			SD_800x600,
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			SD_800x450,
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			SD_640x480,
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			SD_640x360,
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			SD_320x240,
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			Original,
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			Custom
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public enum CubemapDepth
		{
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			Depth_24 = 24,
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			Depth_16 = 16,
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			Depth_Zero = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public enum CubemapResolution
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			POW2_8192 = 8192,
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			POW2_4096 = 4096,
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			POW2_2048 = 2048,
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			POW2_1024 = 1024,
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			POW2_512 = 512,
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			POW2_256 = 256
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public enum DownScale
		{
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			Original = 1,
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			Half = 2,
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			Quarter = 4,
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			Eighth = 8,
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			Sixteenth = 16,
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			Custom = 100
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public enum OutputPath
		{
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			RelativeToProject = 0,
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			RelativeToPersistentData = 1,
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			Absolute = 2,
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			RelativeToDesktop = 3,
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			RelativeToPictures = 4,
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			RelativeToVideos = 5,
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			PhotoLibrary = 6,
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			RelativeToTemporaryCachePath = 7,
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			[Obsolete("Use RelativeToPersistentData")]
			RelativeToPeristentData = 1
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public enum FrameUpdateMode
		{
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			Automatic,
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private const string MIDUZJGDFAB = "https://www.renderheads.com/content/docs/AVProMovieCapture/articles/download.html#editions";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private EncoderHints _encoderHintsWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private EncoderHints _encoderHintsMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private EncoderHints _encoderHintsIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private EncoderHints _encoderHintsAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private KeyCode _captureKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private bool _isRealTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private bool _persistAcrossSceneLoads;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private StartTriggerMode _startTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private StartDelayMode _startDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float _startDelaySeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private StopMode _stopMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private int _stopFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private float _stopSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private bool _pauseCaptureOnAppPause;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly string[] DefaultVideoCodecPriorityWindows;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public static readonly string[] DefaultVideoCodecPriorityMacOS;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public static readonly string[] DefaultVideoCodecPriorityAndroid;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public static readonly string[] DefaultAudioCodecPriorityWindows;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly string[] DefaultAudioCodecPriorityMacOS;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] DefaultAudioCodecPriorityIOS;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] DefaultAudioCodecPriorityAndroid;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] DefaultAudioCaptureDevicePriorityWindow;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] DefaultAudioCaptureDevicePriorityMacOS;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public static readonly string[] DefaultAudioCaptureDevicePriorityIOS;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public static readonly string[] DefaultAudioCaptureDevicePriorityAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private string[] _videoCodecPriorityWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private string[] _videoCodecPriorityMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private string[] _videoCodecPriorityAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private string[] _audioCodecPriorityWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private string[] _audioCodecPriorityMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private string[] _audioCodecPriorityAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private float _frameRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[Tooltip("Timelapse scale makes the frame capture run at a fraction of the target frame rate.  Default value is 1")]
		[SerializeField]
		private int _timelapseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[Tooltip("Manual update mode requires user to call FrameUpdate() each time a frame is ready")]
		[SerializeField]
		private FrameUpdateMode _frameUpdateMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		private DownScale _downScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		private Vector2 _maxVideoSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		[Range(-1f, 128f)]
		private int _forceVideoCodecIndexWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		[Range(-1f, 128f)]
		private int _forceVideoCodecIndexMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		[Range(0f, 128f)]
		private int _forceVideoCodecIndexIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		[Range(0f, 128f)]
		private int _forceVideoCodecIndexAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		[Range(-1f, 128f)]
		private int _forceAudioCodecIndexWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[Range(-1f, 128f)]
		private int _forceAudioCodecIndexMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		[Range(0f, 128f)]
		private int _forceAudioCodecIndexIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		[Range(0f, 128f)]
		private int _forceAudioCodecIndexAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		private bool _flipVertically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[Tooltip("Flushing the GPU during each capture results in less latency, but can slow down rendering performance for complex scenes.")]
		[SerializeField]
		private bool _forceGpuFlush;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD2")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[Tooltip("This option can help issues where skinning is used, or other animation/rendering effects that only complete later in the frame.")]
		[SerializeField]
		protected bool _useWaitForEndOfFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD3")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[Tooltip("Update the media gallery")]
		[SerializeField]
		protected bool _androidUpdateMediaGallery;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[Tooltip("Portrait captures may be rotated 90° to better utilise the encoder, check this to disable the rotation at the risk of not being able to capture the full vertical resolution.")]
		[SerializeField]
		private bool _androidNoCaptureRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private bool _iOSSaveCaptureWhenAppLosesFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[Tooltip("Log the start and stop of the capture.  Disable this for less garbage generation.")]
		[SerializeField]
		private bool _logCaptureStartStop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private AudioCaptureSource _audioCaptureSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private UnityAudioCapture _unityAudioCapture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		[Range(0f, 32f)]
		private int _forceAudioInputDeviceIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		[Range(8000f, 96000f)]
		private int _manualAudioSampleRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		[Range(1f, 8f)]
		private int _manualAudioChannelCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		protected OutputTarget _outputTarget;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public const OutputPath DefaultOutputFolderType = OutputPath.RelativeToProject;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private const string FTAMMIDRGDU = "Captures";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private OutputPath _outputFolderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private string _outputFolderPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private string _filenamePrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private bool _appendFilenameTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private bool _allowManualFileExtension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private string _filenameExtension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private string _namedPipePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private bool _writeOrientationMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private int _imageSequenceStartFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		[Range(2f, 12f)]
		private int _imageSequenceZeroDigits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private ImageSequenceFormat _imageSequenceFormatWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private ImageSequenceFormat _imageSequenceFormatMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private ImageSequenceFormat _imageSequenceFormatIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private ImageSequenceFormat _imageSequenceFormatAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		protected Resolution _renderResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		protected Vector2 _renderSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		protected int _renderAntiAliasing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		protected bool _useMotionBlur;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		[Range(0f, 64f)]
		protected int _motionBlurSamples;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		protected Camera[] _motionBlurCameras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		protected MotionBlur _motionBlur;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private bool _allowVSyncDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x171")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		protected bool _supportTextureRecreate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private int _minimumDiskSpaceMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private TimelineController _timelineController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private VideoPlayerController _videoPlayerController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		protected Texture2D WGQENJXOBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		protected int DRZYUWZRXQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		protected int ZMODYBUPOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		protected int ZMMKSWCHREC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		protected int CZDYZIMPEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		protected int OGDQTGFOINI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		protected bool GKXXHOGUYKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A5")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		protected bool KKPIDEIMBVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		protected string QOZMPBPEHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		protected string GIYINAZVWWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		protected FileInfo UUESXVKKDGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		protected CLTPEDTEBJF.PixelFormat WUXNYLPWDFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private Codec CCYKPDNDHFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Codec MDBNOXRZEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private GDHOCVPKMLL OPTHXPGIYXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int KQTTUZTLVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private float TFTBTTJVZNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		protected bool VIZXDYMJJDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E9")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		protected bool PHLYQSVOEXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EA")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool NMIBJRUJOPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EB")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool DMFSDDWWMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private float KYFVPLJOUMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private float GATZPAQRWIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private float YCMVIMCGARI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected YieldInstruction BBJIFSWSCWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private long JXFFYNJEJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		protected Transparency VEXBMNSFIFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected RenderTexture BRDYSGONMMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected Material TKYZWWKPYLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float ATYHXDRYSGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private bool CBDYPKMVWKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private Action<AZAKQZVMAMJ> RWXQJRWTVFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Action<AZAKQZVMAMJ> EYBZCLPKQTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private List<AZAKQZVMAMJ> JLUFCJEBUSV;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static HashSet<string> IYPQAEGYOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private UnityEvent UIWAZABDXEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private UnityEvent CNFEFVZVEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private CMOMMWCOHKG QFDBHFUFZOX;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private static bool EPPRVWTLJJD;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static bool FFMLFSJJWKT;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public OutputTarget FVTTQRJEMWD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x14EB550", Offset = "0x14E9D50", VA = "0x1814EB550")]
			get
			{
				return default(OutputTarget);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x14EB0D0", Offset = "0x14E98D0", VA = "0x1814EB0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public OutputPath CWORZHHWABE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xDF4DE0", Offset = "0xDF35E0", VA = "0x180DF4DE0")]
			get
			{
				return default(OutputPath);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x192FDA0", Offset = "0x192E5A0", VA = "0x18192FDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string WZACIHSUAND
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xC235C0", Offset = "0xC21DC0", VA = "0x180C235C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xC23D70", Offset = "0xC22570", VA = "0x180C23D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string ICVOCBHEEMK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xC982E0", Offset = "0xC96AE0", VA = "0x180C982E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x144C5B0", Offset = "0x144ADB0", VA = "0x18144C5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool CSRCIRQGLZA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xCAB410", Offset = "0xCA9C10", VA = "0x180CAB410")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2171D60", Offset = "0x2170560", VA = "0x182171D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool WIDKRRTZFKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xDD2670", Offset = "0xDD0E70", VA = "0x180DD2670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1DA5FE0", Offset = "0x1DA47E0", VA = "0x181DA5FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string GIZSKUNSMST
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xC982A0", Offset = "0xC96AA0", VA = "0x180C982A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1427D60", Offset = "0x1426560", VA = "0x181427D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string LSECWFODGHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xBED0A0", Offset = "0xBEB8A0", VA = "0x180BED0A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xBEFF50", Offset = "0xBEE750", VA = "0x180BEFF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool NWOSRGISBKV
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xBA32C0", Offset = "0xBA1AC0", VA = "0x180BA32C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xBA2FF0", Offset = "0xBA17F0", VA = "0x180BA2FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int MPSJCMSCFGU
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB430", Offset = "0x1EF9C30", VA = "0x181EFB430")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2057B60", Offset = "0x2056360", VA = "0x182057B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int PGFPSDPWNXT
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xFECC00", Offset = "0xFEB400", VA = "0x180FECC00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8E17D80", Offset = "0x8E16580", VA = "0x188E17D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool QRXXXNDDUHD
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x18DA350", Offset = "0x18D8B50", VA = "0x1818DA350")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x8E17E60", Offset = "0x8E16660", VA = "0x188E17E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int AFJPAIDFEUH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xD6BB30", Offset = "0xD6A330", VA = "0x180D6BB30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8E17DF0", Offset = "0x8E165F0", VA = "0x188E17DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Camera[] YCQOZNKFJVS
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xC983F0", Offset = "0xC96BF0", VA = "0x180C983F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x12A9900", Offset = "0x12A8100", VA = "0x1812A9900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MotionBlur VRQANGQBHLS
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xD6C270", Offset = "0xD6AA70", VA = "0x180D6C270")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xBEE630", Offset = "0xBECE30", VA = "0x180BEE630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Transparency FEGEMGTVWDP
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x25B58D0", Offset = "0x25B40D0", VA = "0x1825B58D0")]
			get
			{
				return default(Transparency);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static HashSet<string> OVKVRMIJGSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8E17C00", Offset = "0x8E16400", VA = "0x188E17C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string XBWEEKGAHAS
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xC98420", Offset = "0xC96C20", VA = "0x180C98420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public UnityEvent XHJMGXWBJAU
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xC98230", Offset = "0xC96A30", VA = "0x180C98230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public UnityEvent EGIZQEOOXTK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xC98270", Offset = "0xC96A70", VA = "0x180C98270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Action<AZAKQZVMAMJ> WHVRUHRMBHK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xC98290", Offset = "0xC96A90", VA = "0x180C98290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x13572E0", Offset = "0x1355AE0", VA = "0x1813572E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Action<AZAKQZVMAMJ> AFUVWODWFQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xC98250", Offset = "0xC96A50", VA = "0x180C98250")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1366700", Offset = "0x1364F00", VA = "0x181366700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Resolution RKFMCVEVWFM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB440", Offset = "0x1EF9C40", VA = "0x181EFB440")]
			get
			{
				return default(Resolution);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8E17D30", Offset = "0x8E16530", VA = "0x188E17D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector2 WJOKFBMGJXT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x8E17C50", Offset = "0x8E16450", VA = "0x188E17C50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x22CCED0", Offset = "0x22CB6D0", VA = "0x1822CCED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int UJZFWWWXGPS
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x18DA390", Offset = "0x18D8B90", VA = "0x1818DA390")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x21D6ED0", Offset = "0x21D56D0", VA = "0x1821D6ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool ZPHPVSDAJDI
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x16D8370", Offset = "0x16D6B70", VA = "0x1816D8370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x16D8380", Offset = "0x16D6B80", VA = "0x1816D8380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool ZRBNTMWAIEN
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x241A3C0", Offset = "0x2418BC0", VA = "0x18241A3C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x241A540", Offset = "0x2418D40", VA = "0x18241A540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public AudioCaptureSource MMAKCIJHMFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xB18CC0", Offset = "0xB174C0", VA = "0x180B18CC0")]
			get
			{
				return default(AudioCaptureSource);
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x16BB340", Offset = "0x16B9B40", VA = "0x1816BB340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int AHRSLEIXOEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1C95590", Offset = "0x1C93D90", VA = "0x181C95590")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x23CFEE0", Offset = "0x23CE6E0", VA = "0x1823CFEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int WHJDMIZQJJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0xFECD90", Offset = "0xFEB590", VA = "0x180FECD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x14EAC70", Offset = "0x14E9470", VA = "0x1814EAC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public UnityAudioCapture CNTFCEEAPLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xC98330", Offset = "0xC96B30", VA = "0x180C98330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xE217C0", Offset = "0xE1FFC0", VA = "0x180E217C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int KBBZUVVUIUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xE20DD0", Offset = "0xE1F5D0", VA = "0x180E20DD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x8E17D40", Offset = "0x8E16540", VA = "0x188E17D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float GFPVYBWTTTI
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x13A3E60", Offset = "0x13A2660", VA = "0x1813A3E60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x8E17D50", Offset = "0x8E16550", VA = "0x188E17D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public StartTriggerMode QWSNERFVITB
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xD11100", Offset = "0xD0F900", VA = "0x180D11100")]
			get
			{
				return default(StartTriggerMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xD11110", Offset = "0xD0F910", VA = "0x180D11110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public StartDelayMode JXUQGWUYUGI
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x13AC460", Offset = "0x13AAC60", VA = "0x1813AC460")]
			get
			{
				return default(StartDelayMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1993370", Offset = "0x1991B70", VA = "0x181993370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float ETPJAMIBPOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xAEEB10", Offset = "0xAED310", VA = "0x180AEEB10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x8E17E20", Offset = "0x8E16620", VA = "0x188E17E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public StopMode SPVEPKKVOQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x105E360", Offset = "0x105CB60", VA = "0x18105E360")]
			get
			{
				return default(StopMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1EA3F30", Offset = "0x1EA2730", VA = "0x181EA3F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int OJTSVAZSAVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xC21B60", Offset = "0xC20360", VA = "0x180C21B60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x8E17E30", Offset = "0x8E16630", VA = "0x188E17E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public float YGPQNYARJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xFECD80", Offset = "0xFEB580", VA = "0x180FECD80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x8E17E40", Offset = "0x8E16640", VA = "0x188E17E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool PWJGCYMRQGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xAA7D60", Offset = "0xAA6560", VA = "0x180AA7D60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xAA8660", Offset = "0xAA6E60", VA = "0x180AA8660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public CMOMMWCOHKG CMOMMWCOHKG
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xC98240", Offset = "0xC96A40", VA = "0x180C98240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string[] WDJEGTIAGBT
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9C980", VA = "0x180A9E180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x8E17EB0", Offset = "0x8E166B0", VA = "0x188E17EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string[] ZLVNGBGXOCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xA9E130", Offset = "0xA9C930", VA = "0x180A9E130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8E17E80", Offset = "0x8E16680", VA = "0x188E17E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string[] BRHYSXPXOCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xAA32D0", Offset = "0xAA1AD0", VA = "0x180AA32D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x8E17D00", Offset = "0x8E16500", VA = "0x188E17D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string[] MIWBPGIUJSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xAA38F0", Offset = "0xAA20F0", VA = "0x180AA38F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x8E17CD0", Offset = "0x8E164D0", VA = "0x188E17CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int GMQAYNCYOXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2B6AF70", Offset = "0x2B69770", VA = "0x182B6AF70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x759FF80", Offset = "0x759E780", VA = "0x18759FF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public FrameUpdateMode QTYGYVJNXOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xAA3210", Offset = "0xAA1A10", VA = "0x180AA3210")]
			get
			{
				return default(FrameUpdateMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xAA3900", Offset = "0xAA2100", VA = "0x180AA3900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public DownScale XQWOROSZUAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xAF7EB0", Offset = "0xAF66B0", VA = "0x180AF7EB0")]
			get
			{
				return default(DownScale);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xC75640", Offset = "0xC73E40", VA = "0x180C75640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 KBVVCYJNDSO
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x27E08F0", Offset = "0x27DF0F0", VA = "0x1827E08F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x750F320", Offset = "0x750DB20", VA = "0x18750F320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool BHSBUPKHZIF
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xB431E0", Offset = "0xB419E0", VA = "0x180B431E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xB43340", Offset = "0xB41B40", VA = "0x180B43340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool EBIARBQOGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x800F6F0", Offset = "0x800DEF0", VA = "0x18800F6F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x8E17E70", Offset = "0x8E16670", VA = "0x188E17E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool OKKUAYCITWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x27EBA40", Offset = "0x27EA240", VA = "0x1827EBA40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x27EBF70", Offset = "0x27EA770", VA = "0x1827EBF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool BVFGSURLBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xD23CF0", Offset = "0xD224F0", VA = "0x180D23CF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xD23D00", Offset = "0xD22500", VA = "0x180D23D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool IERBSQTMXTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x8E17CC0", Offset = "0x8E164C0", VA = "0x188E17CC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x8E17E50", Offset = "0x8E16650", VA = "0x188E17E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public TimelineController NODOFDMODDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xBF04D0", Offset = "0xBEECD0", VA = "0x180BF04D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xBF05A0", Offset = "0xBEEDA0", VA = "0x180BF05A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public VideoPlayerController BEVJFFHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xC98170", Offset = "0xC96970", VA = "0x180C98170")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xDAC8F0", Offset = "0xDAB0F0", VA = "0x180DAC8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Codec BWTXBDUFHCB
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xC98430", Offset = "0xC96C30", VA = "0x180C98430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Codec FMDROWRIPJI
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xC98220", Offset = "0xC96A20", VA = "0x180C98220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public GDHOCVPKMLL HHYXNIKIGEK
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xC98210", Offset = "0xC96A10", VA = "0x180C98210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int KIODATIJGGA
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x1248110", Offset = "0x1246910", VA = "0x181248110")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x12479F0", Offset = "0x12461F0", VA = "0x1812479F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int KPXKNFYMHDD
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xC197E0", Offset = "0xC17FE0", VA = "0x180C197E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x1FCD6E0", Offset = "0x1FCBEE0", VA = "0x181FCD6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public ImageSequenceFormat RVGPYKHXFMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1595D60", Offset = "0x1594560", VA = "0x181595D60")]
			get
			{
				return default(ImageSequenceFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x2057BE0", Offset = "0x20563E0", VA = "0x182057BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public static string QNDNBNGTUEM
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x8E17C70", Offset = "0x8E16470", VA = "0x188E17C70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8E17DB0", Offset = "0x8E165B0", VA = "0x188E17DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0")]
		protected static CLTPEDTEBJF.Platform IWFYVJEVISN()
		{
			return default(CLTPEDTEBJF.Platform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8E107D0", Offset = "0x8E0EFD0", VA = "0x188E107D0")]
		public EncoderHints GetEncoderHints(CLTPEDTEBJF.Platform platform = CLTPEDTEBJF.Platform.Current)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8E14FE0", Offset = "0x8E137E0", VA = "0x188E14FE0")]
		public void SetEncoderHints(EncoderHints hints, CLTPEDTEBJF.Platform platform = CLTPEDTEBJF.Platform.Current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		public static void UpdateMediaGallery(string videoFilePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8E0EAE0", Offset = "0x8E0D2E0", VA = "0x188E0EAE0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8E16F00", Offset = "0x8E15700", VA = "0x188E16F00")]
		static CaptureBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8E15590", Offset = "0x8E13D90", VA = "0x188E15590", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E840", Offset = "0x8E0D040", VA = "0x188E0E840")]
		private static bool APEUWVNZOXV(Codec a, TYHNIYOIMYT b, int c, string[] d, MediaApi e, bool f, bool g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8E14CC0", Offset = "0x8E134C0", VA = "0x188E14CC0")]
		public Codec SelectVideoCodec(bool isStartingCapture = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8E14620", Offset = "0x8E12E20", VA = "0x188E14620")]
		public Codec SelectAudioCodec()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8E14990", Offset = "0x8E13190", VA = "0x188E14990")]
		public GDHOCVPKMLL SelectAudioInputDevice()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8E10940", Offset = "0x8E0F140", VA = "0x188E10940")]
		public static Vector2 GetRecordingResolution(int width, int height, DownScale downscale, Vector2 maxVideoSize)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8E14BB0", Offset = "0x8E133B0", VA = "0x188E14BB0")]
		public void SelectRecordingResolution(int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8E11FE0", Offset = "0x8E107E0", VA = "0x188E11FE0", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8E12210", Offset = "0x8E10A10", VA = "0x188E12210")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8E10F00", Offset = "0x8E0F700", VA = "0x188E10F00")]
		private void JVYZEBLIVTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8E11F90", Offset = "0x8E10790", VA = "0x188E11F90")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8E10660", Offset = "0x8E0EE60", VA = "0x188E10660")]
		protected void GFLSIAXTWAA(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8E141A0", Offset = "0x8E129A0", VA = "0x188E141A0")]
		protected bool QWBVDRLWGLB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8E0F9E0", Offset = "0x8E0E1E0", VA = "0x188E0F9E0")]
		protected bool CIIADWHRKQO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8E0FFA0", Offset = "0x8E0E7A0", VA = "0x188E0FFA0", Slot = "7")]
		public virtual void EncodePointer(IntPtr ptr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8E10EF0", Offset = "0x8E0F6F0", VA = "0x188E10EF0")]
		public bool IsPrepared()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xDF5860", Offset = "0xDF4060", VA = "0x180DF5860")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xDF6FB0", Offset = "0xDF57B0", VA = "0x180DF6FB0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8E10A10", Offset = "0x8E0F210", VA = "0x188E10A10")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x21CF470", Offset = "0x21CDC70", VA = "0x1821CF470")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8E11BB0", Offset = "0x8E103B0", VA = "0x188E11BB0", Slot = "8")]
		protected virtual string OXQDXZIPAAY(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8E0F0A0", Offset = "0x8E0D8A0", VA = "0x188E0F0A0")]
		private static string BZYGQRJQHVH(OutputPath a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8E142D0", Offset = "0x8E12AD0", VA = "0x188E142D0")]
		private static string RBWLJAVKYJP(OutputPath a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8E10EB0", Offset = "0x8E0F6B0", VA = "0x188E10EB0")]
		protected static bool IUFCKIRQZLE(string a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8E0F240", Offset = "0x8E0DA40", VA = "0x188E0F240")]
		protected void CAXITKDIKQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8E10200", Offset = "0x8E0EA00", VA = "0x188E10200")]
		public UnityAudioCapture FindOrCreateUnityAudioCapture(bool logWarnings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8E11160", Offset = "0x8E0F960", VA = "0x188E11160")]
		private bool LXZAGPOOEBM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8E125A0", Offset = "0x8E10DA0", VA = "0x188E125A0", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8E14220", Offset = "0x8E12A20", VA = "0x188E14220")]
		public void QueueStartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xDF7450", Offset = "0xDF5C50", VA = "0x180DF7450")]
		public bool IsStartCaptureQueued()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8E16C90", Offset = "0x8E15490", VA = "0x188E16C90")]
		protected void YZIQOXJISMH(StereoPacking a, SphericalVideoLayout b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8E15080", Offset = "0x8E13880", VA = "0x188E15080")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8E12360", Offset = "0x8E10B60", VA = "0x188E12360")]
		public void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8E144E0", Offset = "0x8E12CE0", VA = "0x188E144E0")]
		public void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8E0FA50", Offset = "0x8E0E250", VA = "0x188E0FA50")]
		public void CancelCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8E0FAC0", Offset = "0x8E0E2C0", VA = "0x188E0FAC0")]
		public static void DeleteCapture(OutputTarget outputTarget, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8E11B20", Offset = "0x8E10320", VA = "0x188E11B20")]
		protected void MBSORVJCSXX(CLTPEDTEBJF.PluginEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8E15650", Offset = "0x8E13E50", VA = "0x188E15650", Slot = "11")]
		public virtual void StopCapture(bool skipPendingFrames = false, bool ignorePendingFileWrites = false, bool deleteCapture = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8E16790", Offset = "0x8E14F90", VA = "0x188E16790")]
		private static EZIWLMAMTBF.Options VZNEXKTDYCP(VideoEncoderHints a, string b)
		{
			return default(EZIWLMAMTBF.Options);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8E0FBD0", Offset = "0x8E0E3D0", VA = "0x188E0FBD0")]
		private static bool ERXZXXOKVWB(string a, VideoEncoderHints b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8E16490", Offset = "0x8E14C90", VA = "0x188E16490")]
		protected void VLNLFVSTJLL(string a, VideoEncoderHints b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8E0F060", Offset = "0x8E0D860", VA = "0x188E0F060")]
		private void BRSRBROJZEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8E16670", Offset = "0x8E14E70", VA = "0x188E16670")]
		private bool VMMALJXREPS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8E16820", Offset = "0x8E15020", VA = "0x188E16820")]
		protected bool WCQPRTEDMKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8E16430", Offset = "0x8E14C30", VA = "0x188E16430")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8E117C0", Offset = "0x8E0FFC0", VA = "0x188E117C0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8E110A0", Offset = "0x8E0F8A0", VA = "0x188E110A0")]
		private void LQLCAQEXFVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8E15F30", Offset = "0x8E14730", VA = "0x188E15F30")]
		private void UGGALSQCUKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8E11070", Offset = "0x8E0F870", VA = "0x188E11070")]
		protected bool LIFZQUPXDUL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8E15E50", Offset = "0x8E14650", VA = "0x188E15E50")]
		protected bool UFJSAOZBCZS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8E10880", Offset = "0x8E0F080", VA = "0x188E10880")]
		public float GetProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8E11B80", Offset = "0x8E10380", VA = "0x188E11B80")]
		protected float ORESVKJBJQS()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8E16D20", Offset = "0x8E15520", VA = "0x188E16D20")]
		protected bool ZXYXPYPDTVV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8E0FA80", Offset = "0x8E0E280", VA = "0x188E0FA80")]
		protected void DEVSNQFNGWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8E145D0", Offset = "0x8E12DD0", VA = "0x188E145D0")]
		protected void SFFNKWTWXDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xC98380", Offset = "0xC96B80", VA = "0x180C98380", Slot = "13")]
		public virtual Texture GetSideBySideTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8E122A0", Offset = "0x8E10AA0", VA = "0x188E122A0")]
		protected void PRUHYAWKMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8E0FEF0", Offset = "0x8E0E6F0", VA = "0x188E0FEF0")]
		public void EncodeAudio(NativeArray<float> audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8E0FDD0", Offset = "0x8E0E5D0", VA = "0x188E0FDD0")]
		public void EncodeAudio(float[] audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8E124A0", Offset = "0x8E10CA0", VA = "0x188E124A0", Slot = "14")]
		public virtual void PreUpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8E16030", Offset = "0x8E14830", VA = "0x188E16030", Slot = "15")]
		public virtual void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8E168D0", Offset = "0x8E150D0", VA = "0x188E168D0")]
		protected bool XITVRIDSBXZ(int a, int b, bool c = false, int d = 1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8E10BA0", Offset = "0x8E0F3A0", VA = "0x188E10BA0")]
		protected RenderTexture HWRMWSJGAZM(Texture a, bool b = false, int c = 1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8E142A0", Offset = "0x8E12AA0", VA = "0x188E142A0")]
		protected void RBBNDWLPHYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8E15FD0", Offset = "0x8E147D0", VA = "0x188E15FD0")]
		public void UpdateFPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8E10D60", Offset = "0x8E0F560", VA = "0x188E10D60")]
		protected int IOKHQFLQFJS(Camera a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8E106E0", Offset = "0x8E0EEE0", VA = "0x188E106E0")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8E10A20", Offset = "0x8E0F220", VA = "0x188E10A20")]
		public static void GetResolution(Resolution res, int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8E11060", Offset = "0x8E0F860", VA = "0x188E11060")]
		protected static int LGQUMFHVGFX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8E17740", Offset = "0x8E15F40", VA = "0x188E17740")]
		public CaptureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum MediaApi
	{
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		Unknown = -1,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		AVFoundation,
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		MediaFoundation,
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		DirectShow,
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		MediaCodec
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum CodecType
	{
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		Video,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		Audio
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class Codec
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private CodecType LWVIKFZEQJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private int GOQPSREODCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private string IAUWALOMBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private bool BEZADPDBPTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private MediaApi RQUAEYLMFJO;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int NMPLFXDGBRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0xB447A0", Offset = "0xB42FA0", VA = "0x180B447A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public MediaApi FEMQAYYZYJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AE0", Offset = "0xAC62E0", VA = "0x180AC7AE0", Slot = "6")]
			get
			{
				return default(MediaApi);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool BTPCYUFIQQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xAA8640", Offset = "0xAA6E40", VA = "0x180AA8640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8E17EE0", Offset = "0x8E166E0", VA = "0x188E17EE0")]
		public void KDLJYYFSUMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8E18040", Offset = "0x8E16840", VA = "0x188E18040")]
		internal Codec(CodecType codecType, int index, string name, MediaApi api, bool hasConfigWindow = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class TYHNIYOIMYT : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private Codec[] VHNBLJQQWXR;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public Codec[] ZBBRRTKBZHG
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public int QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x2506280", Offset = "0x2504A80", VA = "0x182506280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8E21D50", Offset = "0x8E20550", VA = "0x188E21D50")]
		internal TYHNIYOIMYT(Codec[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8E21CB0", Offset = "0x8E204B0", VA = "0x188E21CB0")]
		public Codec YJBEYHDOBBU(string a, MediaApi b = MediaApi.Unknown)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8E21C50", Offset = "0x8E20450", VA = "0x188E21C50")]
		public Codec MPSXBNVHQEZ(MediaApi a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2803AB0", Offset = "0x28022B0", VA = "0x182803AB0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class QMKJLQOFMOG
	{
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static bool KDJUHLMBKNU;

		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private static TYHNIYOIMYT MEVATKCTHQY;

		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private static TYHNIYOIMYT OGGOJFZGYGN;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public static TYHNIYOIMYT VPFVAGGZOUR
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x8E21190", Offset = "0x8E1F990", VA = "0x188E21190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public static TYHNIYOIMYT TWOWIIAEYXW
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x8E21140", Offset = "0x8E1F940", VA = "0x188E21140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8E211E0", Offset = "0x8E1F9E0", VA = "0x188E211E0")]
		private static void VWBIYFDBAUD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8E21280", Offset = "0x8E1FA80", VA = "0x188E21280")]
		private static void YCGMJMAKUBS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum DeviceType
	{
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		AudioInput
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class GDHOCVPKMLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private DeviceType HVQUDDSYAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private int GOQPSREODCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private string IAUWALOMBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private MediaApi RQUAEYLMFJO;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public int NMPLFXDGBRL
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xB447A0", Offset = "0xB42FA0", VA = "0x180B447A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public MediaApi FEMQAYYZYJV
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xAB0800", Offset = "0xAAF000", VA = "0x180AB0800", Slot = "6")]
			get
			{
				return default(MediaApi);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8E1DB10", Offset = "0x8E1C310", VA = "0x188E1DB10")]
		internal GDHOCVPKMLL(DeviceType a, int b, string c, MediaApi d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class PCKLZRPINZX : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private GDHOCVPKMLL[] QLIKFVEZJYL;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public GDHOCVPKMLL[] IVGUAADVVKO
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public int QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x2506280", Offset = "0x2504A80", VA = "0x182506280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8E20300", Offset = "0x8E1EB00", VA = "0x188E20300")]
		internal PCKLZRPINZX(GDHOCVPKMLL[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8E202A0", Offset = "0x8E1EAA0", VA = "0x188E202A0")]
		public GDHOCVPKMLL MPSXBNVHQEZ(MediaApi a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2803AB0", Offset = "0x28022B0", VA = "0x182803AB0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class ARSKLRPWOYQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private static bool KDJUHLMBKNU;

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private static PCKLZRPINZX RKCKMMNKZQR;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public static PCKLZRPINZX FERWTUGPAJG
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x8E0AB10", Offset = "0x8E09310", VA = "0x188E0AB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8E0ABF0", Offset = "0x8E093F0", VA = "0x188E0ABF0")]
		private static void VWBIYFDBAUD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8E0AC90", Offset = "0x8E09490", VA = "0x188E0AC90")]
		private static void ZQIFOMMVXXY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class AZAKQZVMAMJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public enum CompletionStatus
		{
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			BusyFileWriting,
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			BusyPostProcessing,
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			CompletedDeleted,
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			Completed
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private string EXRMEXUJHLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private int DRZYUWZRXQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private bool DEYWHONYWQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private OutputTarget IEDTUDBCWTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private EZIWLMAMTBF.Options GEFNAXZJZXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private ManualResetEvent YDOTQYSHZSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private CompletionStatus AGTYTTQCCRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private string GIYINAZVWWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private bool WBRSVBEASTZ;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		internal Action<AZAKQZVMAMJ> AFUVWODWFQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9C980", VA = "0x180A9E180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xA9E420", Offset = "0xA9CC20", VA = "0x180A9E420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B8E0", Offset = "0x8E0A0E0", VA = "0x188E0B8E0")]
		internal AZAKQZVMAMJ(OutputTarget a, string b, int c, bool d, string e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B1A0", Offset = "0x8E099A0", VA = "0x188E0B1A0")]
		internal void BEQSBDNLXRI(EZIWLMAMTBF.Options a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B1C0", Offset = "0x8E099C0", VA = "0x188E0B1C0")]
		private bool DMWAMFJUJAU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B720", Offset = "0x8E09F20", VA = "0x188E0B720")]
		public bool UXAIGMJLRDG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B430", Offset = "0x8E09C30", VA = "0x188E0B430", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class EZIWLMAMTBF
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct Options
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			public bool applyFastStart;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public bool applyStereoMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000255")]
			public StereoPacking stereoMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			public bool applySphericalVideoLayout;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			public SphericalVideoLayout sphericalVideoLayout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public bool applyMoveCaptureFile;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			public string finalCaptureFilePath;

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x8E20280", Offset = "0x8E1EA80", VA = "0x188E20280")]
			public bool SEGFLMJZDXX()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x8E20260", Offset = "0x8E1EA60", VA = "0x188E20260")]
			public bool RPEYGLBXUBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x8E20240", Offset = "0x8E1EA40", VA = "0x188E20240")]
			public void HCLILOBHVDS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class YMSCKGXVXEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400025A")]
			public uint MGJVPXFWRUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400025B")]
			public long LRNYFWBHBKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400025C")]
			public long RMDHCQNXXRC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public long BKIEEXYGHCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public long PTZCSOKTXEF;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public YMSCKGXVXEE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		internal enum StereoMode_st3d
		{
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			Monoscopic,
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			Stereoscopic_TopBottom,
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			Stereoscopic_LeftRight,
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			Stereoscopic_Custom,
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			Stereoscopic_RightLeft
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class HXGPKBFCMYE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			public string ZPGLQFEVCZU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000266")]
			public bool IFCMXSRHXAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public Options ICLFQJFHSXB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			public ManualResetEvent XPQHGAYYLLS;

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public HXGPKBFCMYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x8E1DB70", Offset = "0x8E1C370", VA = "0x188E1DB70")]
			internal void NCNIHNRIYQC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private static readonly uint YJIDRALCUJM;

		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private static readonly uint RKWCPFONEQD;

		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private static readonly uint HCOIAZBMUHA;

		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private static readonly uint JOKNLFBCDSB;

		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private static readonly uint PPSZQMAOTYQ;

		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private static readonly uint HUESOLNJJDL;

		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private static readonly uint UWIPCNWRVJP;

		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private static readonly uint MYQFPCYQBQS;

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private static readonly uint SXYPTRYKRLI;

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private static readonly uint ELSSRRSOWID;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private static readonly uint YGYLJSDWSFV;

		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private static readonly uint DIMVNNYYNGE;

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private static readonly uint HHTGSYBBMTL;

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private static readonly uint AFRDPXPFKND;

		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private static readonly uint FPLKGFQSWYH;

		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private static readonly uint MVCWPAPXUGY;

		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private static readonly uint CXTQNBGQCRX;

		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private static readonly uint UHVRPZBMJQO;

		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private static readonly uint ZTVVCUCTHPS;

		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private static readonly uint TQQOEVERFNL;

		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private static readonly uint LSAZOLTLKLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private BinaryReader HDHINCFLJFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private Stream IGTVXCVHGMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private Options ORXLXWMWGBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private bool HFYLOGDIUZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private List<YMSCKGXVXEE> QRPHLBRHDDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private List<YMSCKGXVXEE> NZCQHTJRHAH;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8E18C30", Offset = "0x8E17430", VA = "0x188E18C30")]
		public static ManualResetEvent EZMAITLQMCO(string a, bool b, Options c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8E190D0", Offset = "0x8E178D0", VA = "0x188E190D0")]
		public static bool FBUFBHANIEO(string a, bool b, Options c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x8E18DF0", Offset = "0x8E175F0", VA = "0x188E18DF0")]
		public static bool FBUFBHANIEO(string a, string b, Options c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8E1D5F0", Offset = "0x8E1BDF0", VA = "0x188E1D5F0")]
		public EZIWLMAMTBF(Options a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8E1AD70", Offset = "0x8E19570", VA = "0x188E1AD70")]
		public bool SNLVHQAMKMI(Stream a, Stream b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8E18740", Offset = "0x8E16F40", VA = "0x188E18740")]
		public void Close()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8E1BD90", Offset = "0x8E1A590", VA = "0x188E1BD90")]
		private static YMSCKGXVXEE WCRRXEFWRDF(uint a, List<YMSCKGXVXEE> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A0B0", Offset = "0x8E188B0", VA = "0x188E1A0B0")]
		private List<YMSCKGXVXEE> NFBQDPCQLWV(YMSCKGXVXEE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A180", Offset = "0x8E18980", VA = "0x188E1A180")]
		private List<YMSCKGXVXEE> NFBQDPCQLWV(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8E18560", Offset = "0x8E16D60", VA = "0x188E18560")]
		private YMSCKGXVXEE CAALJGONSKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8E18400", Offset = "0x8E16C00", VA = "0x188E18400")]
		private bool AOOBDGSTQLB(YMSCKGXVXEE a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8E1AC70", Offset = "0x8E19470", VA = "0x188E1AC70")]
		private void ONYCASLCRBV(YMSCKGXVXEE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8E18BC0", Offset = "0x8E173C0", VA = "0x188E18BC0")]
		private void EYRDFZQVONE(YMSCKGXVXEE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x8E1C360", Offset = "0x8E1AB60", VA = "0x188E1C360")]
		private void YWAQHWFDNHA(YMSCKGXVXEE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A7F0", Offset = "0x8E18FF0", VA = "0x188E1A7F0")]
		private void NVBIEMPQUDL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8E180A0", Offset = "0x8E168A0", VA = "0x188E180A0")]
		private void AAZOQTPXACZ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B7B0", Offset = "0x8E19FB0", VA = "0x188E1B7B0")]
		private uint WAJQGJNJWCP(YMSCKGXVXEE a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8E18820", Offset = "0x8E17020", VA = "0x188E18820")]
		private bool DYCTCYVXOKF(YMSCKGXVXEE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8E19430", Offset = "0x8E17C30", VA = "0x188E19430")]
		private void FYNKSKPTWZD(YMSCKGXVXEE a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8E1C0D0", Offset = "0x8E1A8D0", VA = "0x188E1C0D0")]
		private void XHTKTZPTONV(YMSCKGXVXEE a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B5A0", Offset = "0x8E19DA0", VA = "0x188E1B5A0")]
		private void VNHKZGKDJVG(YMSCKGXVXEE a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8E18A10", Offset = "0x8E17210", VA = "0x188E18A10")]
		private uint EJIJDPGNARN(YMSCKGXVXEE a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8E1C4D0", Offset = "0x8E1ACD0", VA = "0x188E1C4D0")]
		private uint ZYNHYOCVJNO(YMSCKGXVXEE a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8E1AD50", Offset = "0x8E19550", VA = "0x188E1AD50")]
		private static StereoMode_st3d RXWXWCQKQGC(StereoPacking a)
		{
			return default(StereoMode_st3d);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8E19DA0", Offset = "0x8E185A0", VA = "0x188E19DA0")]
		private uint KJASERQIDAQ(StereoMode_st3d a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8E1BED0", Offset = "0x8E1A6D0", VA = "0x188E1BED0")]
		private uint XDQXLGRZUOK(SphericalVideoLayout a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A380", Offset = "0x8E18B80", VA = "0x188E1A380")]
		private uint NPDZFGVBXYQ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x8E18160", Offset = "0x8E16960", VA = "0x188E18160")]
		private uint AMKOQTWQWCJ(string a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8E19AA0", Offset = "0x8E182A0", VA = "0x188E19AA0")]
		private uint IBEIDDIZCQP(SphericalVideoLayout a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A910", Offset = "0x8E19110", VA = "0x188E1A910")]
		private uint OGUTUFLVNZA()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8E196D0", Offset = "0x8E17ED0", VA = "0x188E196D0")]
		private uint HMRYXALOJSY()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8E19C90", Offset = "0x8E18490", VA = "0x188E19C90")]
		private void JQNKWHJEJKU(YMSCKGXVXEE a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8E1C460", Offset = "0x8E1AC60", VA = "0x188E1C460")]
		private ushort ZIISGIMBRLC()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8E19F10", Offset = "0x8E18710", VA = "0x188E19F10")]
		private uint LNMUZGIQBZM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8E1ACE0", Offset = "0x8E194E0", VA = "0x188E1ACE0")]
		private ulong RLVSKYXDLPL()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8E1C2E0", Offset = "0x8E1AAE0", VA = "0x188E1C2E0")]
		private void XIUPZTLHSMW(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8E19F80", Offset = "0x8E18780", VA = "0x188E19F80")]
		private void MWIXNBSGLDR(uint a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8E19640", Offset = "0x8E17E40", VA = "0x188E19640")]
		private void GRNNLAQZLOQ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A020", Offset = "0x8E18820", VA = "0x188E1A020")]
		private static uint MXTODTWNIND(string a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public enum NoneAutoCustom
	{
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		Auto,
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		Custom
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum AudioCaptureSource
	{
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		Unity,
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		Microphone,
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		Manual,
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		Wwise,
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		UnityAudioMixer
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum StereoPacking
	{
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		TopBottom,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		LeftRight
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public enum Transparency
	{
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		Codec,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		TopBottom,
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		LeftRight
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum SphericalVideoLayout
	{
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		Equirectangular360,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		Equirectangular180
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public enum StopMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		FramesEncoded,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		SecondsEncoded,
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		SecondsElapsed
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public enum StartTriggerMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		Manual,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		OnStart
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum StartDelayMode
	{
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		RealSeconds,
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		GameSeconds,
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		Manual
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public enum ImageSequenceFormat
	{
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		PNG,
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		JPEG,
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		TIFF,
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		HEIF
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public enum OutputTarget
	{
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		VideoFile,
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		ImageSequence,
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		NamedPipe
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public enum AndroidVulkanPreTransform
	{
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		Portrait,
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		PortraitUpsideDown,
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		LandscapeLeft,
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		LandscapeRight
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public enum ColourRange
	{
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		Limited,
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		Full
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum RealtimeFramePresentationTimestampOptions
	{
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		Realtime,
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		Fixed,
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		Nearest
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum OrientationMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		Rotate90,
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		Rotate180,
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		Rotate270
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class Utils
	{
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static string[] JYPEVPQLRWR;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static string[] PNZYNXPXTPP;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static string[] IWNWNOPTUTL;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static string[] TIKCSSTFMFF;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8E237E0", Offset = "0x8E21FE0", VA = "0x188E237E0")]
		public static string[] UJCXKHYWRRZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8E23480", Offset = "0x8E21C80", VA = "0x188E23480")]
		public static RenderTextureFormat QBHGEBHDFXP(bool a, bool b, bool c)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8E22D50", Offset = "0x8E21550", VA = "0x188E22D50")]
		public static bool IBLUMSIXMFJ(Camera a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8E22FE0", Offset = "0x8E217E0", VA = "0x188E22FE0")]
		public static Camera[] OZNOYSCUGXS(Camera a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8E23850", Offset = "0x8E22050", VA = "0x188E23850")]
		public static bool WDDOCHYRZXM(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x8E22BB0", Offset = "0x8E213B0", VA = "0x188E22BB0")]
		public static bool ANNFFZCMIVG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8E22DF0", Offset = "0x8E215F0", VA = "0x188E22DF0")]
		public static bool MPGMDWRBNTI(string a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8E22CA0", Offset = "0x8E214A0", VA = "0x188E22CA0")]
		public static string HDSOYZJMTPH(ImageSequenceFormat a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class QKUPCXLAKFC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public enum SampleFormat
		{
			[Cpp2IlInjected.Token(Token = "0x40002C0")]
			PCM16 = 2,
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			Float32 = 4
		}

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private static byte[] DOUSZITCQYG;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private static byte[] BPGFNIZJQGM;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private static byte[] KAECGNOAOMP;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private static byte[] LHGPCHJVCKM;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static byte[] MPCOSDBJHZI;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static byte[] WLXLAJYJFTS;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static byte[] DOZLYATQYWW;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private const int IQRDNMMIAXT = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private FileStream XNMGTQWEORK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private byte[] FQOBQOTKNCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private int YCJTEYDOZXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private int JPQRAXNCIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private int JSBRKBCLGOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private int FJIYCVMWWGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private SampleFormat DSEZDUGCOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private int BYQWNFODMKE;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8E21050", Offset = "0x8E1F850", VA = "0x188E21050")]
		public QKUPCXLAKFC(string a, int b, int c, SampleFormat d = SampleFormat.Float32)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8E20460", Offset = "0x8E1EC60", VA = "0x188E20460", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8E204E0", Offset = "0x8E1ECE0", VA = "0x188E204E0")]
		public void IASRIRWQKRD(float[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8E20670", Offset = "0x8E1EE70", VA = "0x188E20670")]
		public void NWZHUJIIDJR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8E20CB0", Offset = "0x8E1F4B0", VA = "0x188E20CB0")]
		private static byte[] ODXLFUQKPFE(int a, int b = 2)
		{
			return null;
		}
	}
}
namespace RenderHeads.Media.AVProMovieCapture.Editor
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class EditorCoroutine : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8E24AE0", Offset = "0x8E232E0", VA = "0x188E24AE0")]
		public void RunCoroutine(IEnumerator routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA9F980", Offset = "0xA9E180", VA = "0x180A9F980")]
		public EditorCoroutine()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}

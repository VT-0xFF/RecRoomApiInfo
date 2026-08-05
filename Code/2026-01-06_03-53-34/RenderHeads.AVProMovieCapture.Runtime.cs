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
		[Cpp2IlInjected.Address(RVA = "0x8EF92A0", Offset = "0x8EF7CA0", VA = "0x188EF92A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9040", Offset = "0x8EF7A40", VA = "0x188EF9040")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8730", Offset = "0x8EF7130", VA = "0x188EF8730")]
		internal void LIRQLNOTZSE(AmbisonicOrder a, AmbisonicChannelOrder b, AmbisonicNormalisation c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9180", Offset = "0x8EF7B80", VA = "0x188EF9180")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8920", Offset = "0x8EF7320", VA = "0x188EF8920")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8710", Offset = "0x8EF7110", VA = "0x188EF8710")]
		private void KVNSBOMRCZY(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8520", Offset = "0x8EF6F20", VA = "0x188EF8520")]
		private void GPYHMQPKWFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8A80", Offset = "0x8EF7480", VA = "0x188EF8A80")]
		private void OnAudioFilterRead(float[] samples, int channelCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8EF82E0", Offset = "0x8EF6CE0", VA = "0x188EF82E0")]
		internal void FKODNQSGBDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8EF86D0", Offset = "0x8EF70D0", VA = "0x188EF86D0")]
		internal int IIRZVETOBKF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9420", Offset = "0x8EF7E20", VA = "0x188EF9420")]
		internal void PVMKROKNXZU(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8EF95F0", Offset = "0x8EF7FF0", VA = "0x188EF95F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			get
			{
				return default(AmbisonicOrder);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AmbisonicFormat PQVCEFMFGIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB45A80", Offset = "0xB44480", VA = "0x180B45A80")]
			get
			{
				return default(AmbisonicFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA010", Offset = "0x8EF8A10", VA = "0x188EFA010")]
		internal void UQDBWJEGZMP(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8EF97E0", Offset = "0x8EF81E0", VA = "0x188EF97E0")]
		internal void DNQNBXAKNQW(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9F20", Offset = "0x8EF8920", VA = "0x188EF9F20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9F30", Offset = "0x8EF8930", VA = "0x188EF9F30")]
		private void PRAPNAUHSJH(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9FE0", Offset = "0x8EF89E0", VA = "0x188EF9FE0")]
		private void ROTJRQWJYXK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8EF98C0", Offset = "0x8EF82C0", VA = "0x188EF98C0")]
		private void GEGVZONESYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8EF96E0", Offset = "0x8EF80E0", VA = "0x188EF96E0")]
		private void CHRTAMDNVHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9CF0", Offset = "0x8EF86F0", VA = "0x188EF9CF0")]
		private bool HSDDPQVOECU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9D50", Offset = "0x8EF8750", VA = "0x188EF9D50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA150", Offset = "0x8EF8B50", VA = "0x188EFA150")]
		private void UXFYFYZVHOK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9E10", Offset = "0x8EF8810", VA = "0x188EF9E10")]
		internal void NRJCXCCJVWG(float[] a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9D10", Offset = "0x8EF8710", VA = "0x188EF9D10")]
		private void LFNGWLWKPKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA390", Offset = "0x8EF8D90", VA = "0x188EFA390")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EFA4C0", Offset = "0x8EF8EC0", VA = "0x188EFA4C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA480", Offset = "0x8EF8E80", VA = "0x188EFA480")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA450", Offset = "0x8EF8E50", VA = "0x188EFA450")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA620", Offset = "0x8EF9020", VA = "0x188EFA620")]
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
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8EFAF40", Offset = "0x8EF9940", VA = "0x188EFAF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public SelectByMode JOPWRFIGNCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			get
			{
				return default(SelectByMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8EFAF90", Offset = "0x8EF9990", VA = "0x188EFAF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ScanFrequencyMode TAQIPDJLBYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8EFAF70", Offset = "0x8EF9970", VA = "0x188EFAF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool YOFNIHGTWMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F20", Offset = "0xCB1920", VA = "0x180CB2F20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8EFAF80", Offset = "0x8EF9980", VA = "0x188EFAF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string WJPJKKPDLEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8EFAFC0", Offset = "0x8EF99C0", VA = "0x188EFAFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string SWIIMXFLLKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8EFAFA0", Offset = "0x8EF99A0", VA = "0x188EFAFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA670", Offset = "0x8EF9070", VA = "0x188EFA670")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAC50", Offset = "0x8EF9650", VA = "0x188EFAC50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA670", Offset = "0x8EF9070", VA = "0x188EFA670")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAD40", Offset = "0x8EF9740", VA = "0x188EFAD40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAB00", Offset = "0x8EF9500", VA = "0x188EFAB00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA910", Offset = "0x8EF9310", VA = "0x188EFA910")]
		private void LAKOJFVQUVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAAF0", Offset = "0x8EF94F0", VA = "0x188EFAAF0")]
		private void NYJQTLFAGTZ(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAB90", Offset = "0x8EF9590", VA = "0x188EFAB90")]
		public bool ScanForCameraChange()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA680", Offset = "0x8EF9080", VA = "0x188EFA680")]
		private Camera DVCJRFCSHQT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAC60", Offset = "0x8EF9660", VA = "0x188EFAC60")]
		public void UpdateCameraCache(bool forceScanHiddenCameras = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA9F0", Offset = "0x8EF93F0", VA = "0x188EFA9F0")]
		private static Camera NCWYICETEOH(int a, Camera[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAD60", Offset = "0x8EF9760", VA = "0x188EFAD60")]
		private static Camera YOKAYNRKNPI(int a, Camera[] b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8EFADF0", Offset = "0x8EF97F0", VA = "0x188EFADF0")]
		private static Camera ZJQIFZHNJMN(int a, Camera[] b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAE90", Offset = "0x8EF9890", VA = "0x188EFAE90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EFB4D0", Offset = "0x8EF9ED0", VA = "0x188EFB4D0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB590", Offset = "0x8EF9F90", VA = "0x188EFB590")]
		private void XHJMGXWBJAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB200", Offset = "0x8EF9C00", VA = "0x188EFB200")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB4F0", Offset = "0x8EF9EF0", VA = "0x188EFB4F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAFE0", Offset = "0x8EF99E0", VA = "0x188EFAFE0")]
		private float[] NTOXNNRPORC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB5B0", Offset = "0x8EF9FB0", VA = "0x188EFB5B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int JADBZTPPLTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAE61A0", Offset = "0xAE4BA0", VA = "0x180AE61A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IntPtr CFDYUZVMBNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC020", Offset = "0x8EFAA20", VA = "0x188EFC020")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override int EPTLFHYMKTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x13C3A10", Offset = "0x13C2410", VA = "0x1813C3A10", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int XAEVFDILGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC030", Offset = "0x8EFAA30", VA = "0x188EFC030", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override int WXIJEZWUNOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD28600", Offset = "0xD27000", VA = "0x180D28600", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB920", Offset = "0x8EFA320", VA = "0x188EFB920", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD31170", Offset = "0xD2FB70", VA = "0x180D31170", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBEA0", Offset = "0x8EFA8A0", VA = "0x188EFBEA0", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB910", Offset = "0x8EFA310", VA = "0x188EFB910", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBDF0", Offset = "0x8EFA7F0", VA = "0x188EFBDF0", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBD00", Offset = "0x8EFA700", VA = "0x188EFBD00", Slot = "13")]
		public override IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB5C0", Offset = "0x8EF9FC0", VA = "0x188EFB5C0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB660", Offset = "0x8EFA060", VA = "0x188EFB660")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBF70", Offset = "0x8EFA970", VA = "0x188EFBF70")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override int XAEVFDILGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC030", Offset = "0x8EFAA30", VA = "0x188EFC030", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override int WXIJEZWUNOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC1E0", Offset = "0x8EFABE0", VA = "0x188EFC1E0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC090", Offset = "0x8EFAA90", VA = "0x188EFC090")]
		private NativeArray<float> KTCPCMYDZRY(int a)
		{
			return default(NativeArray<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970")]
		private void PRXFWLOHKNW(NativeArray<float> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC200", Offset = "0x8EFAC00", VA = "0x188EFC200", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC310", Offset = "0x8EFAD10", VA = "0x188EFC310", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC040", Offset = "0x8EFAA40", VA = "0x188EFC040", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC370", Offset = "0x8EFAD70", VA = "0x188EFC370")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAD2FA0", Offset = "0xAD19A0", VA = "0x180AD2FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HXPYRYGGPZU
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAC7EC0", Offset = "0xAC68C0", VA = "0x180AC7EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAC7E90", Offset = "0xAC6890", VA = "0x180AC7E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float[] VDPSBGBFOKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int JADBZTPPLTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAD45B0", Offset = "0xAD2FB0", VA = "0x180AD45B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IntPtr CFDYUZVMBNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8EFD750", Offset = "0x8EFC150", VA = "0x188EFD750")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override int EPTLFHYMKTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x12592A0", Offset = "0x1257CA0", VA = "0x1812592A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override int XAEVFDILGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC030", Offset = "0x8EFAA30", VA = "0x188EFC030", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override int WXIJEZWUNOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xBF6EC0", Offset = "0xBF58C0", VA = "0x180BF6EC0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8EFD150", Offset = "0x8EFBB50", VA = "0x188EFD150")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC980", Offset = "0x8EFB380", VA = "0x188EFC980", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8EFCF70", Offset = "0x8EFB970", VA = "0x188EFCF70", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8EFD320", Offset = "0x8EFBD20", VA = "0x188EFD320", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC970", Offset = "0x8EFB370", VA = "0x188EFC970", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8EFCEB0", Offset = "0x8EFB8B0", VA = "0x188EFCEB0", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFCD60", Offset = "0x8EFB760", VA = "0x188EFCD60", Slot = "13")]
		public override IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC460", Offset = "0x8EFAE60", VA = "0x188EFC460", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC500", Offset = "0x8EFAF00", VA = "0x188EFC500")]
		public void OnAudioFilterReadCombiner(float[] data, int channels, bool isMicrophone, int sampleRate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8EFD5C0", Offset = "0x8EFBFC0", VA = "0x188EFD5C0")]
		private float[] XFWARKUVSHS(float[] a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8EFD6A0", Offset = "0x8EFC0A0", VA = "0x188EFD6A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override int XAEVFDILGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override int WXIJEZWUNOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8EFD760", Offset = "0x8EFC160", VA = "0x188EFD760")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAD2FA0", Offset = "0xAD19A0", VA = "0x180AD2FA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public PTPJHPGCGIZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8F0CA00", Offset = "0x8F0B400", VA = "0x188F0CA00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8F0CE10", Offset = "0x8F0B810", VA = "0x188F0CE10", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public DQRHCRMQEBI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8F0C5A0", Offset = "0x8F0AFA0", VA = "0x188F0C5A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8F0C640", Offset = "0x8F0B040", VA = "0x188F0C640", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xCAF4B0", Offset = "0xCADEB0", VA = "0x180CAF4B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xE65C40", Offset = "0xE64640", VA = "0x180E65C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool XRWOGYOLCDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xCAF620", Offset = "0xCAE020", VA = "0x180CAF620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7A0", Offset = "0xCAE1A0", VA = "0x180CAF7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8F05800", Offset = "0x8F04200", VA = "0x188F05800")]
		public void SetCamera(Camera topCamera, bool useContributingCameras = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8F057B0", Offset = "0x8F041B0", VA = "0x188F057B0")]
		public void SetCamera(Camera topCamera, Camera[] contributingCameras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8F056D0", Offset = "0x8F040D0", VA = "0x188F056D0")]
		private bool RONDYDEYHSR(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8F04A90", Offset = "0x8F03490", VA = "0x188F04A90")]
		private bool PQCBWNVHJQW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8F04830", Offset = "0x8F03230", VA = "0x188F04830")]
		private bool IBLUMSIXMFJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8F05A10", Offset = "0x8F04410", VA = "0x188F05A10", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8F05BE0", Offset = "0x8F045E0", VA = "0x188F05BE0")]
		[IteratorStateMachine(typeof(DQRHCRMQEBI))]
		private IEnumerator VZILFCXUHEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8F047C0", Offset = "0x8F031C0", VA = "0x188F047C0")]
		[IteratorStateMachine(typeof(PTPJHPGCGIZ))]
		public IEnumerator Capture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8F04860", Offset = "0x8F03260", VA = "0x188F04860")]
		private bool IYBGEKSQWFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8F043F0", Offset = "0x8F02DF0", VA = "0x188F043F0")]
		private void CULMSEJICAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8F05920", Offset = "0x8F04320", VA = "0x188F05920", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8F04AF0", Offset = "0x8F034F0", VA = "0x188F04AF0")]
		private void PWXXBUMBDWM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E31DD0", Offset = "0x1E307D0", VA = "0x181E31DD0", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8F04CC0", Offset = "0x8F036C0", VA = "0x188F04CC0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8F049A0", Offset = "0x8F033A0", VA = "0x188F049A0", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8F05C50", Offset = "0x8F04650", VA = "0x188F05C50")]
		public CaptureFromCamera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8F043E0", Offset = "0x8F02DE0", VA = "0x188F043E0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public IVOSRKOWRUB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8F0C730", Offset = "0x8F0B130", VA = "0x188F0C730", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8F0C7A0", Offset = "0x8F0B1A0", VA = "0x188F0C7A0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xCAF4B0", Offset = "0xCADEB0", VA = "0x180CAF4B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xE65C40", Offset = "0xE64640", VA = "0x180E65C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public CubemapResolution AFISFYOVPGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1799710", Offset = "0x1798110", VA = "0x181799710")]
			get
			{
				return default(CubemapResolution);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8F04390", Offset = "0x8F02D90", VA = "0x188F04390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CubemapDepth OXCLVPXKKST
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8F04340", Offset = "0x8F02D40", VA = "0x188F04340")]
			get
			{
				return default(CubemapDepth);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8F04380", Offset = "0x8F02D80", VA = "0x188F04380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool CUYFQAPXDMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xCAF620", Offset = "0xCAE020", VA = "0x180CAF620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7A0", Offset = "0xCAE1A0", VA = "0x180CAF7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool PNRHWBGKMDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCAF610", Offset = "0xCAE010", VA = "0x180CAF610")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xCAF790", Offset = "0xCAE190", VA = "0x180CAF790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool GMSBEDSLNIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8F04360", Offset = "0x8F02D60", VA = "0x188F04360")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8F043B0", Offset = "0x8F02DB0", VA = "0x188F043B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool XJMCZQSVSCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8F04370", Offset = "0x8F02D70", VA = "0x188F04370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8F043C0", Offset = "0x8F02DC0", VA = "0x188F043C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public StereoPacking EORMPBUFKSB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x24D1020", Offset = "0x24CFA20", VA = "0x1824D1020")]
			get
			{
				return default(StereoPacking);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8F043D0", Offset = "0x8F02DD0", VA = "0x188F043D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float EHELCZWLILE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8F04350", Offset = "0x8F02D50", VA = "0x188F04350")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8F043A0", Offset = "0x8F02DA0", VA = "0x188F043A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8F04290", Offset = "0x8F02C90", VA = "0x188F04290")]
		public CaptureFromCamera360()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8F04180", Offset = "0x8F02B80", VA = "0x188F04180")]
		private CubemapRenderMethod YZAIEOVFWTV()
		{
			return default(CubemapRenderMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xE61200", Offset = "0xE5FC00", VA = "0x180E61200")]
		public void SetCamera(Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8F03B90", Offset = "0x8F02590", VA = "0x188F03B90", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8F03D00", Offset = "0x8F02700", VA = "0x188F03D00")]
		[IteratorStateMachine(typeof(IVOSRKOWRUB))]
		private IEnumerator VZILFCXUHEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8F00680", Offset = "0x8EFF080", VA = "0x188F00680")]
		private void NSRZAWNBBBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8F004F0", Offset = "0x8EFEEF0", VA = "0x188F004F0")]
		private static void KKZKBSVBHIZ(RenderTexture a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8F03D70", Offset = "0x8F02770", VA = "0x188F03D70")]
		private void YHNFULLNHMP(RenderTexture a, RenderTexture b, bool c, Quaternion d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8EFFF50", Offset = "0x8EFE950", VA = "0x188EFFF50")]
		private void CULMSEJICAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8F009B0", Offset = "0x8EFF3B0", VA = "0x188F009B0")]
		private void OKJVHTOQGPU(Camera a, RenderTexture b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8F041B0", Offset = "0x8F02BB0", VA = "0x188F041B0")]
		private void ZGMSJZKAXTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8F02620", Offset = "0x8F01020", VA = "0x188F02620", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8F004B0", Offset = "0x8EFEEB0", VA = "0x188F004B0", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8F039B0", Offset = "0x8F023B0", VA = "0x188F039B0", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8F02370", Offset = "0x8F00D70", VA = "0x188F02370", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F0CE50", Offset = "0x8F0B850", VA = "0x188F0CE50")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public DQWNZYGNNMR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8F0C680", Offset = "0x8F0B080", VA = "0x188F0C680", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x8F0C6F0", Offset = "0x8F0B0F0", VA = "0x188F0C6F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xCAF4B0", Offset = "0xCADEB0", VA = "0x180CAF4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8EFFE60", Offset = "0x8EFE860", VA = "0x188EFFE60")]
		public CaptureFromCamera360ODS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8EFF2B0", Offset = "0x8EFDCB0", VA = "0x188EFF2B0")]
		public void SetCamera(Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8EFF2E0", Offset = "0x8EFDCE0", VA = "0x188EFF2E0", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8EFD7C0", Offset = "0x8EFC1C0", VA = "0x188EFD7C0")]
		private Camera BLFHLLBISCQ(Camera a, string b, float c, float d, int e, int f, float g, float h, int i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8EFFB80", Offset = "0x8EFE580", VA = "0x188EFFB80", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8EFFD10", Offset = "0x8EFE710", VA = "0x188EFFD10")]
		[IteratorStateMachine(typeof(DQWNZYGNNMR))]
		private IEnumerator VZILFCXUHEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8EFDE50", Offset = "0x8EFC850", VA = "0x188EFDE50")]
		private void NSRZAWNBBBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8EFFD80", Offset = "0x8EFE780", VA = "0x188EFFD80")]
		private void ZGMSJZKAXTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8EFF410", Offset = "0x8EFDE10", VA = "0x188EFF410")]
		private void UPGICRGRPZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8EFDE10", Offset = "0x8EFC810", VA = "0x188EFDE10", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE360", Offset = "0x8EFCD60", VA = "0x188EFE360", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8EFFAB0", Offset = "0x8EFE4B0", VA = "0x188EFFAB0")]
		private static void UTXCSHQYIMM(Camera a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE120", Offset = "0x8EFCB20", VA = "0x188EFE120", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public KSDNQKWIFNB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8F0C7E0", Offset = "0x8F0B1E0", VA = "0x188F0C7E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8F0C910", Offset = "0x8F0B310", VA = "0x188F0C910", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F067B0", Offset = "0x8F051B0", VA = "0x188F067B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x8F067C0", Offset = "0x8F051C0", VA = "0x188F067C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public MouseCursor YWKCBEZYUNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xCAF580", Offset = "0xCADF80", VA = "0x180CAF580")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xE61200", Offset = "0xE5FC00", VA = "0x180E61200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8F05D80", Offset = "0x8F04780", VA = "0x188F05D80", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8F06180", Offset = "0x8F04B80", VA = "0x188F06180")]
		private void SJNQCSXZMKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8F05CB0", Offset = "0x8F046B0", VA = "0x188F05CB0")]
		private void GESNZHMRZRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8F065A0", Offset = "0x8F04FA0", VA = "0x188F065A0", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8F066E0", Offset = "0x8F050E0", VA = "0x188F066E0")]
		[IteratorStateMachine(typeof(KSDNQKWIFNB))]
		private IEnumerator VZILFCXUHEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8F066B0", Offset = "0x8F050B0", VA = "0x188F066B0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8F06750", Offset = "0x8F05150", VA = "0x188F06750")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public KSIUNRQFOYK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8F0C950", Offset = "0x8F0B350", VA = "0x188F0C950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8F0C9C0", Offset = "0x8F0B3C0", VA = "0x188F0C9C0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F067B0", Offset = "0x8F051B0", VA = "0x188F067B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8F067C0", Offset = "0x8F051C0", VA = "0x188F067C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xE61200", Offset = "0xE5FC00", VA = "0x180E61200")]
		public void SetSourceTexture(Texture texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8F073E0", Offset = "0x8F05DE0", VA = "0x188F073E0")]
		private bool RONDYDEYHSR(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8F076B0", Offset = "0x8F060B0", VA = "0x188F076B0")]
		public void UpdateSourceTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8F074C0", Offset = "0x8F05EC0", VA = "0x188F074C0")]
		private bool SBAZPQVOQTF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8F067D0", Offset = "0x8F051D0", VA = "0x188F067D0")]
		private bool AHCJFYZILCN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8F07610", Offset = "0x8F06010", VA = "0x188F07610", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8F076C0", Offset = "0x8F060C0", VA = "0x188F076C0")]
		[IteratorStateMachine(typeof(KSIUNRQFOYK))]
		private IEnumerator VZILFCXUHEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8F068E0", Offset = "0x8F052E0", VA = "0x188F068E0")]
		private void NSRZAWNBBBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8F06E10", Offset = "0x8F05810", VA = "0x188F06E10")]
		private void PWXXBUMBDWM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8F07730", Offset = "0x8F06130", VA = "0x188F07730")]
		private void ZGMSJZKAXTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8F067F0", Offset = "0x8F051F0", VA = "0x188F067F0", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8F06FA0", Offset = "0x8F059A0", VA = "0x188F06FA0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8F07530", Offset = "0x8F05F30", VA = "0x188F07530", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8F077E0", Offset = "0x8F061E0", VA = "0x188F077E0")]
		public CaptureFromTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("AVPro Movie Capture/Capture From WebCamTexture", 3)]
	public class CaptureFromWebCamTexture : CaptureFromTexture
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8F07840", Offset = "0x8F06240", VA = "0x188F07840", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8F077E0", Offset = "0x8F061E0", VA = "0x188F077E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool NHRVDYSOGFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xCA2B00", Offset = "0xCA1500", VA = "0x180CA2B00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCED530", Offset = "0xCEBF30", VA = "0x180CED530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool GAZNRJXNHOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xB199C0", Offset = "0xB183C0", VA = "0x180B199C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xB1A4D0", Offset = "0xB18ED0", VA = "0x180B1A4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8F0AF50", Offset = "0x8F09950", VA = "0x188F0AF50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8F0AFC0", Offset = "0x8F099C0", VA = "0x188F0AFC0")]
		private void TMRHTRQFXIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8F0AA00", Offset = "0x8F09400", VA = "0x188F0AA00")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8F08A10", Offset = "0x8F07410", VA = "0x188F08A10")]
		private void AKZBMMWSDCZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8F078B0", Offset = "0x8F062B0", VA = "0x188F078B0")]
		private void ADIWYNPHQRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8F0BAE0", Offset = "0x8F0A4E0", VA = "0x188F0BAE0")]
		private void YQULGPUKJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8F0B9D0", Offset = "0x8F0A3D0", VA = "0x188F0B9D0")]
		private void XVKLZQNBTJK(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8F0A8B0", Offset = "0x8F092B0", VA = "0x188F0A8B0")]
		private void GEGVZONESYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8F0A820", Offset = "0x8F09220", VA = "0x188F0A820")]
		private void CHRTAMDNVHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8F0BA60", Offset = "0x8F0A460", VA = "0x188F0BA60")]
		private void YHMPBUQXYJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8F0AED0", Offset = "0x8F098D0", VA = "0x188F0AED0")]
		private void SMVRBSVYGAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8F0A980", Offset = "0x8F09380", VA = "0x188F0A980")]
		private void JOCDKNAYHLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8F0B7E0", Offset = "0x8F0A1E0", VA = "0x188F0B7E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8F0C1D0", Offset = "0x8F0ABD0", VA = "0x188F0C1D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D84AF0", Offset = "0x1D834F0", VA = "0x181D84AF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x1D84BA0", Offset = "0x1D835A0", VA = "0x181D84BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int SMPFEJRTRGA
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8F217D0", Offset = "0x8F201D0", VA = "0x188F217D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int JBLQFBYBNDN
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xD28600", Offset = "0xD27000", VA = "0x180D28600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public RenderTexture MOOOTEVOLWA
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8F20E00", Offset = "0x8F1F800", VA = "0x188F20E00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8F21720", Offset = "0x8F20120", VA = "0x188F21720")]
		public void SetTargetSize(int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8F21740", Offset = "0x8F20140", VA = "0x188F21740")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8F213B0", Offset = "0x8F1FDB0", VA = "0x188F213B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8F20E90", Offset = "0x8F1F890", VA = "0x188F20E90")]
		private void LIRQLNOTZSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8F21750", Offset = "0x8F20150", VA = "0x188F21750")]
		private void UZPODDTUACT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8F211D0", Offset = "0x8F1FBD0", VA = "0x188F211D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8F21410", Offset = "0x8F1FE10", VA = "0x188F21410")]
		public void OnNumSamplesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x84850A0", Offset = "0x8483AA0", VA = "0x1884850A0")]
		private static float UYDVAHCVFMF(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8F21640", Offset = "0x8F20040", VA = "0x188F21640")]
		private void PRWHJZDPFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8F20CE0", Offset = "0x8F1F6E0", VA = "0x188F20CE0")]
		public void Accumulate(Texture src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8F214D0", Offset = "0x8F1FED0", VA = "0x188F214D0")]
		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8F217B0", Offset = "0x8F201B0", VA = "0x188F217B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F219E0", Offset = "0x8F203E0", VA = "0x188F219E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8F21930", Offset = "0x8F20330", VA = "0x188F21930")]
		public void SetTexture(Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8F217E0", Offset = "0x8F201E0", VA = "0x188F217E0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8F21AA0", Offset = "0x8F204A0", VA = "0x188F21AA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8F22590", Offset = "0x8F20F90", VA = "0x188F22590")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
			internal FAERWTENXKL(PlayableDirector a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8F1FD30", Offset = "0x8F1E730", VA = "0x188F1FD30")]
			internal bool DBMJBCNJRLN(PlayableDirector a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8F1FD90", Offset = "0x8F1E790", VA = "0x188F1FD90")]
			internal void GEGVZONESYV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8F1FC60", Offset = "0x8F1E660", VA = "0x188F1FC60")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8F24A90", Offset = "0x8F23490", VA = "0x188F24A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8F24130", Offset = "0x8F22B30", VA = "0x188F24130")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8F24130", Offset = "0x8F22B30", VA = "0x188F24130")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8F24540", Offset = "0x8F22F40", VA = "0x188F24540")]
		internal void JCRDCTVOKJR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8F24320", Offset = "0x8F22D20", VA = "0x188F24320")]
		internal void GEGVZONESYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8F24140", Offset = "0x8F22B40", VA = "0x188F24140")]
		internal void CHRTAMDNVHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8F246E0", Offset = "0x8F230E0", VA = "0x188F246E0")]
		public void ScanForPlayableDirectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8F24640", Offset = "0x8F23040", VA = "0x188F24640")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8F24550", Offset = "0x8F22F50", VA = "0x188F24550")]
		private void LAKOJFVQUVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8F24630", Offset = "0x8F23030", VA = "0x188F24630")]
		private void NYJQTLFAGTZ(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8F24A10", Offset = "0x8F23410", VA = "0x188F24A10")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F24F10", Offset = "0x8F23910", VA = "0x188F24F10", Slot = "13")]
		public virtual IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8F24D80", Offset = "0x8F23780", VA = "0x188F24D80")]
		public static int GetUnityAudioChannelCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8F24EA0", Offset = "0x8F238A0", VA = "0x188F24EA0")]
		private static int HTXEWVCYWRB(AudioSpeakerMode a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
			internal OXFOPBVEKGQ(VideoPlayer a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x8F21B90", Offset = "0x8F20590", VA = "0x188F21B90")]
			internal bool DBMJBCNJRLN(VideoPlayer a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x8F21CF0", Offset = "0x8F206F0", VA = "0x188F21CF0")]
			internal void GEGVZONESYV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8F221E0", Offset = "0x8F20BE0", VA = "0x188F221E0")]
			internal bool QTEPOXJRWYC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8F21E00", Offset = "0x8F20800", VA = "0x188F21E00")]
			internal void LHDDQBNWUOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8F22140", Offset = "0x8F20B40", VA = "0x188F22140")]
			private void MGBHJBAQBJA(VideoPlayer a, long b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x8F21BF0", Offset = "0x8F205F0", VA = "0x188F21BF0")]
			private void FOJNFSXHZYP(VideoPlayer a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x8F21D70", Offset = "0x8F20770", VA = "0x188F21D70")]
			internal void HVBZHWNQGCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x8F22220", Offset = "0x8F20C20", VA = "0x188F22220")]
			internal bool Update(float deltaTime)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x8F21B00", Offset = "0x8F20500", VA = "0x188F21B00")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public KLZHACCQFNT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x8F20040", Offset = "0x8F1EA40", VA = "0x188F20040", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8F20180", Offset = "0x8F1EB80", VA = "0x188F20180", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8F26E40", Offset = "0x8F25840", VA = "0x188F26E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8F260B0", Offset = "0x8F24AB0", VA = "0x188F260B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8F260B0", Offset = "0x8F24AB0", VA = "0x188F260B0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8F26570", Offset = "0x8F24F70", VA = "0x188F26570")]
		internal void JCRDCTVOKJR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8F26250", Offset = "0x8F24C50", VA = "0x188F26250")]
		public bool CanContinue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8F269B0", Offset = "0x8F253B0", VA = "0x188F269B0")]
		[IteratorStateMachine(typeof(KLZHACCQFNT))]
		internal IEnumerator PLGCYHGCLFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8F263C0", Offset = "0x8F24DC0", VA = "0x188F263C0")]
		internal void GEGVZONESYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8F260C0", Offset = "0x8F24AC0", VA = "0x188F260C0")]
		internal void CHRTAMDNVHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8F26A20", Offset = "0x8F25420", VA = "0x188F26A20")]
		public void ScanForVideoPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8F26910", Offset = "0x8F25310", VA = "0x188F26910")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8F26820", Offset = "0x8F25220", VA = "0x188F26820")]
		private void LAKOJFVQUVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8F26900", Offset = "0x8F25300", VA = "0x188F26900")]
		private void NYJQTLFAGTZ(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8F26DC0", Offset = "0x8F257C0", VA = "0x188F26DC0")]
		public VideoPlayerController()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8F266B0", Offset = "0x8F250B0", VA = "0x188F266B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F0FDA0", Offset = "0x8F0E7A0", VA = "0x188F0FDA0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		private static IntPtr VWKUJWOFHED
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8F10330", Offset = "0x8F0ED30", VA = "0x188F10330")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8F0DCD0", Offset = "0x8F0C6D0", VA = "0x188F0DCD0")]
		public static extern IntPtr AddAmbisonicSourceInstance(int maxCoefficients);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8F0FD20", Offset = "0x8F0E720", VA = "0x188F0FD20")]
		public static extern void RemoveAmbisonicSourceInstance(IntPtr instance);

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8F100D0", Offset = "0x8F0EAD0", VA = "0x188F100D0")]
		public static extern void UpdateAmbisonicWeights(IntPtr instance, float azimuth, float elevation, AmbisonicOrder order, AmbisonicChannelOrder channelOrder, float[] normalisationWeights);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8F0E660", Offset = "0x8F0D060", VA = "0x188F0E660")]
		public static extern void EncodeMonoToAmbisonic(IntPtr instance, float[] inSamples, int inSamplesOffset, int inFrameCount, int inChannelCount, float[] outSamples, int outSamplesOffset, int outSamplesLength, AmbisonicOrder order);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8F10430", Offset = "0x8F0EE30", VA = "0x188F10430")]
		public static string XEHMYBMIWFB(PixelFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F8D0", Offset = "0x8F0E2D0", VA = "0x188F0F8D0")]
		public static void MBSORVJCSXX(PluginEvent a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F260", Offset = "0x8F0DC60", VA = "0x188F0F260")]
		private static extern IntPtr GetRenderEventFunc();

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F000", Offset = "0x8F0DA00", VA = "0x188F0F000")]
		private static extern IntPtr GetFreeResourcesEventFunc();

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F660", Offset = "0x8F0E060", VA = "0x188F0F660")]
		public static extern bool Init();

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8F0E2A0", Offset = "0x8F0CCA0", VA = "0x188F0E2A0")]
		public static extern void Deinit();

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8F0E1D0", Offset = "0x8F0CBD0", VA = "0x188F0E1D0")]
		public static string DFTVIUPHIVV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8F10500", Offset = "0x8F0EF00", VA = "0x188F10500")]
		public static bool XNSRBCPRZWP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F2D0", Offset = "0x8F0DCD0", VA = "0x188F0F2D0")]
		public static extern int GetVideoCodecCount();

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F750", Offset = "0x8F0E150", VA = "0x188F0F750")]
		public static extern bool IsConfigureVideoCodecSupported(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F340", Offset = "0x8F0DD40", VA = "0x188F0F340")]
		public static extern MediaApi GetVideoCodecMediaApi(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8F0DDD0", Offset = "0x8F0C7D0", VA = "0x188F0DDD0")]
		public static extern void ConfigureVideoCodec(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8F101B0", Offset = "0x8F0EBB0", VA = "0x188F101B0")]
		public static string WJADOGGVMGR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8F0E960", Offset = "0x8F0D360", VA = "0x188F0E960")]
		public static extern int GetAudioCodecCount();

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F6D0", Offset = "0x8F0E0D0", VA = "0x188F0F6D0")]
		public static extern bool IsConfigureAudioCodecSupported(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8F0E9D0", Offset = "0x8F0D3D0", VA = "0x188F0E9D0")]
		public static extern MediaApi GetAudioCodecMediaApi(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8F0DD50", Offset = "0x8F0C750", VA = "0x188F0DD50")]
		public static extern void ConfigureAudioCodec(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8F0E310", Offset = "0x8F0CD10", VA = "0x188F0E310")]
		public static string EIOXWRSYOGW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8F0EB20", Offset = "0x8F0D520", VA = "0x188F0EB20")]
		public static extern int GetAudioInputDeviceCount();

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8F0E7E0", Offset = "0x8F0D1E0", VA = "0x188F0E7E0")]
		public static string GIABIJBFMUO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8F0EB90", Offset = "0x8F0D590", VA = "0x188F0EB90")]
		public static extern MediaApi GetAudioInputDeviceMediaApi(int index);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F490", Offset = "0x8F0DE90", VA = "0x188F0F490")]
		public static string[] IJTZETUWLVG(int a, int b = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8F0E070", Offset = "0x8F0CA70", VA = "0x188F0E070")]
		public static extern int CreateRecorderVideo(string filename, uint width, uint height, float frameRate, int format, bool isRealTime, bool isTopDown, int videoCodecIndex, AudioCaptureSource audioSource, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool forceGpuFlush, VideoEncoderHints hints);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8F0DE50", Offset = "0x8F0C850", VA = "0x188F0DE50")]
		public static extern int CreateRecorderImages(string filename, uint width, uint height, float frameRate, int format, bool isRealTime, bool isTopDown, int imageFormatType, bool forceGpuFlush, int startFrame, ImageEncoderHints hints);

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8F0DF80", Offset = "0x8F0C980", VA = "0x188F0DF80")]
		public static extern int CreateRecorderPipe(string filename, uint width, uint height, float frameRate, int format, bool isTopDown, int transparencyMode, bool forceGpuFlush);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8F0FFC0", Offset = "0x8F0E9C0", VA = "0x188F0FFC0")]
		public static extern bool Start(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F850", Offset = "0x8F0E250", VA = "0x188F0F850")]
		public static extern bool IsNewFrameDue(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8F0FEA0", Offset = "0x8F0E8A0", VA = "0x188F0FEA0")]
		public static extern int SetEncodedFrameLimit(int handle, uint encodedFrameLimit);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8F0E5D0", Offset = "0x8F0CFD0", VA = "0x188F0E5D0")]
		public static extern void EncodeFrame(int handle, IntPtr data);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8F0E490", Offset = "0x8F0CE90", VA = "0x188F0E490")]
		public static extern void EncodeAudio(int handle, IntPtr data, uint length);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8F0E530", Offset = "0x8F0CF30", VA = "0x188F0E530")]
		public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength);

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8F0FCA0", Offset = "0x8F0E6A0", VA = "0x188F0FCA0")]
		public static extern void Pause(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8F10040", Offset = "0x8F0EA40", VA = "0x188F10040")]
		public static extern void Stop(int handle, bool skipPendingFrames);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F7D0", Offset = "0x8F0E1D0", VA = "0x188F0F7D0")]
		public static extern bool IsFileWritingComplete(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160")]
		public static bool KEGJQAXCBQO(int a, StringBuilder b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8F0FF30", Offset = "0x8F0E930", VA = "0x188F0FF30")]
		public static extern void SetTexturePointer(int handle, IntPtr texture);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8F0E760", Offset = "0x8F0D160", VA = "0x188F0E760")]
		public static extern void FreeRecorder(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F0F0", Offset = "0x8F0DAF0", VA = "0x188F0F0F0")]
		public static extern uint GetNumDroppedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F070", Offset = "0x8F0DA70", VA = "0x188F0F070")]
		public static extern uint GetNumDroppedEncoderFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F170", Offset = "0x8F0DB70", VA = "0x188F0F170")]
		public static extern uint GetNumEncodedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8F0EF80", Offset = "0x8F0D980", VA = "0x188F0EF80")]
		public static extern float GetEncodedSeconds(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8F0ECE0", Offset = "0x8F0D6E0", VA = "0x188F0ECE0")]
		public static extern uint GetBufferSize(int handle);

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8F0ED60", Offset = "0x8F0D760", VA = "0x188F0ED60")]
		public static extern uint GetBufferedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F1F0", Offset = "0x8F0DBF0", VA = "0x188F0F1F0")]
		private static extern IntPtr GetPluginVersion();

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8F0F3C0", Offset = "0x8F0DDC0", VA = "0x188F0F3C0")]
		private static extern bool GetVideoCodecName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8F0EA50", Offset = "0x8F0D450", VA = "0x188F0EA50")]
		private static extern bool GetAudioCodecName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8F0EC10", Offset = "0x8F0D610", VA = "0x188F0EC10")]
		private static extern bool GetAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8F0EDE0", Offset = "0x8F0D7E0", VA = "0x188F0EDE0")]
		private static extern bool GetContainerFileExtensions(int videoCodecIndex, int audioCodecIndex, StringBuilder extensions, int extensionsBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8F0EEC0", Offset = "0x8F0D8C0", VA = "0x188F0EEC0")]
		private static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, [Out] ulong lpFreeBytesAvailable, [Out] ulong lpTotalNumberOfBytes, [Out] ulong lpTotalNumberOfFreeBytes);

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8F0FB40", Offset = "0x8F0E540", VA = "0x188F0FB40")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F226F0", Offset = "0x8F210F0", VA = "0x188F226F0")]
			public void TEAYJJRIFOJ(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static float[] BKMFECEIBSG;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static float[] FTYNRVBYKMT;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8F20570", Offset = "0x8F1EF70", VA = "0x188F20570")]
		public static float[] HUCHNKEMOBW(AmbisonicNormalisation a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8F20600", Offset = "0x8F1F000", VA = "0x188F20600")]
		public static int KEAFPXPDCMZ(AmbisonicOrder a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8F205F0", Offset = "0x8F1EFF0", VA = "0x188F205F0")]
		public static AmbisonicChannelOrder VLAUKGFFHTC(AmbisonicFormat a)
		{
			return default(AmbisonicChannelOrder);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8F205F0", Offset = "0x8F1EFF0", VA = "0x188F205F0")]
		public static AmbisonicNormalisation IHLFAQVEEAP(AmbisonicFormat a)
		{
			return default(AmbisonicNormalisation);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8F20C60", Offset = "0x8F1F660", VA = "0x188F20C60")]
		static LZPYGPMTVJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8F201C0", Offset = "0x8F1EBC0", VA = "0x188F201C0")]
		private static float[] BDRJIRRIVEV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8F204F0", Offset = "0x8F1EEF0", VA = "0x188F204F0")]
		private static int GDUNUCSFBKZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8F20490", Offset = "0x8F1EE90", VA = "0x188F20490")]
		private static int GDETCIKMZCY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8F20C40", Offset = "0x8F1F640", VA = "0x188F20C40")]
		private static int ZAEQPRTQIGG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8F20A50", Offset = "0x8F1F450", VA = "0x188F20A50")]
		private static float VYLWJUGOEVX(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8F208E0", Offset = "0x8F1F2E0", VA = "0x188F208E0")]
		private static float VYLWJUGOEVX(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8F20630", Offset = "0x8F1F030", VA = "0x188F20630")]
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
			[Cpp2IlInjected.Address(RVA = "0xB076C0", Offset = "0xB060C0", VA = "0x180B076C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public uint DPUZVETWAZB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public uint REBCMOMFYON
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public uint CPLEDIYNHDV
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float NQMUSCMPLBO
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xB06870", Offset = "0xB05270", VA = "0x180B06870")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x11404B0", Offset = "0x113EEB0", VA = "0x1811404B0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		internal uint RNDCCADHAOR
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		internal uint TGNGGRYPNPK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public AudioCaptureSource MMAKCIJHMFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xB05490", Offset = "0xB03E90", VA = "0x180B05490")]
			get
			{
				return default(AudioCaptureSource);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1419A90", Offset = "0x1418490", VA = "0x181419A90")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public int XCYFRMPUIJI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xAE61A0", Offset = "0xAE4BA0", VA = "0x180AE61A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xB4C210", Offset = "0xB4AC10", VA = "0x180B4C210")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int YHKQFUFXCRS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xAF67D0", Offset = "0xAF51D0", VA = "0x180AF67D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xAF5EA0", Offset = "0xAF48A0", VA = "0x180AF5EA0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8F10BA0", Offset = "0x8F0F5A0", VA = "0x188F10BA0")]
		internal void RBBNDWLPHYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8F10B50", Offset = "0x8F0F550", VA = "0x188F10B50")]
		internal void OTPPRFELUPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x77910C0", Offset = "0x778FAC0", VA = "0x1877910C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F26040", Offset = "0x8F24A40", VA = "0x188F26040")]
		public VideoEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8F25FE0", Offset = "0x8F249E0", VA = "0x188F25FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F20000", Offset = "0x8F1EA00", VA = "0x188F20000")]
		public ImageEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8F1FFE0", Offset = "0x8F1E9E0", VA = "0x188F1FFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F1FB50", Offset = "0x8F1E550", VA = "0x188F1FB50")]
		public EncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8F1FA40", Offset = "0x8F1E440", VA = "0x188F1FA40")]
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
			[Cpp2IlInjected.Address(RVA = "0x1502AE0", Offset = "0x15014E0", VA = "0x181502AE0")]
			get
			{
				return default(OutputTarget);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1502660", Offset = "0x1501060", VA = "0x181502660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public OutputPath CWORZHHWABE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xE0C520", Offset = "0xE0AF20", VA = "0x180E0C520")]
			get
			{
				return default(OutputPath);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x19478D0", Offset = "0x19462D0", VA = "0x1819478D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string WZACIHSUAND
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC39190", VA = "0x180C3A790")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xC3AF40", Offset = "0xC39940", VA = "0x180C3AF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string ICVOCBHEEMK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xCAF600", Offset = "0xCAE000", VA = "0x180CAF600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1463A40", Offset = "0x1462440", VA = "0x181463A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool CSRCIRQGLZA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xCC2790", Offset = "0xCC1190", VA = "0x180CC2790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2188190", Offset = "0x2186B90", VA = "0x182188190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool WIDKRRTZFKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xDE9D60", Offset = "0xDE8760", VA = "0x180DE9D60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1DBD0B0", Offset = "0x1DBBAB0", VA = "0x181DBD0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string GIZSKUNSMST
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xCAF5C0", Offset = "0xCADFC0", VA = "0x180CAF5C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x143F290", Offset = "0x143DC90", VA = "0x18143F290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string LSECWFODGHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xC042D0", Offset = "0xC02CD0", VA = "0x180C042D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xC07180", Offset = "0xC05B80", VA = "0x180C07180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool NWOSRGISBKV
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xBBA470", Offset = "0xBB8E70", VA = "0x180BBA470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xBBA1A0", Offset = "0xBB8BA0", VA = "0x180BBA1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int MPSJCMSCFGU
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1F127C0", Offset = "0x1F111C0", VA = "0x181F127C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x206EE00", Offset = "0x206D800", VA = "0x18206EE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int PGFPSDPWNXT
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1004410", Offset = "0x1002E10", VA = "0x181004410")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A100", Offset = "0x8F18B00", VA = "0x188F1A100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool QRXXXNDDUHD
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x18F1F20", Offset = "0x18F0920", VA = "0x1818F1F20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A1E0", Offset = "0x8F18BE0", VA = "0x188F1A1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int AFJPAIDFEUH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xD82FC0", Offset = "0xD819C0", VA = "0x180D82FC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A170", Offset = "0x8F18B70", VA = "0x188F1A170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Camera[] YCQOZNKFJVS
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xCAF710", Offset = "0xCAE110", VA = "0x180CAF710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x12C1AA0", Offset = "0x12C04A0", VA = "0x1812C1AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MotionBlur VRQANGQBHLS
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xD83700", Offset = "0xD82100", VA = "0x180D83700")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xC05860", Offset = "0xC04260", VA = "0x180C05860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Transparency FEGEMGTVWDP
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x25C8770", Offset = "0x25C7170", VA = "0x1825C8770")]
			get
			{
				return default(Transparency);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static HashSet<string> OVKVRMIJGSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8F19F80", Offset = "0x8F18980", VA = "0x188F19F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string XBWEEKGAHAS
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xCAF740", Offset = "0xCAE140", VA = "0x180CAF740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public UnityEvent XHJMGXWBJAU
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xCAF550", Offset = "0xCADF50", VA = "0x180CAF550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public UnityEvent EGIZQEOOXTK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xCAF590", Offset = "0xCADF90", VA = "0x180CAF590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Action<AZAKQZVMAMJ> WHVRUHRMBHK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xCAF5B0", Offset = "0xCADFB0", VA = "0x180CAF5B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x136EBA0", Offset = "0x136D5A0", VA = "0x18136EBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Action<AZAKQZVMAMJ> AFUVWODWFQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xCAF570", Offset = "0xCADF70", VA = "0x180CAF570")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x137DFE0", Offset = "0x137C9E0", VA = "0x18137DFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Resolution RKFMCVEVWFM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1F127D0", Offset = "0x1F111D0", VA = "0x181F127D0")]
			get
			{
				return default(Resolution);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A0B0", Offset = "0x8F18AB0", VA = "0x188F1A0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector2 WJOKFBMGJXT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x8F19FD0", Offset = "0x8F189D0", VA = "0x188F19FD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x22E2C90", Offset = "0x22E1690", VA = "0x1822E2C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int UJZFWWWXGPS
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x18F1F60", Offset = "0x18F0960", VA = "0x1818F1F60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x21ED560", Offset = "0x21EBF60", VA = "0x1821ED560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool ZPHPVSDAJDI
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x16EFDD0", Offset = "0x16EE7D0", VA = "0x1816EFDD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x16EFDE0", Offset = "0x16EE7E0", VA = "0x1816EFDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool ZRBNTMWAIEN
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x242DAB0", Offset = "0x242C4B0", VA = "0x18242DAB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x242DC30", Offset = "0x242C630", VA = "0x18242DC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public AudioCaptureSource MMAKCIJHMFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xB2FD80", Offset = "0xB2E780", VA = "0x180B2FD80")]
			get
			{
				return default(AudioCaptureSource);
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x16D2E60", Offset = "0x16D1860", VA = "0x1816D2E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int AHRSLEIXOEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1CAC300", Offset = "0x1CAAD00", VA = "0x181CAC300")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x23E35F0", Offset = "0x23E1FF0", VA = "0x1823E35F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int WHJDMIZQJJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x10045A0", Offset = "0x1002FA0", VA = "0x1810045A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1502200", Offset = "0x1500C00", VA = "0x181502200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public UnityAudioCapture CNTFCEEAPLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xCAF650", Offset = "0xCAE050", VA = "0x180CAF650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xE39090", Offset = "0xE37A90", VA = "0x180E39090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int KBBZUVVUIUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xE38690", Offset = "0xE37090", VA = "0x180E38690")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A0C0", Offset = "0x8F18AC0", VA = "0x188F1A0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float GFPVYBWTTTI
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x13BB410", Offset = "0x13B9E10", VA = "0x1813BB410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A0D0", Offset = "0x8F18AD0", VA = "0x188F1A0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public StartTriggerMode QWSNERFVITB
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xD28600", Offset = "0xD27000", VA = "0x180D28600")]
			get
			{
				return default(StartTriggerMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xD28610", Offset = "0xD27010", VA = "0x180D28610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public StartDelayMode JXUQGWUYUGI
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x13C3A10", Offset = "0x13C2410", VA = "0x1813C3A10")]
			get
			{
				return default(StartDelayMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x19AA940", Offset = "0x19A9340", VA = "0x1819AA940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float ETPJAMIBPOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xB05C30", Offset = "0xB04630", VA = "0x180B05C30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A1A0", Offset = "0x8F18BA0", VA = "0x188F1A1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public StopMode SPVEPKKVOQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1075B70", Offset = "0x1074570", VA = "0x181075B70")]
			get
			{
				return default(StopMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1EBB250", Offset = "0x1EB9C50", VA = "0x181EBB250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int OJTSVAZSAVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xC38D30", Offset = "0xC37730", VA = "0x180C38D30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A1B0", Offset = "0x8F18BB0", VA = "0x188F1A1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public float YGPQNYARJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x1004590", Offset = "0x1002F90", VA = "0x181004590")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A1C0", Offset = "0x8F18BC0", VA = "0x188F1A1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool PWJGCYMRQGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xABECB0", Offset = "0xABD6B0", VA = "0x180ABECB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xABF580", Offset = "0xABDF80", VA = "0x180ABF580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public CMOMMWCOHKG CMOMMWCOHKG
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xCAF560", Offset = "0xCADF60", VA = "0x180CAF560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string[] WDJEGTIAGBT
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A230", Offset = "0x8F18C30", VA = "0x188F1A230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string[] ZLVNGBGXOCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5130", Offset = "0xAB3B30", VA = "0x180AB5130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A200", Offset = "0x8F18C00", VA = "0x188F1A200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string[] BRHYSXPXOCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xABA270", Offset = "0xAB8C70", VA = "0x180ABA270")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A080", Offset = "0x8F18A80", VA = "0x188F1A080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string[] MIWBPGIUJSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xABA870", Offset = "0xAB9270", VA = "0x180ABA870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A050", Offset = "0x8F18A50", VA = "0x188F1A050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int GMQAYNCYOXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2B7CF90", Offset = "0x2B7B990", VA = "0x182B7CF90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x76A3B60", Offset = "0x76A2560", VA = "0x1876A3B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public FrameUpdateMode QTYGYVJNXOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xABA1B0", Offset = "0xAB8BB0", VA = "0x180ABA1B0")]
			get
			{
				return default(FrameUpdateMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xABA880", Offset = "0xAB9280", VA = "0x180ABA880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public DownScale XQWOROSZUAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xB0F010", Offset = "0xB0DA10", VA = "0x180B0F010")]
			get
			{
				return default(DownScale);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xC8CA40", Offset = "0xC8B440", VA = "0x180C8CA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 KBVVCYJNDSO
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x27F3060", Offset = "0x27F1A60", VA = "0x1827F3060")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7613160", Offset = "0x7611B60", VA = "0x187613160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool BHSBUPKHZIF
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xB5A380", Offset = "0xB58D80", VA = "0x180B5A380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xB5A4E0", Offset = "0xB58EE0", VA = "0x180B5A4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool EBIARBQOGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x8112FE0", Offset = "0x81119E0", VA = "0x188112FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A1F0", Offset = "0x8F18BF0", VA = "0x188F1A1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool OKKUAYCITWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x27FE1C0", Offset = "0x27FCBC0", VA = "0x1827FE1C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x27FE700", Offset = "0x27FD100", VA = "0x1827FE700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool BVFGSURLBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xD3B290", Offset = "0xD39C90", VA = "0x180D3B290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xD3B2A0", Offset = "0xD39CA0", VA = "0x180D3B2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool IERBSQTMXTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A040", Offset = "0x8F18A40", VA = "0x188F1A040")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A1D0", Offset = "0x8F18BD0", VA = "0x188F1A1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public TimelineController NODOFDMODDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xC07700", Offset = "0xC06100", VA = "0x180C07700")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xC077D0", Offset = "0xC061D0", VA = "0x180C077D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public VideoPlayerController BEVJFFHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xCAF490", Offset = "0xCADE90", VA = "0x180CAF490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xDC3F10", Offset = "0xDC2910", VA = "0x180DC3F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Codec BWTXBDUFHCB
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xCAF750", Offset = "0xCAE150", VA = "0x180CAF750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Codec FMDROWRIPJI
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xCAF540", Offset = "0xCADF40", VA = "0x180CAF540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public GDHOCVPKMLL HHYXNIKIGEK
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xCAF530", Offset = "0xCADF30", VA = "0x180CAF530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int KIODATIJGGA
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x1260420", Offset = "0x125EE20", VA = "0x181260420")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x125FD00", Offset = "0x125E700", VA = "0x18125FD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int KPXKNFYMHDD
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xC30A00", Offset = "0xC2F400", VA = "0x180C30A00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x1FE48B0", Offset = "0x1FE32B0", VA = "0x181FE48B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public ImageSequenceFormat RVGPYKHXFMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x15AD710", Offset = "0x15AC110", VA = "0x1815AD710")]
			get
			{
				return default(ImageSequenceFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x206EE80", Offset = "0x206D880", VA = "0x18206EE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public static string QNDNBNGTUEM
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x8F19FF0", Offset = "0x8F189F0", VA = "0x188F19FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8F1A130", Offset = "0x8F18B30", VA = "0x188F1A130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980")]
		protected static CLTPEDTEBJF.Platform IWFYVJEVISN()
		{
			return default(CLTPEDTEBJF.Platform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8F12B40", Offset = "0x8F11540", VA = "0x188F12B40")]
		public EncoderHints GetEncoderHints(CLTPEDTEBJF.Platform platform = CLTPEDTEBJF.Platform.Current)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8F17350", Offset = "0x8F15D50", VA = "0x188F17350")]
		public void SetEncoderHints(EncoderHints hints, CLTPEDTEBJF.Platform platform = CLTPEDTEBJF.Platform.Current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970")]
		public static void UpdateMediaGallery(string videoFilePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8F10E50", Offset = "0x8F0F850", VA = "0x188F10E50", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8F19280", Offset = "0x8F17C80", VA = "0x188F19280")]
		static CaptureBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8F17900", Offset = "0x8F16300", VA = "0x188F17900", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8F10BB0", Offset = "0x8F0F5B0", VA = "0x188F10BB0")]
		private static bool APEUWVNZOXV(Codec a, TYHNIYOIMYT b, int c, string[] d, MediaApi e, bool f, bool g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8F17030", Offset = "0x8F15A30", VA = "0x188F17030")]
		public Codec SelectVideoCodec(bool isStartingCapture = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8F16990", Offset = "0x8F15390", VA = "0x188F16990")]
		public Codec SelectAudioCodec()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8F16D00", Offset = "0x8F15700", VA = "0x188F16D00")]
		public GDHOCVPKMLL SelectAudioInputDevice()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8F12CB0", Offset = "0x8F116B0", VA = "0x188F12CB0")]
		public static Vector2 GetRecordingResolution(int width, int height, DownScale downscale, Vector2 maxVideoSize)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8F16F20", Offset = "0x8F15920", VA = "0x188F16F20")]
		public void SelectRecordingResolution(int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8F14350", Offset = "0x8F12D50", VA = "0x188F14350", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8F14580", Offset = "0x8F12F80", VA = "0x188F14580")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8F13270", Offset = "0x8F11C70", VA = "0x188F13270")]
		private void JVYZEBLIVTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8F14300", Offset = "0x8F12D00", VA = "0x188F14300")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8F129D0", Offset = "0x8F113D0", VA = "0x188F129D0")]
		protected void GFLSIAXTWAA(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8F16510", Offset = "0x8F14F10", VA = "0x188F16510")]
		protected bool QWBVDRLWGLB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8F11D50", Offset = "0x8F10750", VA = "0x188F11D50")]
		protected bool CIIADWHRKQO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8F12310", Offset = "0x8F10D10", VA = "0x188F12310", Slot = "7")]
		public virtual void EncodePointer(IntPtr ptr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8F13260", Offset = "0x8F11C60", VA = "0x188F13260")]
		public bool IsPrepared()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xE0CFA0", Offset = "0xE0B9A0", VA = "0x180E0CFA0")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xE0E6F0", Offset = "0xE0D0F0", VA = "0x180E0E6F0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8F12D80", Offset = "0x8F11780", VA = "0x188F12D80")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x21E5C20", Offset = "0x21E4620", VA = "0x1821E5C20")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8F13F20", Offset = "0x8F12920", VA = "0x188F13F20", Slot = "8")]
		protected virtual string OXQDXZIPAAY(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8F11410", Offset = "0x8F0FE10", VA = "0x188F11410")]
		private static string BZYGQRJQHVH(OutputPath a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8F16640", Offset = "0x8F15040", VA = "0x188F16640")]
		private static string RBWLJAVKYJP(OutputPath a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8F13220", Offset = "0x8F11C20", VA = "0x188F13220")]
		protected static bool IUFCKIRQZLE(string a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8F115B0", Offset = "0x8F0FFB0", VA = "0x188F115B0")]
		protected void CAXITKDIKQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8F12570", Offset = "0x8F10F70", VA = "0x188F12570")]
		public UnityAudioCapture FindOrCreateUnityAudioCapture(bool logWarnings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8F134D0", Offset = "0x8F11ED0", VA = "0x188F134D0")]
		private bool LXZAGPOOEBM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8F14910", Offset = "0x8F13310", VA = "0x188F14910", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8F16590", Offset = "0x8F14F90", VA = "0x188F16590")]
		public void QueueStartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xE0EB90", Offset = "0xE0D590", VA = "0x180E0EB90")]
		public bool IsStartCaptureQueued()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8F19010", Offset = "0x8F17A10", VA = "0x188F19010")]
		protected void YZIQOXJISMH(StereoPacking a, SphericalVideoLayout b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8F173F0", Offset = "0x8F15DF0", VA = "0x188F173F0")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8F146D0", Offset = "0x8F130D0", VA = "0x188F146D0")]
		public void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8F16850", Offset = "0x8F15250", VA = "0x188F16850")]
		public void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8F11DC0", Offset = "0x8F107C0", VA = "0x188F11DC0")]
		public void CancelCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8F11E30", Offset = "0x8F10830", VA = "0x188F11E30")]
		public static void DeleteCapture(OutputTarget outputTarget, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8F13E90", Offset = "0x8F12890", VA = "0x188F13E90")]
		protected void MBSORVJCSXX(CLTPEDTEBJF.PluginEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8F179C0", Offset = "0x8F163C0", VA = "0x188F179C0", Slot = "11")]
		public virtual void StopCapture(bool skipPendingFrames = false, bool ignorePendingFileWrites = false, bool deleteCapture = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8F18B10", Offset = "0x8F17510", VA = "0x188F18B10")]
		private static EZIWLMAMTBF.Options VZNEXKTDYCP(VideoEncoderHints a, string b)
		{
			return default(EZIWLMAMTBF.Options);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8F11F40", Offset = "0x8F10940", VA = "0x188F11F40")]
		private static bool ERXZXXOKVWB(string a, VideoEncoderHints b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8F18810", Offset = "0x8F17210", VA = "0x188F18810")]
		protected void VLNLFVSTJLL(string a, VideoEncoderHints b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8F113D0", Offset = "0x8F0FDD0", VA = "0x188F113D0")]
		private void BRSRBROJZEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8F189F0", Offset = "0x8F173F0", VA = "0x188F189F0")]
		private bool VMMALJXREPS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8F18BA0", Offset = "0x8F175A0", VA = "0x188F18BA0")]
		protected bool WCQPRTEDMKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8F187B0", Offset = "0x8F171B0", VA = "0x188F187B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8F13B30", Offset = "0x8F12530", VA = "0x188F13B30")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8F13410", Offset = "0x8F11E10", VA = "0x188F13410")]
		private void LQLCAQEXFVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8F182B0", Offset = "0x8F16CB0", VA = "0x188F182B0")]
		private void UGGALSQCUKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8F133E0", Offset = "0x8F11DE0", VA = "0x188F133E0")]
		protected bool LIFZQUPXDUL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8F181D0", Offset = "0x8F16BD0", VA = "0x188F181D0")]
		protected bool UFJSAOZBCZS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8F12BF0", Offset = "0x8F115F0", VA = "0x188F12BF0")]
		public float GetProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8F13EF0", Offset = "0x8F128F0", VA = "0x188F13EF0")]
		protected float ORESVKJBJQS()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8F190A0", Offset = "0x8F17AA0", VA = "0x188F190A0")]
		protected bool ZXYXPYPDTVV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8F11DF0", Offset = "0x8F107F0", VA = "0x188F11DF0")]
		protected void DEVSNQFNGWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8F16940", Offset = "0x8F15340", VA = "0x188F16940")]
		protected void SFFNKWTWXDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xCAF6A0", Offset = "0xCAE0A0", VA = "0x180CAF6A0", Slot = "13")]
		public virtual Texture GetSideBySideTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8F14610", Offset = "0x8F13010", VA = "0x188F14610")]
		protected void PRUHYAWKMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8F12260", Offset = "0x8F10C60", VA = "0x188F12260")]
		public void EncodeAudio(NativeArray<float> audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8F12140", Offset = "0x8F10B40", VA = "0x188F12140")]
		public void EncodeAudio(float[] audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8F14810", Offset = "0x8F13210", VA = "0x188F14810", Slot = "14")]
		public virtual void PreUpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8F183B0", Offset = "0x8F16DB0", VA = "0x188F183B0", Slot = "15")]
		public virtual void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8F18C50", Offset = "0x8F17650", VA = "0x188F18C50")]
		protected bool XITVRIDSBXZ(int a, int b, bool c = false, int d = 1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8F12F10", Offset = "0x8F11910", VA = "0x188F12F10")]
		protected RenderTexture HWRMWSJGAZM(Texture a, bool b = false, int c = 1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8F16610", Offset = "0x8F15010", VA = "0x188F16610")]
		protected void RBBNDWLPHYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8F18350", Offset = "0x8F16D50", VA = "0x188F18350")]
		public void UpdateFPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8F130D0", Offset = "0x8F11AD0", VA = "0x188F130D0")]
		protected int IOKHQFLQFJS(Camera a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8F12A50", Offset = "0x8F11450", VA = "0x188F12A50")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8F12D90", Offset = "0x8F11790", VA = "0x188F12D90")]
		public static void GetResolution(Resolution res, int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8F133D0", Offset = "0x8F11DD0", VA = "0x188F133D0")]
		protected static int LGQUMFHVGFX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8F19AC0", Offset = "0x8F184C0", VA = "0x188F19AC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public MediaApi FEMQAYYZYJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30", Slot = "6")]
			get
			{
				return default(MediaApi);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool BTPCYUFIQQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xABF560", Offset = "0xABDF60", VA = "0x180ABF560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8F1A260", Offset = "0x8F18C60", VA = "0x188F1A260")]
		public void KDLJYYFSUMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8F1A3C0", Offset = "0x8F18DC0", VA = "0x188F1A3C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public int QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x2519530", Offset = "0x2517F30", VA = "0x182519530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8F240C0", Offset = "0x8F22AC0", VA = "0x188F240C0")]
		internal TYHNIYOIMYT(Codec[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8F24020", Offset = "0x8F22A20", VA = "0x188F24020")]
		public Codec YJBEYHDOBBU(string a, MediaApi b = MediaApi.Unknown)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8F23FC0", Offset = "0x8F229C0", VA = "0x188F23FC0")]
		public Codec MPSXBNVHQEZ(MediaApi a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x28161F0", Offset = "0x2814BF0", VA = "0x1828161F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F23510", Offset = "0x8F21F10", VA = "0x188F23510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public static TYHNIYOIMYT TWOWIIAEYXW
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x8F234C0", Offset = "0x8F21EC0", VA = "0x188F234C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8F23560", Offset = "0x8F21F60", VA = "0x188F23560")]
		private static void VWBIYFDBAUD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8F23600", Offset = "0x8F22000", VA = "0x188F23600")]
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
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public MediaApi FEMQAYYZYJV
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0", Slot = "6")]
			get
			{
				return default(MediaApi);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8F1FE90", Offset = "0x8F1E890", VA = "0x188F1FE90")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public int QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x2519530", Offset = "0x2517F30", VA = "0x182519530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8F22680", Offset = "0x8F21080", VA = "0x188F22680")]
		internal PCKLZRPINZX(GDHOCVPKMLL[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8F22620", Offset = "0x8F21020", VA = "0x188F22620")]
		public GDHOCVPKMLL MPSXBNVHQEZ(MediaApi a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x28161F0", Offset = "0x2814BF0", VA = "0x1828161F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F0CE80", Offset = "0x8F0B880", VA = "0x188F0CE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF60", Offset = "0x8F0B960", VA = "0x188F0CF60")]
		private static void VWBIYFDBAUD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8F0D000", Offset = "0x8F0BA00", VA = "0x188F0D000")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5400", Offset = "0xAB3E00", VA = "0x180AB5400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8F0DC50", Offset = "0x8F0C650", VA = "0x188F0DC50")]
		internal AZAKQZVMAMJ(OutputTarget a, string b, int c, bool d, string e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8F0D510", Offset = "0x8F0BF10", VA = "0x188F0D510")]
		internal void BEQSBDNLXRI(EZIWLMAMTBF.Options a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8F0D530", Offset = "0x8F0BF30", VA = "0x188F0D530")]
		private bool DMWAMFJUJAU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8F0DA90", Offset = "0x8F0C490", VA = "0x188F0DA90")]
		public bool UXAIGMJLRDG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8F0D7A0", Offset = "0x8F0C1A0", VA = "0x188F0D7A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F22600", Offset = "0x8F21000", VA = "0x188F22600")]
			public bool SEGFLMJZDXX()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x8F225E0", Offset = "0x8F20FE0", VA = "0x188F225E0")]
			public bool RPEYGLBXUBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x8F225C0", Offset = "0x8F20FC0", VA = "0x188F225C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public HXGPKBFCMYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x8F1FEF0", Offset = "0x8F1E8F0", VA = "0x188F1FEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F1AFB0", Offset = "0x8F199B0", VA = "0x188F1AFB0")]
		public static ManualResetEvent EZMAITLQMCO(string a, bool b, Options c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8F1B450", Offset = "0x8F19E50", VA = "0x188F1B450")]
		public static bool FBUFBHANIEO(string a, bool b, Options c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x8F1B170", Offset = "0x8F19B70", VA = "0x188F1B170")]
		public static bool FBUFBHANIEO(string a, string b, Options c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8F1F970", Offset = "0x8F1E370", VA = "0x188F1F970")]
		public EZIWLMAMTBF(Options a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8F1D0F0", Offset = "0x8F1BAF0", VA = "0x188F1D0F0")]
		public bool SNLVHQAMKMI(Stream a, Stream b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8F1AAC0", Offset = "0x8F194C0", VA = "0x188F1AAC0")]
		public void Close()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8F1E110", Offset = "0x8F1CB10", VA = "0x188F1E110")]
		private static YMSCKGXVXEE WCRRXEFWRDF(uint a, List<YMSCKGXVXEE> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8F1C420", Offset = "0x8F1AE20", VA = "0x188F1C420")]
		private List<YMSCKGXVXEE> NFBQDPCQLWV(YMSCKGXVXEE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8F1C4F0", Offset = "0x8F1AEF0", VA = "0x188F1C4F0")]
		private List<YMSCKGXVXEE> NFBQDPCQLWV(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8F1A8E0", Offset = "0x8F192E0", VA = "0x188F1A8E0")]
		private YMSCKGXVXEE CAALJGONSKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8F1A780", Offset = "0x8F19180", VA = "0x188F1A780")]
		private bool AOOBDGSTQLB(YMSCKGXVXEE a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8F1CFF0", Offset = "0x8F1B9F0", VA = "0x188F1CFF0")]
		private void ONYCASLCRBV(YMSCKGXVXEE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8F1AF40", Offset = "0x8F19940", VA = "0x188F1AF40")]
		private void EYRDFZQVONE(YMSCKGXVXEE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x8F1E6E0", Offset = "0x8F1D0E0", VA = "0x188F1E6E0")]
		private void YWAQHWFDNHA(YMSCKGXVXEE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8F1CB70", Offset = "0x8F1B570", VA = "0x188F1CB70")]
		private void NVBIEMPQUDL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8F1A420", Offset = "0x8F18E20", VA = "0x188F1A420")]
		private void AAZOQTPXACZ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8F1DB30", Offset = "0x8F1C530", VA = "0x188F1DB30")]
		private uint WAJQGJNJWCP(YMSCKGXVXEE a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8F1ABA0", Offset = "0x8F195A0", VA = "0x188F1ABA0")]
		private bool DYCTCYVXOKF(YMSCKGXVXEE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8F1B7A0", Offset = "0x8F1A1A0", VA = "0x188F1B7A0")]
		private void FYNKSKPTWZD(YMSCKGXVXEE a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8F1E450", Offset = "0x8F1CE50", VA = "0x188F1E450")]
		private void XHTKTZPTONV(YMSCKGXVXEE a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8F1D920", Offset = "0x8F1C320", VA = "0x188F1D920")]
		private void VNHKZGKDJVG(YMSCKGXVXEE a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8F1AD90", Offset = "0x8F19790", VA = "0x188F1AD90")]
		private uint EJIJDPGNARN(YMSCKGXVXEE a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8F1E850", Offset = "0x8F1D250", VA = "0x188F1E850")]
		private uint ZYNHYOCVJNO(YMSCKGXVXEE a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8F1D0D0", Offset = "0x8F1BAD0", VA = "0x188F1D0D0")]
		private static StereoMode_st3d RXWXWCQKQGC(StereoPacking a)
		{
			return default(StereoMode_st3d);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8F1C110", Offset = "0x8F1AB10", VA = "0x188F1C110")]
		private uint KJASERQIDAQ(StereoMode_st3d a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8F1E250", Offset = "0x8F1CC50", VA = "0x188F1E250")]
		private uint XDQXLGRZUOK(SphericalVideoLayout a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8F1C700", Offset = "0x8F1B100", VA = "0x188F1C700")]
		private uint NPDZFGVBXYQ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x8F1A4E0", Offset = "0x8F18EE0", VA = "0x188F1A4E0")]
		private uint AMKOQTWQWCJ(string a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8F1BE10", Offset = "0x8F1A810", VA = "0x188F1BE10")]
		private uint IBEIDDIZCQP(SphericalVideoLayout a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8F1CC90", Offset = "0x8F1B690", VA = "0x188F1CC90")]
		private uint OGUTUFLVNZA()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8F1BA40", Offset = "0x8F1A440", VA = "0x188F1BA40")]
		private uint HMRYXALOJSY()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8F1C000", Offset = "0x8F1AA00", VA = "0x188F1C000")]
		private void JQNKWHJEJKU(YMSCKGXVXEE a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8F1E7E0", Offset = "0x8F1D1E0", VA = "0x188F1E7E0")]
		private ushort ZIISGIMBRLC()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8F1C280", Offset = "0x8F1AC80", VA = "0x188F1C280")]
		private uint LNMUZGIQBZM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8F1D060", Offset = "0x8F1BA60", VA = "0x188F1D060")]
		private ulong RLVSKYXDLPL()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8F1E660", Offset = "0x8F1D060", VA = "0x188F1E660")]
		private void XIUPZTLHSMW(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8F1C2F0", Offset = "0x8F1ACF0", VA = "0x188F1C2F0")]
		private void MWIXNBSGLDR(uint a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8F1B9B0", Offset = "0x8F1A3B0", VA = "0x188F1B9B0")]
		private void GRNNLAQZLOQ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x8F1C390", Offset = "0x8F1AD90", VA = "0x188F1C390")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F25B50", Offset = "0x8F24550", VA = "0x188F25B50")]
		public static string[] UJCXKHYWRRZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8F257F0", Offset = "0x8F241F0", VA = "0x188F257F0")]
		public static RenderTextureFormat QBHGEBHDFXP(bool a, bool b, bool c)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8F250C0", Offset = "0x8F23AC0", VA = "0x188F250C0")]
		public static bool IBLUMSIXMFJ(Camera a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8F25350", Offset = "0x8F23D50", VA = "0x188F25350")]
		public static Camera[] OZNOYSCUGXS(Camera a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8F25BC0", Offset = "0x8F245C0", VA = "0x188F25BC0")]
		public static bool WDDOCHYRZXM(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x8F24F20", Offset = "0x8F23920", VA = "0x188F24F20")]
		public static bool ANNFFZCMIVG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8F25160", Offset = "0x8F23B60", VA = "0x188F25160")]
		public static bool MPGMDWRBNTI(string a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8F25010", Offset = "0x8F23A10", VA = "0x188F25010")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F233D0", Offset = "0x8F21DD0", VA = "0x188F233D0")]
		public QKUPCXLAKFC(string a, int b, int c, SampleFormat d = SampleFormat.Float32)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8F227E0", Offset = "0x8F211E0", VA = "0x188F227E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8F22860", Offset = "0x8F21260", VA = "0x188F22860")]
		public void IASRIRWQKRD(float[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8F229F0", Offset = "0x8F213F0", VA = "0x188F229F0")]
		public void NWZHUJIIDJR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8F23030", Offset = "0x8F21A30", VA = "0x188F23030")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F26E50", Offset = "0x8F25850", VA = "0x188F26E50")]
		public void RunCoroutine(IEnumerator routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
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

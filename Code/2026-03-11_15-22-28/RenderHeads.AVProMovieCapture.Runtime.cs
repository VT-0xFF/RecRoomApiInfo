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
		private Vector3 CHKTSKZFKMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private AmbisonicOrder MJXEEPSOSYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private AmbisonicChannelOrder QTHEUJLMEWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private AmbisonicNormalisation ZJUYQOJZRXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IntPtr UFOEXPKPQGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int XZSOBYLDFQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float[] LMYRYTCRPEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Queue<float[]> KJMJVGTORJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Queue<float[]> WCQZKNWUWHG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9067460", Offset = "0x9066460", VA = "0x189067460")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9067200", Offset = "0x9066200", VA = "0x189067200")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9067820", Offset = "0x9066820", VA = "0x189067820")]
		internal void VWDXMXENINO(AmbisonicOrder a, AmbisonicChannelOrder b, AmbisonicNormalisation c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9067340", Offset = "0x9066340", VA = "0x189067340")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9066930", Offset = "0x9065930", VA = "0x189066930")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9067A10", Offset = "0x9066A10", VA = "0x189067A10")]
		private void ZQOBLXOHJJY(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9066A90", Offset = "0x9065A90", VA = "0x189066A90")]
		private void NTAQDQCEZAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9066C40", Offset = "0x9065C40", VA = "0x189066C40")]
		private void OnAudioFilterRead(float[] samples, int channelCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x90675E0", Offset = "0x90665E0", VA = "0x1890675E0")]
		internal void TASEBHKJQWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9066720", Offset = "0x9065720", VA = "0x189066720")]
		internal int CHQXJYYTUZX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9066760", Offset = "0x9065760", VA = "0x189066760")]
		internal void CJTHIDCZQUG(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9067A30", Offset = "0x9066A30", VA = "0x189067A30")]
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
		private float[] YFDZFEMTBRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private IFRGAVXNJNC JIGPAGMNAIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<AmbisonicSource> GPMTSVBHFZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int HBMYKIOGWKU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AmbisonicOrder NOFLMKPUFSR
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAD05D0", Offset = "0xACF5D0", VA = "0x180AD05D0")]
			get
			{
				return default(AmbisonicOrder);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AmbisonicFormat SVBVQBLGUAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB98E90", Offset = "0xB97E90", VA = "0x180B98E90")]
			get
			{
				return default(AmbisonicFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9068670", Offset = "0x9067670", VA = "0x189068670")]
		internal void SFJLBZAAMLR(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9067BD0", Offset = "0x9066BD0", VA = "0x189067BD0")]
		internal void EPZRKDLKTYC(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9068560", Offset = "0x9067560", VA = "0x189068560")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9067B20", Offset = "0x9066B20", VA = "0x189067B20")]
		private void DOEHEPSGESJ(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9068470", Offset = "0x9067470", VA = "0x189068470")]
		private void JEGATVSDMPG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9067EF0", Offset = "0x9066EF0", VA = "0x189067EF0")]
		private void HZYDXPQCYFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9068570", Offset = "0x9067570", VA = "0x189068570")]
		private void RKBFQWKKLLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x90687B0", Offset = "0x90677B0", VA = "0x1890687B0")]
		private bool UDUKYPPQOMU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x90684A0", Offset = "0x90674A0", VA = "0x1890684A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9067CB0", Offset = "0x9066CB0", VA = "0x189067CB0")]
		private void HHEJXHTLZUC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9068360", Offset = "0x9067360", VA = "0x189068360")]
		internal void IKFQNDOQMSO(float[] a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9068320", Offset = "0x9067320", VA = "0x189068320")]
		private void IHUKTIOXIGQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x90687D0", Offset = "0x90677D0", VA = "0x1890687D0")]
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
		private IFRGAVXNJNC JIGPAGMNAIR;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9068900", Offset = "0x9067900", VA = "0x189068900")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x90688C0", Offset = "0x90678C0", VA = "0x1890688C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9068890", Offset = "0x9067890", VA = "0x189068890")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9068A60", Offset = "0x9067A60", VA = "0x189068A60")]
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
		private Camera[] ZLEXQBVDCZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int ESXJUKUUWFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int GJZCSTPMTUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool OHXHXACSWNM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Camera PZJOPZQUQUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DE0", Offset = "0xAD4DE0", VA = "0x180AD5DE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x90697D0", Offset = "0x90687D0", VA = "0x1890697D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public SelectByMode GJLZJJWANRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530")]
			get
			{
				return default(SelectByMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9069820", Offset = "0x9068820", VA = "0x189069820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ScanFrequencyMode WMYINLCNPBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAF3A00", Offset = "0xAF2A00", VA = "0x180AF3A00")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9069800", Offset = "0x9068800", VA = "0x189069800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool QXECZUFYJHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xCE16F0", Offset = "0xCE06F0", VA = "0x180CE16F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9069810", Offset = "0x9068810", VA = "0x189069810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string PUCZHXBJJSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9069850", Offset = "0x9068850", VA = "0x189069850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string AOPOMJSXASI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9069830", Offset = "0x9068830", VA = "0x189069830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9068F00", Offset = "0x9067F00", VA = "0x189068F00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9069470", Offset = "0x9068470", VA = "0x189069470")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9068F00", Offset = "0x9067F00", VA = "0x189068F00")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9069660", Offset = "0x9068660", VA = "0x189069660")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9069090", Offset = "0x9068090", VA = "0x189069090")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9068F10", Offset = "0x9067F10", VA = "0x189068F10")]
		private void DMPAXNOKPZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9069080", Offset = "0x9068080", VA = "0x189069080")]
		private void MVIONTFMCYD(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x90693B0", Offset = "0x90683B0", VA = "0x1890693B0")]
		public bool ScanForCameraChange()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9069120", Offset = "0x9068120", VA = "0x189069120")]
		private Camera QZHPGIYVIDV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9069580", Offset = "0x9068580", VA = "0x189069580")]
		public void UpdateCameraCache(bool forceScanHiddenCameras = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9069480", Offset = "0x9068480", VA = "0x189069480")]
		private static Camera UAXFDDBLSYX(int a, Camera[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9068FF0", Offset = "0x9067FF0", VA = "0x189068FF0")]
		private static Camera KXFETVBZRAK(int a, Camera[] b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9069680", Offset = "0x9068680", VA = "0x189069680")]
		private static Camera WRHAGAYQGUV(int a, Camera[] b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9069720", Offset = "0x9068720", VA = "0x189069720")]
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
		private int HYPHWMDWGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int YUPGJVOQROA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int UHRYWCJXUUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int NUKZXTOBZEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float[] UAMSBGWHRCL;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9069D80", Offset = "0x9068D80", VA = "0x189069D80")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9069A90", Offset = "0x9068A90", VA = "0x189069A90")]
		private void LJCXTHQSGGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9069AB0", Offset = "0x9068AB0", VA = "0x189069AB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9069DA0", Offset = "0x9068DA0", VA = "0x189069DA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9069870", Offset = "0x9068870", VA = "0x189069870")]
		private float[] JIRNFTEPYEY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9069E40", Offset = "0x9068E40", VA = "0x189069E40")]
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
		private const int MTDAULETSWI = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float[] AQYKLMELYHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float[] OZLOAVGMSYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int ITTPJIYKNHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private GCHandle YGALAPEZKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int TEFZUIDCRUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int CRBAWLKLWYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object JAQQLMLAAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool KLAYAETZIDU;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float[] ZTFHEQUXQOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int KFAGYJGNICR
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAFB170", Offset = "0xAFA170", VA = "0x180AFB170")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IntPtr BBDKUZVZBDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x906A8B0", Offset = "0x90698B0", VA = "0x18906A8B0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override int NYXZKYYVUHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x14114D0", Offset = "0x14104D0", VA = "0x1814114D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int MJUFRQKANEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x906A8C0", Offset = "0x90698C0", VA = "0x18906A8C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override int XJPKODRQZMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD8F670", Offset = "0xD8E670", VA = "0x180D8F670", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x906A1B0", Offset = "0x90691B0", VA = "0x18906A1B0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD868F0", Offset = "0xD858F0", VA = "0x180D868F0", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x906A730", Offset = "0x9069730", VA = "0x18906A730", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x906A1A0", Offset = "0x90691A0", VA = "0x18906A1A0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x906A680", Offset = "0x9069680", VA = "0x18906A680", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x906A590", Offset = "0x9069590", VA = "0x18906A590", Slot = "13")]
		public override IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9069E50", Offset = "0x9068E50", VA = "0x189069E50", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9069EF0", Offset = "0x9068EF0", VA = "0x189069EF0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x906A800", Offset = "0x9069800", VA = "0x18906A800")]
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
		private int MVVSPGLYWLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool OICKQBZSVJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private NativeArray<float> JXQGSFHARCE;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CaptureBase TIDIFTJBDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xACDA20", Offset = "0xACCA20", VA = "0x180ACDA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override int MJUFRQKANEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x906A8C0", Offset = "0x90698C0", VA = "0x18906A8C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override int XJPKODRQZMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAD05D0", Offset = "0xACF5D0", VA = "0x180AD05D0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x906AA70", Offset = "0x9069A70", VA = "0x18906AA70", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x906A920", Offset = "0x9069920", VA = "0x18906A920")]
		private NativeArray<float> MWIVFYFOEBA(int a)
		{
			return default(NativeArray<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private void QLAQUJXDJFO(NativeArray<float> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x906AA90", Offset = "0x9069A90", VA = "0x18906AA90", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x906ABA0", Offset = "0x9069BA0", VA = "0x18906ABA0", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x906A8D0", Offset = "0x90698D0", VA = "0x18906A8D0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x906AC00", Offset = "0x9069C00", VA = "0x18906AC00")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F50", Offset = "0xAE6F50", VA = "0x180AE7F50")]
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
		private const int MTDAULETSWI = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float[] AQYKLMELYHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float[] OZLOAVGMSYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int RBQUTLZFBUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int KMMOHOYSOST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GCHandle YGALAPEZKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int TEFZUIDCRUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool HLVOFPQGQMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int LFMRGEJKCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int CRBAWLKLWYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private object JAQQLMLAAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool XPXNTKBJYHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool KLAYAETZIDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int UTLMGZIRDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int UIQXBYUZPTS;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public List<OnAudioFilterReadForwarder> ZNKGSBOUWPO
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xACDA30", Offset = "0xACCA30", VA = "0x180ACDA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool UPBJOXKDPXU
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xADD460", Offset = "0xADC460", VA = "0x180ADD460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xADCE80", Offset = "0xADBE80", VA = "0x180ADCE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float[] ZTFHEQUXQOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int KFAGYJGNICR
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAE9560", Offset = "0xAE8560", VA = "0x180AE9560")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IntPtr BBDKUZVZBDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x906BFE0", Offset = "0x906AFE0", VA = "0x18906BFE0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override int NYXZKYYVUHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x12A63B0", Offset = "0x12A53B0", VA = "0x1812A63B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override int MJUFRQKANEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x906A8C0", Offset = "0x90698C0", VA = "0x18906A8C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override int XJPKODRQZMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xC3AF70", Offset = "0xC39F70", VA = "0x180C3AF70", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x906BAC0", Offset = "0x906AAC0", VA = "0x18906BAC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x906B2F0", Offset = "0x906A2F0", VA = "0x18906B2F0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x906B8E0", Offset = "0x906A8E0", VA = "0x18906B8E0", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x906BC90", Offset = "0x906AC90", VA = "0x18906BC90", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x906B2E0", Offset = "0x906A2E0", VA = "0x18906B2E0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x906B820", Offset = "0x906A820", VA = "0x18906B820", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x906B6D0", Offset = "0x906A6D0", VA = "0x18906B6D0", Slot = "13")]
		public override IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x906ACF0", Offset = "0x9069CF0", VA = "0x18906ACF0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x906AE70", Offset = "0x9069E70", VA = "0x18906AE70")]
		public void OnAudioFilterReadCombiner(float[] data, int channels, bool isMicrophone, int sampleRate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x906AD90", Offset = "0x9069D90", VA = "0x18906AD90")]
		private float[] HTDAVVSWQZC(float[] a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x906BF30", Offset = "0x906AF30", VA = "0x18906BF30")]
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
		public CaptureBase TIDIFTJBDDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xACDA20", Offset = "0xACCA20", VA = "0x180ACDA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override int MJUFRQKANEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override int XJPKODRQZMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x906BFF0", Offset = "0x906AFF0", VA = "0x18906BFF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F50", Offset = "0xAE6F50", VA = "0x180AE7F50")]
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
		private sealed class CXPLWJLKXGN : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private object GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public CaptureFromCamera SULNKEFFSGR;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object DPCCRMRAFAQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public CXPLWJLKXGN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9068AB0", Offset = "0x9067AB0", VA = "0x189068AB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9068EC0", Offset = "0x9067EC0", VA = "0x189068EC0", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class RBSMMUSTCOK : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private object GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public CaptureFromCamera SULNKEFFSGR;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private object DPCCRMRAFAQ
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public RBSMMUSTCOK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x907AE30", Offset = "0x9079E30", VA = "0x18907AE30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x907AED0", Offset = "0x9079ED0", VA = "0x18907AED0", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
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
		private RenderTexture UHXFJJBDRWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private RenderTexture XOLDVQMMHYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private IntPtr MZSNNIYSCQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Texture LCVBFFJHMGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Texture NDKQMPZEXQL;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public CameraSelector RAOZGBUREND
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD06350", Offset = "0xD05350", VA = "0x180D06350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xEB40D0", Offset = "0xEB30D0", VA = "0x180EB40D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool CMDIMYLOJIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xD064A0", Offset = "0xD054A0", VA = "0x180D064A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xD065D0", Offset = "0xD055D0", VA = "0x180D065D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x90740F0", Offset = "0x90730F0", VA = "0x1890740F0")]
		public void SetCamera(Camera topCamera, bool useContributingCameras = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x90740A0", Offset = "0x90730A0", VA = "0x1890740A0")]
		public void SetCamera(Camera topCamera, Camera[] contributingCameras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9072F10", Offset = "0x9071F10", VA = "0x189072F10")]
		private bool FAWUCWUATJX(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9073220", Offset = "0x9072220", VA = "0x189073220")]
		private bool PKJIUTEDIRM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9073C90", Offset = "0x9072C90", VA = "0x189073C90")]
		private bool QIPJHPTEUQP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9074300", Offset = "0x9073300", VA = "0x189074300", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9072C60", Offset = "0x9071C60", VA = "0x189072C60")]
		[IteratorStateMachine(typeof(RBSMMUSTCOK))]
		private IEnumerator CBFHSBVEKAZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9072CD0", Offset = "0x9071CD0", VA = "0x189072CD0")]
		[IteratorStateMachine(typeof(CXPLWJLKXGN))]
		public IEnumerator Capture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9072FF0", Offset = "0x9071FF0", VA = "0x189072FF0")]
		private bool OXXJIAJIKZF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9073CC0", Offset = "0x9072CC0", VA = "0x189073CC0")]
		private void QZBWLZPJROB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9074210", Offset = "0x9073210", VA = "0x189074210", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9072D40", Offset = "0x9071D40", VA = "0x189072D40")]
		private void FAAGVSBHTEM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1EA44E0", Offset = "0x1EA34E0", VA = "0x181EA44E0", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9073280", Offset = "0x9072280", VA = "0x189073280", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9073130", Offset = "0x9072130", VA = "0x189073130", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x90744D0", Offset = "0x90734D0", VA = "0x1890744D0")]
		public CaptureFromCamera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9074090", Offset = "0x9073090", VA = "0x189074090")]
		[CompilerGenerated]
		[DebuggerHidden]
		private void RVDYCLSLTMZ()
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
		private sealed class YZANXFJGUDL : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private object GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public CaptureFromCamera360 SULNKEFFSGR;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private object DPCCRMRAFAQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public YZANXFJGUDL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x907B210", Offset = "0x907A210", VA = "0x18907B210", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x907B280", Offset = "0x907A280", VA = "0x18907B280", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
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
		private RenderTexture PFFIVKULQTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private RenderTexture[] BCVUMIYWNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private Material OUWTKRUMUXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Material WTJWFRGTQRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private RenderTexture GCEQHPKVRFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private RenderTexture BPCSJYNORVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private IntPtr MZSNNIYSCQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int RKAFFFHBYTQ;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public CameraSelector RAOZGBUREND
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xD06350", Offset = "0xD05350", VA = "0x180D06350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xEB40D0", Offset = "0xEB30D0", VA = "0x180EB40D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public CubemapResolution CLKZIKWVYTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x17BFA20", Offset = "0x17BEA20", VA = "0x1817BFA20")]
			get
			{
				return default(CubemapResolution);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9072C10", Offset = "0x9071C10", VA = "0x189072C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CubemapDepth QUTMYURVEZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9072BD0", Offset = "0x9071BD0", VA = "0x189072BD0")]
			get
			{
				return default(CubemapDepth);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9072C00", Offset = "0x9071C00", VA = "0x189072C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool NEALLQFBCWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xD064A0", Offset = "0xD054A0", VA = "0x180D064A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xD065D0", Offset = "0xD055D0", VA = "0x180D065D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool HMCKIHEQLMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD06490", Offset = "0xD05490", VA = "0x180D06490")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xD065C0", Offset = "0xD055C0", VA = "0x180D065C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool ROGEBDYFUUU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x82F3770", Offset = "0x82F2770", VA = "0x1882F3770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9072C30", Offset = "0x9071C30", VA = "0x189072C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool LNTLGKSHWOT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9072BF0", Offset = "0x9071BF0", VA = "0x189072BF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9072C40", Offset = "0x9071C40", VA = "0x189072C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public StereoPacking GSIWZQHFAEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x254D240", Offset = "0x254C240", VA = "0x18254D240")]
			get
			{
				return default(StereoPacking);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9072C50", Offset = "0x9071C50", VA = "0x189072C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float QEPQMWWYJFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9072BE0", Offset = "0x9071BE0", VA = "0x189072BE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9072C20", Offset = "0x9071C20", VA = "0x189072C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9072B20", Offset = "0x9071B20", VA = "0x189072B20")]
		public CaptureFromCamera360()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9071D80", Offset = "0x9070D80", VA = "0x189071D80")]
		private CubemapRenderMethod QOSVRGDBSSD()
		{
			return default(CubemapRenderMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xEA6B50", Offset = "0xEA5B50", VA = "0x180EA6B50")]
		public void SetCamera(Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9072820", Offset = "0x9071820", VA = "0x189072820", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x906E7E0", Offset = "0x906D7E0", VA = "0x18906E7E0")]
		[IteratorStateMachine(typeof(YZANXFJGUDL))]
		private IEnumerator CBFHSBVEKAZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x90724F0", Offset = "0x90714F0", VA = "0x1890724F0")]
		private void TIDIFTJBDDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9072990", Offset = "0x9071990", VA = "0x189072990")]
		private static void WUKILHCQVEN(RenderTexture a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x906E890", Offset = "0x906D890", VA = "0x18906E890")]
		private void JTCUQRBVLHV(RenderTexture a, RenderTexture b, bool c, Quaternion d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9071DB0", Offset = "0x9070DB0", VA = "0x189071DB0")]
		private void QZBWLZPJROB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x906ECA0", Offset = "0x906DCA0", VA = "0x18906ECA0")]
		private void LAPICRQLCNE(Camera a, RenderTexture b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9070660", Offset = "0x906F660", VA = "0x189070660")]
		private void MUPDVLRLGJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x90709F0", Offset = "0x906F9F0", VA = "0x1890709F0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x906E850", Offset = "0x906D850", VA = "0x18906E850", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9072310", Offset = "0x9071310", VA = "0x189072310", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9070740", Offset = "0x906F740", VA = "0x189070740", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x907AFC0", Offset = "0x9079FC0", VA = "0x18907AFC0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class RBXTKBMQLZT : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private object GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public CaptureFromCamera360ODS SULNKEFFSGR;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private object DPCCRMRAFAQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000D8")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public RBXTKBMQLZT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x907AF10", Offset = "0x9079F10", VA = "0x18907AF10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x907AF80", Offset = "0x9079F80", VA = "0x18907AF80", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private Settings _settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int LVHBJHAVHID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int MFDQOYZAAQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Transform DSKLEUCFSKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Camera DQABFITVLLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Camera GUUSYGIIIBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Camera YBSVHCFWXLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Camera OCFWAEYACJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private RenderTexture PUAPPPAEPOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IntPtr MZSNNIYSCQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Material CMGFEJONOFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int OWIUJAADLYI;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Settings VWDXMXENINO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xD06350", Offset = "0xD05350", VA = "0x180D06350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x906E6F0", Offset = "0x906D6F0", VA = "0x18906E6F0")]
		public CaptureFromCamera360ODS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x906E130", Offset = "0x906D130", VA = "0x18906E130")]
		public void SetCamera(Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x906E160", Offset = "0x906D160", VA = "0x18906E160", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x906DAE0", Offset = "0x906CAE0", VA = "0x18906DAE0")]
		private Camera SNBEIGWIKAI(Camera a, string b, float c, float d, int e, int f, float g, float h, int i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x906E560", Offset = "0x906D560", VA = "0x18906E560", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x906C050", Offset = "0x906B050", VA = "0x18906C050")]
		[IteratorStateMachine(typeof(RBXTKBMQLZT))]
		private IEnumerator CBFHSBVEKAZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x906E290", Offset = "0x906D290", VA = "0x18906E290")]
		private void TIDIFTJBDDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x906C870", Offset = "0x906B870", VA = "0x18906C870")]
		private void MUPDVLRLGJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x906C1D0", Offset = "0x906B1D0", VA = "0x18906C1D0")]
		private void LUJMKOFMFGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x906C0C0", Offset = "0x906B0C0", VA = "0x18906C0C0", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x906CB90", Offset = "0x906BB90", VA = "0x18906CB90", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x906C100", Offset = "0x906B100", VA = "0x18906C100")]
		private static void INLLATHIFRK(Camera a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x906C950", Offset = "0x906B950", VA = "0x18906C950", Slot = "6")]
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
		private sealed class YBOPWLZGGNJ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private object GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public CaptureFromScreen SULNKEFFSGR;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			private object DPCCRMRAFAQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public YBOPWLZGGNJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x907AFF0", Offset = "0x9079FF0", VA = "0x18907AFF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x907B120", Offset = "0x907A120", VA = "0x18907B120", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
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
		private IntPtr MZSNNIYSCQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private RenderTexture XOLDVQMMHYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private CommandBuffer MOJBMSKCCQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator SHVBLPJZLBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private bool PZAABCLJHLN;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool ZSTITNGSTWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x1FFA0E0", Offset = "0x1FF90E0", VA = "0x181FFA0E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x9075030", Offset = "0x9074030", VA = "0x189075030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public MouseCursor MKSOZVDUGZO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xD06420", Offset = "0xD05420", VA = "0x180D06420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xEA6B50", Offset = "0xEA5B50", VA = "0x180EA6B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9074A90", Offset = "0x9073A90", VA = "0x189074A90", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9074670", Offset = "0x9073670", VA = "0x189074670")]
		private void DEKTTDAIEUR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x90745A0", Offset = "0x90735A0", VA = "0x1890745A0")]
		private void DBMRMOTHIWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9074E90", Offset = "0x9073E90", VA = "0x189074E90", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9074530", Offset = "0x9073530", VA = "0x189074530")]
		[IteratorStateMachine(typeof(YBOPWLZGGNJ))]
		private IEnumerator CBFHSBVEKAZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9074FA0", Offset = "0x9073FA0", VA = "0x189074FA0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9074FD0", Offset = "0x9073FD0", VA = "0x189074FD0")]
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
		private sealed class YBTWTSTDPYS : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private object GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public CaptureFromTexture SULNKEFFSGR;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private object DPCCRMRAFAQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public YBTWTSTDPYS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x907B160", Offset = "0x907A160", VA = "0x18907B160", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x907B1D0", Offset = "0x907A1D0", VA = "0x18907B1D0", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
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
		private Texture SGCCUIIOCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private RenderTexture XOLDVQMMHYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		protected IntPtr MZSNNIYSCQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private bool BVDHISPMDPO;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool FPTBXIYJIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x1FFA0E0", Offset = "0x1FF90E0", VA = "0x181FFA0E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9075030", Offset = "0x9074030", VA = "0x189075030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xEA6B50", Offset = "0xEA5B50", VA = "0x180EA6B50")]
		public void SetSourceTexture(Texture texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9075240", Offset = "0x9074240", VA = "0x189075240")]
		private bool FAWUCWUATJX(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9075FE0", Offset = "0x9074FE0", VA = "0x189075FE0")]
		public void UpdateSourceTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9075FF0", Offset = "0x9074FF0", VA = "0x189075FF0")]
		private bool WFIDFWJENBJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9075910", Offset = "0x9074910", VA = "0x189075910")]
		private bool SLWDYYKUBYF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9075F40", Offset = "0x9074F40", VA = "0x189075F40", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9075040", Offset = "0x9074040", VA = "0x189075040")]
		[IteratorStateMachine(typeof(YBTWTSTDPYS))]
		private IEnumerator CBFHSBVEKAZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9075930", Offset = "0x9074930", VA = "0x189075930")]
		private void TIDIFTJBDDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x90750B0", Offset = "0x90740B0", VA = "0x1890750B0")]
		private void FAAGVSBHTEM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9075420", Offset = "0x9074420", VA = "0x189075420")]
		private void MUPDVLRLGJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9075320", Offset = "0x9074320", VA = "0x189075320", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x90754D0", Offset = "0x90744D0", VA = "0x1890754D0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9075E60", Offset = "0x9074E60", VA = "0x189075E60", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9076060", Offset = "0x9075060", VA = "0x189076060")]
		public CaptureFromTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("AVPro Movie Capture/Capture From WebCamTexture", 3)]
	public class CaptureFromWebCamTexture : CaptureFromTexture
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x90760C0", Offset = "0x90750C0", VA = "0x1890760C0", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9076060", Offset = "0x9075060", VA = "0x189076060")]
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
		private AudioListener MLGEETYGDGD;

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
		private static readonly string[] WPZLOTSWPSP;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly float[] QZBFNOPWSQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private Section EZBEFGUAYGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private string[] HODPFTDMCWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string[] DBYXOQSSJBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private bool[] CUTZCUXXSYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private bool[] IGGDZLMACGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private string[] EEHDYJETQKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private string[] GEJLKDYPINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private string[] VWQYCTKIDRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int HNFAJKKVAFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private GUIStyle VJSPJWWRKSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private int GREYDBHSPJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Vector2 JJSWXJNQSLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Vector2 CVELXUPWNBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private Vector2 TQUBLRCRTIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Vector2 DIKSXHBGZEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private long ZSUHBKZHPNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float UWYBNXIJIQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float URBXTGCSRDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private uint MVNMIJXFPJV;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public CaptureBase EBILVHOXFQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xACDA30", Offset = "0xACCA30", VA = "0x180ACDA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool AVPOTDTMZTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xCE9450", Offset = "0xCE8450", VA = "0x180CE9450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xD233E0", Offset = "0xD223E0", VA = "0x180D233E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool YELULZEFEWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xB25800", Offset = "0xB24800", VA = "0x180B25800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xB25890", Offset = "0xB24890", VA = "0x180B25890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9078EA0", Offset = "0x9077EA0", VA = "0x189078EA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9078110", Offset = "0x9077110", VA = "0x189078110")]
		private void KXZLJJHSRFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x9078940", Offset = "0x9077940", VA = "0x189078940")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9076130", Offset = "0x9075130", VA = "0x189076130")]
		private void CPLEQUPZIPP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x90795C0", Offset = "0x90785C0", VA = "0x1890795C0")]
		private void YFGHKOIGAWA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9079210", Offset = "0x9078210", VA = "0x189079210")]
		private void WCSWYGQOJNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9078F10", Offset = "0x9077F10", VA = "0x189078F10")]
		private void TQXDCWLPEWI(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9077F40", Offset = "0x9076F40", VA = "0x189077F40")]
		private void HZYDXPQCYFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9078E10", Offset = "0x9077E10", VA = "0x189078E10")]
		private void RKBFQWKKLLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9078090", Offset = "0x9077090", VA = "0x189078090")]
		private void JUWLFPFZKLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9078010", Offset = "0x9077010", VA = "0x189078010")]
		private void JULJZTTJPEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9079190", Offset = "0x9078190", VA = "0x189079190")]
		private void VTBSEWPIDPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9078FA0", Offset = "0x9077FA0", VA = "0x189078FA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x907AA60", Offset = "0x9079A60", VA = "0x18907AA60")]
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
		private RenderTexture PANKVAGJODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private RenderTexture ZUSNMESEVZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Material QNKHGKYCSNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Material EAYSVEMECJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int AALPBZMVDTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int KNPJTHGVRMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int TARKHQABEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private bool EPDYMUDEUUI;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int ZWRZZWMYYYC;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static int ZWKNYYTCCWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		public float _bias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private float GFYEPTREZJE;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool ZZFAVNJNQWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x1DD7770", Offset = "0x1DD6770", VA = "0x181DD7770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x1DD7820", Offset = "0x1DD6820", VA = "0x181DD7820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int VRSQCNZHNTS
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAF3A00", Offset = "0xAF2A00", VA = "0x180AF3A00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x908DAA0", Offset = "0x908CAA0", VA = "0x18908DAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int ABPBXUQMUQT
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xD8F670", Offset = "0xD8E670", VA = "0x180D8F670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public RenderTexture PSYPYXAYVAY
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x908D0D0", Offset = "0x908C0D0", VA = "0x18908D0D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x908D630", Offset = "0x908C630", VA = "0x18908D630")]
		public void SetTargetSize(int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x908D650", Offset = "0x908C650", VA = "0x18908D650")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x908D3A0", Offset = "0x908C3A0", VA = "0x18908D3A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x908D740", Offset = "0x908C740", VA = "0x18908D740")]
		private void VWDXMXENINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x908D160", Offset = "0x908C160", VA = "0x18908D160")]
		private void EHEWQGXMPVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x908D1C0", Offset = "0x908C1C0", VA = "0x18908D1C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x908D400", Offset = "0x908C400", VA = "0x18908D400")]
		public void OnNumSamplesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x85D7A00", Offset = "0x85D6A00", VA = "0x1885D7A00")]
		private static float SNONENDJKCR(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x908D660", Offset = "0x908C660", VA = "0x18908D660")]
		private void UVKMTEIGFUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x908CFB0", Offset = "0x908BFB0", VA = "0x18908CFB0")]
		public void Accumulate(Texture src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x908D4C0", Offset = "0x908C4C0", VA = "0x18908D4C0")]
		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x908DA80", Offset = "0x908CA80", VA = "0x18908DA80")]
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
		private GUIContent DSZKWHPNZOV;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x908DCB0", Offset = "0x908CCB0", VA = "0x18908DCB0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x908DC00", Offset = "0x908CC00", VA = "0x18908DC00")]
		public void SetTexture(Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x908DAB0", Offset = "0x908CAB0", VA = "0x18908DAB0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x908DD70", Offset = "0x908CD70", VA = "0x18908DD70")]
		public MouseCursor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class OnAudioFilterReadForwarder : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Action<float[], int, bool, int> TWAFABFFPDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xACDA20", Offset = "0xACCA20", VA = "0x180ACDA20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x908DF50", Offset = "0x908CF50", VA = "0x18908DF50")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
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
		internal class THFCUJBGHMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private PlayableDirector RQUMZMCRBVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private DirectorUpdateMode DHVAIUQTKPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private bool ZLECBYOHICR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private bool BPAIACYBVUR;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
			internal THFCUJBGHMD(PlayableDirector a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x908E4D0", Offset = "0x908D4D0", VA = "0x18908E4D0")]
			internal bool TTDWBMEONRN(PlayableDirector a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x908E300", Offset = "0x908D300", VA = "0x18908E300")]
			internal void HZYDXPQCYFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x908E400", Offset = "0x908D400", VA = "0x18908E400")]
			internal void RKBFQWKKLLN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private ScanFrequencyMode _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<THFCUJBGHMD> IZEYMEEZREU;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public ScanFrequencyMode WMYINLCNPBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x908EE90", Offset = "0x908DE90", VA = "0x18908EE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x908E530", Offset = "0x908D530", VA = "0x18908E530")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x908E530", Offset = "0x908D530", VA = "0x18908E530")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x908EE00", Offset = "0x908DE00", VA = "0x18908EE00")]
		internal void YGGRFHFMADZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x908E620", Offset = "0x908D620", VA = "0x18908E620")]
		internal void HZYDXPQCYFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x908E8F0", Offset = "0x908D8F0", VA = "0x18908E8F0")]
		internal void RKBFQWKKLLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x908EAD0", Offset = "0x908DAD0", VA = "0x18908EAD0")]
		public void ScanForPlayableDirectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x908E850", Offset = "0x908D850", VA = "0x18908E850")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x908E540", Offset = "0x908D540", VA = "0x18908E540")]
		private void DMPAXNOKPZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x908E840", Offset = "0x908D840", VA = "0x18908E840")]
		private void MVIONTFMCYD(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x908EE10", Offset = "0x908DE10", VA = "0x18908EE10")]
		public TimelineController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public abstract class UnityAudioCapture : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public virtual int NYXZKYYVUHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public abstract int MJUFRQKANEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public abstract int XJPKODRQZMJ
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
		[Cpp2IlInjected.Address(RVA = "0x908FE10", Offset = "0x908EE10", VA = "0x18908FE10", Slot = "13")]
		public virtual IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x908FC80", Offset = "0x908EC80", VA = "0x18908FC80")]
		public static int GetUnityAudioChannelCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x908FDA0", Offset = "0x908EDA0", VA = "0x18908FDA0")]
		private static int NJHGLWCXLLF(AudioSpeakerMode a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
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
		internal class JLPGJJESYGU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private VideoPlayer ZAKOZMPGAXE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private bool BPAIACYBVUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private bool ZLECBYOHICR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private bool PUWPNXQRWTV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private double SWBGFLGSZOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private float BYPLDQVBPKD;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
			internal JLPGJJESYGU(VideoPlayer a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x9086100", Offset = "0x9085100", VA = "0x189086100")]
			internal bool TTDWBMEONRN(VideoPlayer a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x9085A80", Offset = "0x9084A80", VA = "0x189085A80")]
			internal void HZYDXPQCYFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x90864D0", Offset = "0x90854D0", VA = "0x1890864D0")]
			internal bool XYJAFMNDXCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9085B00", Offset = "0x9084B00", VA = "0x189085B00")]
			internal void JAQTYXNGGTG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9085FD0", Offset = "0x9084FD0", VA = "0x189085FD0")]
			private void PBZKCJLMGNI(VideoPlayer a, long b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x9085ED0", Offset = "0x9084ED0", VA = "0x189085ED0")]
			private void ONTCHHGWNBJ(VideoPlayer a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9085E40", Offset = "0x9084E40", VA = "0x189085E40")]
			internal void MEALGEIQKCV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9086160", Offset = "0x9085160", VA = "0x189086160")]
			internal bool Update(float deltaTime)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x9086070", Offset = "0x9085070", VA = "0x189086070")]
			internal void RKBFQWKKLLN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class NRGBHLKNDHT : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private object GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public VideoPlayerController SULNKEFFSGR;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			private object DPCCRMRAFAQ
			{
				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public NRGBHLKNDHT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x908DDD0", Offset = "0x908CDD0", VA = "0x18908DDD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x908DF10", Offset = "0x908CF10", VA = "0x18908DF10", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private ScanFrequencyMode _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<JLPGJJESYGU> HRATPMTSPDG;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public ScanFrequencyMode WMYINLCNPBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9091D40", Offset = "0x9090D40", VA = "0x189091D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9090FB0", Offset = "0x908FFB0", VA = "0x189090FB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9090FB0", Offset = "0x908FFB0", VA = "0x189090FB0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9091B80", Offset = "0x9090B80", VA = "0x189091B80")]
		internal void YGGRFHFMADZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9090FC0", Offset = "0x908FFC0", VA = "0x189090FC0")]
		public bool CanContinue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9091B10", Offset = "0x9090B10", VA = "0x189091B10")]
		[IteratorStateMachine(typeof(NRGBHLKNDHT))]
		internal IEnumerator UVSSUJJTGKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9091380", Offset = "0x9090380", VA = "0x189091380")]
		internal void HZYDXPQCYFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x90915E0", Offset = "0x90905E0", VA = "0x1890915E0")]
		internal void RKBFQWKKLLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9091770", Offset = "0x9090770", VA = "0x189091770")]
		public void ScanForVideoPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9091540", Offset = "0x9090540", VA = "0x189091540")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9091130", Offset = "0x9090130", VA = "0x189091130")]
		private void DMPAXNOKPZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9091530", Offset = "0x9090530", VA = "0x189091530")]
		private void MVIONTFMCYD(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9091CC0", Offset = "0x9090CC0", VA = "0x189091CC0")]
		public VideoPlayerController()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9091210", Offset = "0x9090210", VA = "0x189091210")]
		[CompilerGenerated]
		private bool HZDTLHHGYGI()
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
	public class WWUMLGGSHTN
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
		public static string[] CHQUFOOEAWM;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly string[] QPQRRBZJPKB;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly string[] UYARSNGACWK;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly string[] SDAFAUQFEBX;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly string[] IPKHYDMBICO;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly string[] SDOQXAWVLPR;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly string[] IFABNOKNUAQ;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static IntPtr PBTGENYVMRW;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private static IntPtr ZPQNHSQFBOO;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private static IntPtr NCIHCETYZCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x9094330", Offset = "0x9093330", VA = "0x189094330")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		private static IntPtr LGINFQNSFXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x9093DD0", Offset = "0x9092DD0", VA = "0x189093DD0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9091D50", Offset = "0x9090D50", VA = "0x189091D50")]
		public static extern IntPtr AddAmbisonicSourceInstance(int maxCoefficients);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9093FA0", Offset = "0x9092FA0", VA = "0x189093FA0")]
		public static extern void RemoveAmbisonicSourceInstance(IntPtr instance);

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9094250", Offset = "0x9093250", VA = "0x189094250")]
		public static extern void UpdateAmbisonicWeights(IntPtr instance, float azimuth, float elevation, AmbisonicOrder order, AmbisonicChannelOrder channelOrder, float[] normalisationWeights);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9092610", Offset = "0x9091610", VA = "0x189092610")]
		public static extern void EncodeMonoToAmbisonic(IntPtr instance, float[] inSamples, int inSamplesOffset, int inFrameCount, int inChannelCount, float[] outSamples, int outSamplesOffset, int outSamplesLength, AmbisonicOrder order);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9093ED0", Offset = "0x9092ED0", VA = "0x189093ED0")]
		public static string RACKHMVBTRB(PixelFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9093B60", Offset = "0x9092B60", VA = "0x189093B60")]
		public static void QGQAGKCNOAB(PluginEvent a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x90931F0", Offset = "0x90921F0", VA = "0x1890931F0")]
		private static extern IntPtr GetRenderEventFunc();

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9092F90", Offset = "0x9091F90", VA = "0x189092F90")]
		private static extern IntPtr GetFreeResourcesEventFunc();

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x90934F0", Offset = "0x90924F0", VA = "0x1890934F0")]
		public static extern bool Init();

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9092250", Offset = "0x9091250", VA = "0x189092250")]
		public static extern void Deinit();

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9093420", Offset = "0x9092420", VA = "0x189093420")]
		public static string HAVSWKONNAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9093760", Offset = "0x9092760", VA = "0x189093760")]
		public static bool KMDSMFTACHV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9093260", Offset = "0x9092260", VA = "0x189093260")]
		public static extern int GetVideoCodecCount();

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x90935E0", Offset = "0x90925E0", VA = "0x1890935E0")]
		public static extern bool IsConfigureVideoCodecSupported(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x90932D0", Offset = "0x90922D0", VA = "0x1890932D0")]
		public static extern MediaApi GetVideoCodecMediaApi(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9091E50", Offset = "0x9090E50", VA = "0x189091E50")]
		public static extern void ConfigureVideoCodec(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x90922C0", Offset = "0x90912C0", VA = "0x1890922C0")]
		public static string ETWBGBTHUTD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x90928F0", Offset = "0x90918F0", VA = "0x1890928F0")]
		public static extern int GetAudioCodecCount();

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9093560", Offset = "0x9092560", VA = "0x189093560")]
		public static extern bool IsConfigureAudioCodecSupported(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9092960", Offset = "0x9091960", VA = "0x189092960")]
		public static extern MediaApi GetAudioCodecMediaApi(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9091DD0", Offset = "0x9090DD0", VA = "0x189091DD0")]
		public static extern void ConfigureAudioCodec(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9093960", Offset = "0x9092960", VA = "0x189093960")]
		public static string NZNJPUASFJI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9092AB0", Offset = "0x9091AB0", VA = "0x189092AB0")]
		public static extern int GetAudioInputDeviceCount();

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x90937E0", Offset = "0x90927E0", VA = "0x1890937E0")]
		public static string NKKDWRSPXNE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9092B20", Offset = "0x9091B20", VA = "0x189092B20")]
		public static extern MediaApi GetAudioInputDeviceMediaApi(int index);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9094430", Offset = "0x9093430", VA = "0x189094430")]
		public static string[] YCEYTMHDFUM(int a, int b = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x90920F0", Offset = "0x90910F0", VA = "0x1890920F0")]
		public static extern int CreateRecorderVideo(string filename, uint width, uint height, float frameRate, int format, bool isRealTime, bool isTopDown, int videoCodecIndex, AudioCaptureSource audioSource, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool forceGpuFlush, VideoEncoderHints hints);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9091ED0", Offset = "0x9090ED0", VA = "0x189091ED0")]
		public static extern int CreateRecorderImages(string filename, uint width, uint height, float frameRate, int format, bool isRealTime, bool isTopDown, int imageFormatType, bool forceGpuFlush, int startFrame, ImageEncoderHints hints);

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9092000", Offset = "0x9091000", VA = "0x189092000")]
		public static extern int CreateRecorderPipe(string filename, uint width, uint height, float frameRate, int format, bool isTopDown, int transparencyMode, bool forceGpuFlush);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9094140", Offset = "0x9093140", VA = "0x189094140")]
		public static extern bool Start(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x90936E0", Offset = "0x90926E0", VA = "0x1890936E0")]
		public static extern bool IsNewFrameDue(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9094020", Offset = "0x9093020", VA = "0x189094020")]
		public static extern int SetEncodedFrameLimit(int handle, uint encodedFrameLimit);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9092580", Offset = "0x9091580", VA = "0x189092580")]
		public static extern void EncodeFrame(int handle, IntPtr data);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9092440", Offset = "0x9091440", VA = "0x189092440")]
		public static extern void EncodeAudio(int handle, IntPtr data, uint length);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x90924E0", Offset = "0x90914E0", VA = "0x1890924E0")]
		public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength);

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9093AE0", Offset = "0x9092AE0", VA = "0x189093AE0")]
		public static extern void Pause(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x90941C0", Offset = "0x90931C0", VA = "0x1890941C0")]
		public static extern void Stop(int handle, bool skipPendingFrames);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9093660", Offset = "0x9092660", VA = "0x189093660")]
		public static extern bool IsFileWritingComplete(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0")]
		public static bool CBYZEMVZRPE(int a, StringBuilder b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x90940B0", Offset = "0x90930B0", VA = "0x1890940B0")]
		public static extern void SetTexturePointer(int handle, IntPtr texture);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9092710", Offset = "0x9091710", VA = "0x189092710")]
		public static extern void FreeRecorder(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9093080", Offset = "0x9092080", VA = "0x189093080")]
		public static extern uint GetNumDroppedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9093000", Offset = "0x9092000", VA = "0x189093000")]
		public static extern uint GetNumDroppedEncoderFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9093100", Offset = "0x9092100", VA = "0x189093100")]
		public static extern uint GetNumEncodedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9092F10", Offset = "0x9091F10", VA = "0x189092F10")]
		public static extern float GetEncodedSeconds(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9092C70", Offset = "0x9091C70", VA = "0x189092C70")]
		public static extern uint GetBufferSize(int handle);

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9092CF0", Offset = "0x9091CF0", VA = "0x189092CF0")]
		public static extern uint GetBufferedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9093180", Offset = "0x9092180", VA = "0x189093180")]
		private static extern IntPtr GetPluginVersion();

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x9093350", Offset = "0x9092350", VA = "0x189093350")]
		private static extern bool GetVideoCodecName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x90929E0", Offset = "0x90919E0", VA = "0x1890929E0")]
		private static extern bool GetAudioCodecName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9092BA0", Offset = "0x9091BA0", VA = "0x189092BA0")]
		private static extern bool GetAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9092D70", Offset = "0x9091D70", VA = "0x189092D70")]
		private static extern bool GetContainerFileExtensions(int videoCodecIndex, int audioCodecIndex, StringBuilder extensions, int extensionsBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9092E50", Offset = "0x9091E50", VA = "0x189092E50")]
		private static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, [Out] ulong lpFreeBytesAvailable, [Out] ulong lpTotalNumberOfBytes, [Out] ulong lpTotalNumberOfFreeBytes);

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x9092790", Offset = "0x9091790", VA = "0x189092790")]
		public static bool GAHHCFLAXJH(string a, [Out] ulong b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class LPSRLGQKBWQ
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
			[Cpp2IlInjected.Address(RVA = "0x908E040", Offset = "0x908D040", VA = "0x18908E040")]
			public void TYFAUREMTCN(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static float[] CQKAJESKPXA;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static float[] FIDFJDYZBVB;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x908C4C0", Offset = "0x908B4C0", VA = "0x18908C4C0")]
		public static float[] GKJKLVSRDNO(AmbisonicNormalisation a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x908C540", Offset = "0x908B540", VA = "0x18908C540")]
		public static int LWBGMCFPQJD(AmbisonicOrder a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x908C4B0", Offset = "0x908B4B0", VA = "0x18908C4B0")]
		public static AmbisonicChannelOrder GJCDPRXHBIE(AmbisonicFormat a)
		{
			return default(AmbisonicChannelOrder);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x908C4B0", Offset = "0x908B4B0", VA = "0x18908C4B0")]
		public static AmbisonicNormalisation NQGPHOBHWYD(AmbisonicFormat a)
		{
			return default(AmbisonicNormalisation);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x908CF30", Offset = "0x908BF30", VA = "0x18908CF30")]
		static LPSRLGQKBWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x908CC60", Offset = "0x908BC60", VA = "0x18908CC60")]
		private static float[] UXMUAAXRUCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x908CBE0", Offset = "0x908BBE0", VA = "0x18908CBE0")]
		private static int TQXARHSPRNP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x908CB80", Offset = "0x908BB80", VA = "0x18908CB80")]
		private static int TQHFZNKXPFO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x908C490", Offset = "0x908B490", VA = "0x18908C490")]
		private static int FRAKYPRYPUK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x908C820", Offset = "0x908B820", VA = "0x18908C820")]
		private static float RBVMEJEKHDT(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x908CA10", Offset = "0x908BA10", VA = "0x18908CA10")]
		private static float RBVMEJEKHDT(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x908C570", Offset = "0x908B570", VA = "0x18908C570")]
		private static float[] NWFPYSRYJDK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class PTSUZNBXAMS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private uint WYPWZSDHIEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private uint DTVPXSCTTVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private uint EBGPUFRZBDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private float UBOYNBUYBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private uint SWMZKHMFHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private uint NRSRRVGQFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private ulong HOEYOOHUNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private int DQINDUMAYJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private AudioCaptureSource IIVCKHCROCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int JTJHLAIMFQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private int MVVSPGLYWLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private float RWZEKGQKFBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private int TUVHIRWEEGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private int AALPBZMVDTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private float MYAKDSMNVME;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float HDRBYJRFFVA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xB1DBE0", Offset = "0xB1CBE0", VA = "0x180B1DBE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public uint MVCAPYIMVIL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xACA110", Offset = "0xAC9110", VA = "0x180ACA110")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xAD4F50", Offset = "0xAD3F50", VA = "0x180AD4F50")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public uint XEGTHLRTVHT
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xB7CE40", Offset = "0xB7BE40", VA = "0x180B7CE40")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xB7CC80", Offset = "0xB7BC80", VA = "0x180B7CC80")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public uint WLATPGVUOID
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xAD05F0", Offset = "0xACF5F0", VA = "0x180AD05F0")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xAD12C0", Offset = "0xAD02C0", VA = "0x180AD12C0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float FIGHEPQDTGY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xB228B0", Offset = "0xB218B0", VA = "0x180B228B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x118CDA0", Offset = "0x118BDA0", VA = "0x18118CDA0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		internal uint VIXLIBENTTP
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xB23EE0", Offset = "0xB22EE0", VA = "0x180B23EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		internal uint GLSNEEYHZAM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xCA39E0", Offset = "0xCA29E0", VA = "0x180CA39E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public AudioCaptureSource MBPUPFCGVIK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xB1B470", Offset = "0xB1A470", VA = "0x180B1B470")]
			get
			{
				return default(AudioCaptureSource);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1468170", Offset = "0x1467170", VA = "0x181468170")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public int DNGIYCRAIKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xAFB170", Offset = "0xAFA170", VA = "0x180AFB170")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xB835C0", Offset = "0xB825C0", VA = "0x180B835C0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int PLNRBJKRRCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xB0C730", Offset = "0xB0B730", VA = "0x180B0C730")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xB0B720", Offset = "0xB0A720", VA = "0x180B0B720")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x908DFE0", Offset = "0x908CFE0", VA = "0x18908DFE0")]
		internal void CQTVMTOVBSJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x908DFF0", Offset = "0x908CFF0", VA = "0x18908DFF0")]
		internal void EIFXPFKBQTD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x78B8970", Offset = "0x78B7970", VA = "0x1878B8970")]
		public PTSUZNBXAMS()
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
		[Cpp2IlInjected.Address(RVA = "0x9090F40", Offset = "0x908FF40", VA = "0x189090F40")]
		public VideoEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x9090EE0", Offset = "0x908FEE0", VA = "0x189090EE0")]
		public void SPAFKOXQIZV()
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
		[Cpp2IlInjected.Address(RVA = "0x9085A40", Offset = "0x9084A40", VA = "0x189085A40")]
		public ImageEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9085A20", Offset = "0x9084A20", VA = "0x189085A20")]
		public void SPAFKOXQIZV()
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
		[Cpp2IlInjected.Address(RVA = "0x9084C30", Offset = "0x9083C30", VA = "0x189084C30")]
		public EncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9084B20", Offset = "0x9083B20", VA = "0x189084B20")]
		public void SPAFKOXQIZV()
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
		private const string ITLRTDJOBRL = "https://www.renderheads.com/content/docs/AVProMovieCapture/articles/download.html#editions";

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
		private const string XXRBTSFHRZA = "Captures";

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
		protected Texture2D PTZKUVLEXGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		protected int QTMGEYCWVKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		protected int UFAMBFGEPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		protected int KLOGXIUZKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		protected int KNPJTHGVRMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		protected int TARKHQABEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		protected bool HLVOFPQGQMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A5")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		protected bool KLAYAETZIDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		protected string OGZYMGQVVHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		protected string LFWQWTKHPHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		protected FileInfo MXJCHVOWTWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		protected WWUMLGGSHTN.PixelFormat STDZRUAJKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private Codec HRSGONKHNSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Codec QRBRCKVHKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private SNAIMBPGRQZ XKPWPAMEZTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int GUOAJWXHKKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private float XSHWTPRRDIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		protected bool DWGYXFMNWIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E9")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		protected bool KMEHLCOJCHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EA")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool NFXYAUJEYML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EB")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool HHIECKXBJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private float NJQSIWCJNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private float GWQTUIEDITM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private float URXRAIRBIBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected YieldInstruction NXIWQAESRRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private long FHYEUDJQBCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		protected Transparency GZVSWEJWULY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected RenderTexture KJAVKSXBWKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected Material EQEDSWJELAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float NTFDSEECIEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private bool VHIOMOBPXRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private Action<KCIIHHPYQAN> XEFQEOOPHXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Action<KCIIHHPYQAN> SRETDJMVVET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private List<KCIIHHPYQAN> DBHCYPFBDRH;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static HashSet<string> GFZVMTAZSCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private UnityEvent RHENGWUSBLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private UnityEvent YVBYOBGFXSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private PTSUZNBXAMS IGCFKXJKWQD;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private static bool EPTNMHDLKKJ;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static bool SJGGCUQOHCL;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public OutputTarget LKNNYTXAGGX
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1556660", Offset = "0x1555660", VA = "0x181556660")]
			get
			{
				return default(OutputTarget);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x15561D0", Offset = "0x15551D0", VA = "0x1815561D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public OutputPath ACOJAAXVFEO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xE57DD0", Offset = "0xE56DD0", VA = "0x180E57DD0")]
			get
			{
				return default(OutputPath);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x198AB00", Offset = "0x1989B00", VA = "0x18198AB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string SDSBTCRRAFH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xC99400", Offset = "0xC98400", VA = "0x180C99400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xC99490", Offset = "0xC98490", VA = "0x180C99490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string OUGLBSJYRJI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xD06480", Offset = "0xD05480", VA = "0x180D06480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x14B3AD0", Offset = "0x14B2AD0", VA = "0x1814B3AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool SXJGDWMKROC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xCFC230", Offset = "0xCFB230", VA = "0x180CFC230")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2234C40", Offset = "0x2233C40", VA = "0x182234C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool MQTRLPJIXEB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xE41910", Offset = "0xE40910", VA = "0x180E41910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x238E9D0", Offset = "0x238D9D0", VA = "0x18238E9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string IPSCTFPVIDN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xD06460", Offset = "0xD05460", VA = "0x180D06460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1487F60", Offset = "0x1486F60", VA = "0x181487F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string HFIVVCTBCXV
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xC68280", Offset = "0xC67280", VA = "0x180C68280")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xC667B0", Offset = "0xC657B0", VA = "0x180C667B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool VDXCFVZFFUV
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xBFCBA0", Offset = "0xBFBBA0", VA = "0x180BFCBA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xBFA9A0", Offset = "0xBF99A0", VA = "0x180BFA9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int DDIOZAAEGOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1F845F0", Offset = "0x1F835F0", VA = "0x181F845F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x20BFC30", Offset = "0x20BEC30", VA = "0x1820BFC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int AZTTIAQDPRT
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x104D330", Offset = "0x104C330", VA = "0x18104D330")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x9084810", Offset = "0x9083810", VA = "0x189084810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool OVDGVPVMFRX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x18EEF60", Offset = "0x18EDF60", VA = "0x1818EEF60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x90848E0", Offset = "0x90838E0", VA = "0x1890848E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int UBXVAMPPZDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1F213D0", Offset = "0x1F203D0", VA = "0x181F213D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x9084880", Offset = "0x9083880", VA = "0x189084880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Camera[] OAKDIHCESCI
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xD06560", Offset = "0xD05560", VA = "0x180D06560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x130CDF0", Offset = "0x130BDF0", VA = "0x18130CDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MotionBlur EKKVDNBPHMU
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xDF0B20", Offset = "0xDEFB20", VA = "0x180DF0B20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xC66AD0", Offset = "0xC65AD0", VA = "0x180C66AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Transparency KCJHGKDHDZT
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x266C940", Offset = "0x266B940", VA = "0x18266C940")]
			get
			{
				return default(Transparency);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static HashSet<string> ONOJWCDFNTH
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x90846A0", Offset = "0x90836A0", VA = "0x1890846A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string YHGAWVYPYVI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xD06570", Offset = "0xD05570", VA = "0x180D06570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public UnityEvent LJCXTHQSGGY
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xD063F0", Offset = "0xD053F0", VA = "0x180D063F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public UnityEvent NVMCSJCRWXC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xD06430", Offset = "0xD05430", VA = "0x180D06430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Action<KCIIHHPYQAN> BYMONDFMMDS
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xD06450", Offset = "0xD05450", VA = "0x180D06450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x13DC100", Offset = "0x13DB100", VA = "0x1813DC100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Action<KCIIHHPYQAN> QNMJSOKKPTG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xD06410", Offset = "0xD05410", VA = "0x180D06410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x13E98F0", Offset = "0x13E88F0", VA = "0x1813E98F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Resolution IIJRIVMXXUO
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1F84600", Offset = "0x1F83600", VA = "0x181F84600")]
			get
			{
				return default(Resolution);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x90847C0", Offset = "0x90837C0", VA = "0x1890847C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector2 BLDRQMIERDH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x90846F0", Offset = "0x90836F0", VA = "0x1890846F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x235A0E0", Offset = "0x23590E0", VA = "0x18235A0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int FFMZHGDSISQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xDEBBB0", Offset = "0xDEABB0", VA = "0x180DEBBB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xDE7E70", Offset = "0xDE6E70", VA = "0x180DE7E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool MZZETIBYUKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x173AAE0", Offset = "0x1739AE0", VA = "0x18173AAE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x173AC20", Offset = "0x1739C20", VA = "0x18173AC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool QRTOKZGIENX
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x24AEA40", Offset = "0x24ADA40", VA = "0x1824AEA40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x24AEBC0", Offset = "0x24ADBC0", VA = "0x1824AEBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public AudioCaptureSource MBPUPFCGVIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xB88A20", Offset = "0xB87A20", VA = "0x180B88A20")]
			get
			{
				return default(AudioCaptureSource);
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x172BE40", Offset = "0x172AE40", VA = "0x18172BE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int COJBUPJAWKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1C3FFA0", Offset = "0x1C3EFA0", VA = "0x181C3FFA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x245CF60", Offset = "0x245BF60", VA = "0x18245CF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int NOXQJTEJCAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x104D4C0", Offset = "0x104C4C0", VA = "0x18104D4C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x15563D0", Offset = "0x15553D0", VA = "0x1815563D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public UnityAudioCapture UTBSNZGJPSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xB50C80", Offset = "0xB4FC80", VA = "0x180B50C80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xE9CBB0", Offset = "0xE9BBB0", VA = "0x180E9CBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int EAZGMVXQLJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xE9C1B0", Offset = "0xE9B1B0", VA = "0x180E9C1B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x90847D0", Offset = "0x90837D0", VA = "0x1890847D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float AVQXHSEIKTY
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1406260", Offset = "0x1405260", VA = "0x181406260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x90847E0", Offset = "0x90837E0", VA = "0x1890847E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public StartTriggerMode KMRNJBVWGYT
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xD8F670", Offset = "0xD8E670", VA = "0x180D8F670")]
			get
			{
				return default(StartTriggerMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xD8F8D0", Offset = "0xD8E8D0", VA = "0x180D8F8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public StartDelayMode BYPLQROUSHC
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x14114D0", Offset = "0x14104D0", VA = "0x1814114D0")]
			get
			{
				return default(StartDelayMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x19FF250", Offset = "0x19FE250", VA = "0x1819FF250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float NWBDOTMHUJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xB1CA10", Offset = "0xB1BA10", VA = "0x180B1CA10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x90848B0", Offset = "0x90838B0", VA = "0x1890848B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public StopMode ZWHQGILRAQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x10BC880", Offset = "0x10BB880", VA = "0x1810BC880")]
			get
			{
				return default(StopMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1F2B9C0", Offset = "0x1F2A9C0", VA = "0x181F2B9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int FYGKNRZZVEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xC951D0", Offset = "0xC941D0", VA = "0x180C951D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x90848C0", Offset = "0x90838C0", VA = "0x1890848C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public float KZAYOMLWBIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x104D4B0", Offset = "0x104C4B0", VA = "0x18104D4B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x90848D0", Offset = "0x90838D0", VA = "0x1890848D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool XWKMSFNXRUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DC0", Offset = "0xAD4DC0", VA = "0x180AD5DC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xAD6490", Offset = "0xAD5490", VA = "0x180AD6490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public PTSUZNBXAMS PTSUZNBXAMS
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xD06400", Offset = "0xD05400", VA = "0x180D06400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string[] OVYZUUJQEIR
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xACDCB0", Offset = "0xACCCB0", VA = "0x180ACDCB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x9084930", Offset = "0x9083930", VA = "0x189084930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string[] YBLXXWZRKXL
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xACDCA0", Offset = "0xACCCA0", VA = "0x180ACDCA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x9084900", Offset = "0x9083900", VA = "0x189084900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string[] UDZBUVZJJKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xAD8310", Offset = "0xAD7310", VA = "0x180AD8310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x9084790", Offset = "0x9083790", VA = "0x189084790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string[] FQASPPOOMYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xAD8370", Offset = "0xAD7370", VA = "0x180AD8370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x9084760", Offset = "0x9083760", VA = "0x189084760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int DONUZGANICX
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2BD2ED0", Offset = "0x2BD1ED0", VA = "0x182BD2ED0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x77D1650", Offset = "0x77D0650", VA = "0x1877D1650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public FrameUpdateMode FBQRHCSCAJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xAD82D0", Offset = "0xAD72D0", VA = "0x180AD82D0")]
			get
			{
				return default(FrameUpdateMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xAD83A0", Offset = "0xAD73A0", VA = "0x180AD83A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public DownScale WYFZDXEUYFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xB27D30", Offset = "0xB26D30", VA = "0x180B27D30")]
			get
			{
				return default(DownScale);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xCE7220", Offset = "0xCE6220", VA = "0x180CE7220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 QWPGFWOKDXY
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x28477A0", Offset = "0x28467A0", VA = "0x1828477A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x773AB40", Offset = "0x7739B40", VA = "0x18773AB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool TMQDFLXTENT
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xB95CD0", Offset = "0xB94CD0", VA = "0x180B95CD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xB95E30", Offset = "0xB94E30", VA = "0x180B95E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool GAHICRACGGD
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x8259B40", Offset = "0x8258B40", VA = "0x188259B40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x90848F0", Offset = "0x90838F0", VA = "0x1890848F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool XGHNXAUERAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2855420", Offset = "0x2854420", VA = "0x182855420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2855960", Offset = "0x2854960", VA = "0x182855960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool HOQXXESKHFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xD6FB20", Offset = "0xD6EB20", VA = "0x180D6FB20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xD6FB30", Offset = "0xD6EB30", VA = "0x180D6FB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool GIZOJETTKOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x8F34AA0", Offset = "0x8F33AA0", VA = "0x188F34AA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x8F34C10", Offset = "0x8F33C10", VA = "0x188F34C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public TimelineController BWTIXCTFQRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xB50C70", Offset = "0xB4FC70", VA = "0x180B50C70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xC688A0", Offset = "0xC678A0", VA = "0x180C688A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public VideoPlayerController LQGLZVBZRQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xD06330", Offset = "0xD05330", VA = "0x180D06330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x14B16A0", Offset = "0x14B06A0", VA = "0x1814B16A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Codec QMCHUPBXQQN
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xD06580", Offset = "0xD05580", VA = "0x180D06580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Codec OGHOVARGXXA
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xD063E0", Offset = "0xD053E0", VA = "0x180D063E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public SNAIMBPGRQZ ZAIEPZZPDKG
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xD063D0", Offset = "0xD053D0", VA = "0x180D063D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int VQRRYSMPYOE
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x12A6E60", Offset = "0x12A5E60", VA = "0x1812A6E60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x12A6F50", Offset = "0x12A5F50", VA = "0x1812A6F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int GQNKNLEREIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xC8CFF0", Offset = "0xC8BFF0", VA = "0x180C8CFF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2052080", Offset = "0x2051080", VA = "0x182052080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public ImageSequenceFormat CWHNMYNLFOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1600BB0", Offset = "0x15FFBB0", VA = "0x181600BB0")]
			get
			{
				return default(ImageSequenceFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x20BFB60", Offset = "0x20BEB60", VA = "0x1820BFB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public static string BNQEFRSEYOM
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x9084710", Offset = "0x9083710", VA = "0x189084710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x9084840", Offset = "0x9083840", VA = "0x189084840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90")]
		protected static WWUMLGGSHTN.Platform KUTRIYWRJQB()
		{
			return default(WWUMLGGSHTN.Platform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x907D2E0", Offset = "0x907C2E0", VA = "0x18907D2E0")]
		public EncoderHints GetEncoderHints(WWUMLGGSHTN.Platform platform = WWUMLGGSHTN.Platform.Current)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9081B90", Offset = "0x9080B90", VA = "0x189081B90")]
		public void SetEncoderHints(EncoderHints hints, WWUMLGGSHTN.Platform platform = WWUMLGGSHTN.Platform.Current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void UpdateMediaGallery(string videoFilePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x907B2C0", Offset = "0x907A2C0", VA = "0x18907B2C0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x90839A0", Offset = "0x90829A0", VA = "0x1890839A0")]
		static CaptureBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x9082140", Offset = "0x9081140", VA = "0x189082140", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x907E730", Offset = "0x907D730", VA = "0x18907E730")]
		private static bool ONXIDJTZNRJ(Codec a, RBFGYZHWDGP b, int c, string[] d, MediaApi e, bool f, bool g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9081870", Offset = "0x9080870", VA = "0x189081870")]
		public Codec SelectVideoCodec(bool isStartingCapture = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x90811D0", Offset = "0x90801D0", VA = "0x1890811D0")]
		public Codec SelectAudioCodec()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x9081540", Offset = "0x9080540", VA = "0x189081540")]
		public SNAIMBPGRQZ SelectAudioInputDevice()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x907D450", Offset = "0x907C450", VA = "0x18907D450")]
		public static Vector2 GetRecordingResolution(int width, int height, DownScale downscale, Vector2 maxVideoSize)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9081760", Offset = "0x9080760", VA = "0x189081760")]
		public void SelectRecordingResolution(int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x907EA30", Offset = "0x907DA30", VA = "0x18907EA30", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x907EC60", Offset = "0x907DC60", VA = "0x18907EC60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x907E3C0", Offset = "0x907D3C0", VA = "0x18907E3C0")]
		private void NBQEMERNPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x907E9E0", Offset = "0x907D9E0", VA = "0x18907E9E0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x907B840", Offset = "0x907A840", VA = "0x18907B840")]
		protected void BFCIOEHGXCM(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x907D6B0", Offset = "0x907C6B0", VA = "0x18907D6B0")]
		protected bool IKRUSHBBJUH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x9083930", Offset = "0x9082930", VA = "0x189083930")]
		protected bool ZHJVDQDFQSO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x907C070", Offset = "0x907B070", VA = "0x18907C070", Slot = "7")]
		public virtual void EncodePointer(IntPtr ptr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x907D730", Offset = "0x907C730", VA = "0x18907D730")]
		public bool IsPrepared()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xE58FE0", Offset = "0xE57FE0", VA = "0x180E58FE0")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xE585D0", Offset = "0xE575D0", VA = "0x180E585D0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x907D520", Offset = "0x907C520", VA = "0x18907D520")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2257B30", Offset = "0x2256B30", VA = "0x182257B30")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x907DE90", Offset = "0x907CE90", VA = "0x18907DE90", Slot = "8")]
		protected virtual string MPOVFZROPFG(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x907E560", Offset = "0x907D560", VA = "0x18907E560")]
		private static string NUVPBHVRUON(OutputPath a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x907DC80", Offset = "0x907CC80", VA = "0x18907DC80")]
		private static string MJZLTQCVJMJ(OutputPath a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x907C2D0", Offset = "0x907B2D0", VA = "0x18907C2D0")]
		protected static bool FHMDTMOTSUC(string a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x907C850", Offset = "0x907B850", VA = "0x18907C850")]
		protected void GKOYTAGRMLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x907C3F0", Offset = "0x907B3F0", VA = "0x18907C3F0")]
		public UnityAudioCapture FindOrCreateUnityAudioCapture(bool logWarnings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9082FB0", Offset = "0x9081FB0", VA = "0x189082FB0")]
		private bool WOYHRCBRSWO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x907F050", Offset = "0x907E050", VA = "0x18907F050", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9080FC0", Offset = "0x907FFC0", VA = "0x189080FC0")]
		public void QueueStartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xE5A5B0", Offset = "0xE595B0", VA = "0x180E5A5B0")]
		public bool IsStartCaptureQueued()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x907E270", Offset = "0x907D270", VA = "0x18907E270")]
		protected void MTVIKGCSXNV(StereoPacking a, SphericalVideoLayout b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9081C30", Offset = "0x9080C30", VA = "0x189081C30")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x907EE10", Offset = "0x907DE10", VA = "0x18907EE10")]
		public void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x90810E0", Offset = "0x90800E0", VA = "0x1890810E0")]
		public void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x907BCB0", Offset = "0x907ACB0", VA = "0x18907BCB0")]
		public void CancelCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x907BD90", Offset = "0x907AD90", VA = "0x18907BD90")]
		public static void DeleteCapture(OutputTarget outputTarget, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9080C50", Offset = "0x907FC50", VA = "0x189080C50")]
		protected void QGQAGKCNOAB(WWUMLGGSHTN.PluginEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9082200", Offset = "0x9081200", VA = "0x189082200", Slot = "11")]
		public virtual void StopCapture(bool skipPendingFrames = false, bool ignorePendingFileWrites = false, bool deleteCapture = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x907C310", Offset = "0x907B310", VA = "0x18907C310")]
		private static KCTEBMTLOGD.Options FHMNNTVSRML(VideoEncoderHints a, string b)
		{
			return default(KCTEBMTLOGD.Options);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x907CFF0", Offset = "0x907BFF0", VA = "0x18907CFF0")]
		private static bool GZUULBIAHUZ(string a, VideoEncoderHints b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9083620", Offset = "0x9082620", VA = "0x189083620")]
		protected void WSAALPPSURX(string a, VideoEncoderHints b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x90838F0", Offset = "0x90828F0", VA = "0x1890838F0")]
		private void YNEYRNNTXMX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x907ECF0", Offset = "0x907DCF0", VA = "0x18907ECF0")]
		private bool PIKRWMWJAWQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x907BCE0", Offset = "0x907ACE0", VA = "0x18907BCE0")]
		protected bool DPUNMQYMTZM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9082F50", Offset = "0x9081F50", VA = "0x189082F50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x907D920", Offset = "0x907C920", VA = "0x18907D920")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9083800", Offset = "0x9082800", VA = "0x189083800")]
		private void WYHPKXVHHHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x9081040", Offset = "0x9080040", VA = "0x189081040")]
		private void RHKBWJMUZBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x90838C0", Offset = "0x90828C0", VA = "0x1890838C0")]
		protected bool WYLDMMOJKTF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9082A10", Offset = "0x9081A10", VA = "0x189082A10")]
		protected bool UHDCZMNOXZC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x907D390", Offset = "0x907C390", VA = "0x18907D390")]
		public float GetProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x907E700", Offset = "0x907D700", VA = "0x18907E700")]
		protected float NZHBPAIBHHQ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x907D740", Offset = "0x907C740", VA = "0x18907D740")]
		protected bool JRRQHDDTKFV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x907E520", Offset = "0x907D520", VA = "0x18907E520")]
		protected void NDVTYJHBPWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x907C3A0", Offset = "0x907B3A0", VA = "0x18907C3A0")]
		protected void FWCGDWLLYVX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xD06510", Offset = "0xD05510", VA = "0x180D06510", Slot = "13")]
		public virtual Texture GetSideBySideTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x907E300", Offset = "0x907D300", VA = "0x18907E300")]
		protected void MWGZUULJOYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x907BFC0", Offset = "0x907AFC0", VA = "0x18907BFC0")]
		public void EncodeAudio(NativeArray<float> audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x907BEA0", Offset = "0x907AEA0", VA = "0x18907BEA0")]
		public void EncodeAudio(float[] audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x907EF50", Offset = "0x907DF50", VA = "0x18907EF50", Slot = "14")]
		public virtual void PreUpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x9082B50", Offset = "0x9081B50", VA = "0x189082B50", Slot = "15")]
		public virtual void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x907B8C0", Offset = "0x907A8C0", VA = "0x18907B8C0")]
		protected bool CEEBYSKPFRB(int a, int b, bool c = false, int d = 1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9080E00", Offset = "0x907FE00", VA = "0x189080E00")]
		protected RenderTexture QWOJQSAPPJU(Texture a, bool b = false, int c = 1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x907BC80", Offset = "0x907AC80", VA = "0x18907BC80")]
		protected void CQTVMTOVBSJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9082AF0", Offset = "0x9081AF0", VA = "0x189082AF0")]
		public void UpdateFPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9080CB0", Offset = "0x907FCB0", VA = "0x189080CB0")]
		protected int QMYBHUTMIOQ(Camera a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x907D1F0", Offset = "0x907C1F0", VA = "0x18907D1F0")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x907D530", Offset = "0x907C530", VA = "0x18907D530")]
		public static void GetResolution(Resolution res, int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x907E9D0", Offset = "0x907D9D0", VA = "0x18907E9D0")]
		protected static int OOYLAWGJKFT(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x90841E0", Offset = "0x90831E0", VA = "0x1890841E0")]
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
		private CodecType TMOSKPOXERY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private int NDVZGEMMBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private string JZSJBAOCCJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private bool HQRDYIFIMCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private MediaApi JTONDNJROUQ;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int RFMSXMRTOHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0xB7CE40", Offset = "0xB7BE40", VA = "0x180B7CE40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public string QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public MediaApi TPUCHMXOYSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xAF3A00", Offset = "0xAF2A00", VA = "0x180AF3A00", Slot = "6")]
			get
			{
				return default(MediaApi);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool DWXYXEDKUXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F00", Offset = "0xAD1F00", VA = "0x180AD2F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x9084960", Offset = "0x9083960", VA = "0x189084960")]
		public void JYNVOKMBIUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9084AC0", Offset = "0x9083AC0", VA = "0x189084AC0")]
		internal Codec(CodecType codecType, int index, string name, MediaApi api, bool hasConfigWindow = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class RBFGYZHWDGP : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private Codec[] NTSJPPGVMGX;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public Codec[] VSYXBHUCUEM
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public int WNETLZWSODY
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x2593620", Offset = "0x2592620", VA = "0x182593620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x908E230", Offset = "0x908D230", VA = "0x18908E230")]
		internal RBFGYZHWDGP(Codec[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x908E130", Offset = "0x908D130", VA = "0x18908E130")]
		public Codec ICXBGKKZZDU(string a, MediaApi b = MediaApi.Unknown)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x908E1D0", Offset = "0x908D1D0", VA = "0x18908E1D0")]
		public Codec OCDVVFAXWSJ(MediaApi a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x286F860", Offset = "0x286E860", VA = "0x18286F860", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class UESKTDKYIBM
	{
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static bool EPBLSBTIVIG;

		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private static RBFGYZHWDGP AXROUPZJCPK;

		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private static RBFGYZHWDGP DKSXBLSUVOV;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public static RBFGYZHWDGP DMRTTOLISDH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x908FAA0", Offset = "0x908EAA0", VA = "0x18908FAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public static RBFGYZHWDGP MMOUPVQSPVK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x908FA50", Offset = "0x908EA50", VA = "0x18908FA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x908F9B0", Offset = "0x908E9B0", VA = "0x18908F9B0")]
		private static void DKZIPMEUOVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x908F180", Offset = "0x908E180", VA = "0x18908F180")]
		private static void CVOPVGMWSTC()
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
	public class SNAIMBPGRQZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private DeviceType ULHFHREKNEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private int NDVZGEMMBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private string JZSJBAOCCJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private MediaApi JTONDNJROUQ;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public int RFMSXMRTOHH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xB7CE40", Offset = "0xB7BE40", VA = "0x180B7CE40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public string QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public MediaApi TPUCHMXOYSP
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530", Slot = "6")]
			get
			{
				return default(MediaApi);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x908E2A0", Offset = "0x908D2A0", VA = "0x18908E2A0")]
		internal SNAIMBPGRQZ(DeviceType a, int b, string c, MediaApi d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class LNFUSRERXGZ : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private SNAIMBPGRQZ[] XCRALZPROCP;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public SNAIMBPGRQZ[] SMYEWIBFITE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public int WNETLZWSODY
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x2593620", Offset = "0x2592620", VA = "0x182593620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x908C420", Offset = "0x908B420", VA = "0x18908C420")]
		internal LNFUSRERXGZ(SNAIMBPGRQZ[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x908C3C0", Offset = "0x908B3C0", VA = "0x18908C3C0")]
		public SNAIMBPGRQZ OCDVVFAXWSJ(MediaApi a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x286F860", Offset = "0x286E860", VA = "0x18286F860", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class ZUVAJXBUSPW
	{
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private static bool EPBLSBTIVIG;

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private static LNFUSRERXGZ DTVMBAPNGZX;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public static LNFUSRERXGZ MZLTHZBSSGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x9095090", Offset = "0x9094090", VA = "0x189095090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x9094BD0", Offset = "0x9093BD0", VA = "0x189094BD0")]
		private static void DKZIPMEUOVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x9094C70", Offset = "0x9093C70", VA = "0x189094C70")]
		private static void TVGGRDLKURU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class KCIIHHPYQAN : IDisposable
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
		private string YBDPPCKIQDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private int QTMGEYCWVKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private bool YETJYSETISR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private OutputTarget TBCKUFFOPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private KCTEBMTLOGD.Options BKXTYDEQRAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private ManualResetEvent XHOFGFUPICR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private CompletionStatus JNEDIAKRNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private string LFWQWTKHPHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private bool XBHWQAIIXPZ;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		internal Action<KCIIHHPYQAN> QNMJSOKKPTG
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xACDCB0", Offset = "0xACCCB0", VA = "0x180ACDCB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xACDF60", Offset = "0xACCF60", VA = "0x180ACDF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x9086C50", Offset = "0x9085C50", VA = "0x189086C50")]
		internal KCIIHHPYQAN(OutputTarget a, string b, int c, bool d, string e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9086800", Offset = "0x9085800", VA = "0x189086800")]
		internal void KMABTMNXAMS(KCTEBMTLOGD.Options a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x90869E0", Offset = "0x90859E0", VA = "0x1890869E0")]
		private bool XIXNHGRNOXW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9086820", Offset = "0x9085820", VA = "0x189086820")]
		public bool LLRZXAUVASY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9086510", Offset = "0x9085510", VA = "0x189086510", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class KCTEBMTLOGD
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
			[Cpp2IlInjected.Address(RVA = "0x908DFA0", Offset = "0x908CFA0", VA = "0x18908DFA0")]
			public bool JURRFTWGFLT()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x908DF80", Offset = "0x908CF80", VA = "0x18908DF80")]
			public bool JDNNLPVKXGY()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x908DFC0", Offset = "0x908CFC0", VA = "0x18908DFC0")]
			public void MVFBEUGGBBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class CGRWUGMBPZO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400025A")]
			public uint DGDYKRNABMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400025B")]
			public long IQEEXZRKUZU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400025C")]
			public long AAQXFRKABBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public long ZPLMWCJEZPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public long FEIPBTSQQBT;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public CGRWUGMBPZO()
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
		private sealed class LASOGALVDZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			public string XOEOBLGVAXU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000266")]
			public bool SZJRLHRWATC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public Options AMZKTDPLWHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			public ManualResetEvent YNCGYAUBPCA;

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public LASOGALVDZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x908C2D0", Offset = "0x908B2D0", VA = "0x18908C2D0")]
			internal void NWBRVQUQGUG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private static readonly uint WXZMFMJUVTA;

		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private static readonly uint ERUTQGEQAJV;

		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private static readonly uint SMLYRMEZNIO;

		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private static readonly uint PLKWEAVNCMN;

		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private static readonly uint DBOADTAGIEQ;

		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private static readonly uint XCOJIFRLTMF;

		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private static readonly uint MMGALQEGMWN;

		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private static readonly uint SHKFSLSQAGW;

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private static readonly uint ANAZNZDFDTE;

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private static readonly uint VXIFJMBLXBB;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private static readonly uint DZLELNRABUP;

		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private static readonly uint FRNMWOCQYSU;

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private static readonly uint PILHZKJRIVD;

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private static readonly uint SDYOVYKITKJ;

		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private static readonly uint NHUAIRBXEFR;

		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private static readonly uint LJZZVYLAQHK;

		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private static readonly uint NEOJZRQCDJP;

		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private static readonly uint JVUSUELLBVQ;

		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private static readonly uint TTHBMVGYKFW;

		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private static readonly uint LZFGKOWUNQJ;

		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private static readonly uint XLUJDQCDLUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private BinaryReader DGSCWXWZJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private Stream GQDYBMNZDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private Options STSWIGAYHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private bool MYMAGAISLVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private List<CGRWUGMBPZO> IPRPPCYAZLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private List<CGRWUGMBPZO> MPUWKOQKKOL;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9089960", Offset = "0x9088960", VA = "0x189089960")]
		public static ManualResetEvent NGKNQKEZKVU(string a, bool b, Options c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x908AB10", Offset = "0x9089B10", VA = "0x18908AB10")]
		public static bool TATIRKUXBYG(string a, bool b, Options c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x908AE60", Offset = "0x9089E60", VA = "0x18908AE60")]
		public static bool TATIRKUXBYG(string a, string b, Options c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x908C200", Offset = "0x908B200", VA = "0x18908C200")]
		public KCTEBMTLOGD(Options a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9088900", Offset = "0x9087900", VA = "0x189088900")]
		public bool GUFVSJSIKBC(Stream a, Stream b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9087780", Offset = "0x9086780", VA = "0x189087780")]
		public void Close()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x90870F0", Offset = "0x90860F0", VA = "0x1890870F0")]
		private static CGRWUGMBPZO CRHOOYDOBWL(uint a, List<CGRWUGMBPZO> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9088240", Offset = "0x9087240", VA = "0x189088240")]
		private List<CGRWUGMBPZO> ECZECAASITL(CGRWUGMBPZO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x9088030", Offset = "0x9087030", VA = "0x189088030")]
		private List<CGRWUGMBPZO> ECZECAASITL(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x908B450", Offset = "0x908A450", VA = "0x18908B450")]
		private CGRWUGMBPZO YYGVJMCPQEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x9088730", Offset = "0x9087730", VA = "0x189088730")]
		private bool GIPVFDBYOTV(CGRWUGMBPZO a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x9089130", Offset = "0x9088130", VA = "0x189089130")]
		private void JSMDCWGBWHJ(CGRWUGMBPZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x9088890", Offset = "0x9087890", VA = "0x189088890")]
		private void GRJSUCZPTOC(CGRWUGMBPZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x908A170", Offset = "0x9089170", VA = "0x18908A170")]
		private void PDEVDRBYVIK(CGRWUGMBPZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x9086FE0", Offset = "0x9085FE0", VA = "0x189086FE0")]
		private void BSMMQLBEHZX(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x90891A0", Offset = "0x90881A0", VA = "0x1890891A0")]
		private void JTEMTPEKFRD(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x9087860", Offset = "0x9086860", VA = "0x189087860")]
		private uint DPXVNHEJWPR(CGRWUGMBPZO a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x9088520", Offset = "0x9087520", VA = "0x189088520")]
		private bool FQPGRBUZQTP(CGRWUGMBPZO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x908B240", Offset = "0x908A240", VA = "0x18908B240")]
		private void WWYODNOESVP(CGRWUGMBPZO a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x9089B90", Offset = "0x9088B90", VA = "0x189089B90")]
		private void OHHHDCETGRJ(CGRWUGMBPZO a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x9089750", Offset = "0x9088750", VA = "0x189089750")]
		private void MSBUTZAJJUE(CGRWUGMBPZO a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x908A2F0", Offset = "0x90892F0", VA = "0x18908A2F0")]
		private uint RBWARYXWTRN(CGRWUGMBPZO a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x9087230", Offset = "0x9086230", VA = "0x189087230")]
		private uint CVTBNVLTBRC(CGRWUGMBPZO a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9088710", Offset = "0x9087710", VA = "0x189088710")]
		private static StereoMode_st3d FWUAFRWRDWS(StereoPacking a)
		{
			return default(StereoMode_st3d);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x90883B0", Offset = "0x90873B0", VA = "0x1890883B0")]
		private uint FJHBWEMPMFW(StereoMode_st3d a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x908A910", Offset = "0x9089910", VA = "0x18908A910")]
		private uint SHOFCNQITYW(SphericalVideoLayout a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x908A4A0", Offset = "0x90894A0", VA = "0x18908A4A0")]
		private uint RFPECJSTVYM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x9086CD0", Offset = "0x9085CD0", VA = "0x189086CD0")]
		private uint BKVUXWQROEB(string a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x9087E40", Offset = "0x9086E40", VA = "0x189087E40")]
		private uint DZVNQMHZHEP(SphericalVideoLayout a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x9089360", Offset = "0x9088360", VA = "0x189089360")]
		private uint LWINLVWXNAG()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x9089DA0", Offset = "0x9088DA0", VA = "0x189089DA0")]
		private uint OMOGRFSXOXO()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x9089250", Offset = "0x9088250", VA = "0x189089250")]
		private void KSPAWSSBXQU(CGRWUGMBPZO a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x9086F70", Offset = "0x9085F70", VA = "0x189086F70")]
		private ushort BNEFGWZNYDK()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x9089B20", Offset = "0x9088B20", VA = "0x189089B20")]
		private uint NNLYNOMNQFM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x908B140", Offset = "0x908A140", VA = "0x18908B140")]
		private ulong VPQJKFMQAGV()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x908A270", Offset = "0x9089270", VA = "0x18908A270")]
		private void PRTDZZBGGVY(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x9088310", Offset = "0x9087310", VA = "0x189088310")]
		private void ENOKONUSKAP(uint a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x908B1B0", Offset = "0x908A1B0", VA = "0x18908B1B0")]
		private void WLJZRWUPZZG(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x90896C0", Offset = "0x90886C0", VA = "0x1890896C0")]
		private static uint MFUJFEIOPDX(string a)
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
		public static string[] YTMGIVNLRPD;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static string[] MRGSDRVQMJT;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static string[] USLRDRZFGPH;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static string[] KEROGOEXOVB;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x908FF60", Offset = "0x908EF60", VA = "0x18908FF60")]
		public static string[] GIMPCCHNUCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9090080", Offset = "0x908F080", VA = "0x189090080")]
		public static RenderTextureFormat MCXEYGPKFMJ(bool a, bool b, bool c)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x90903E0", Offset = "0x908F3E0", VA = "0x1890903E0")]
		public static bool QIPJHPTEUQP(Camera a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9090760", Offset = "0x908F760", VA = "0x189090760")]
		public static Camera[] ZBHOLUFKZXC(Camera a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x908FE20", Offset = "0x908EE20", VA = "0x18908FE20")]
		public static bool CKIEULLJZWC(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9090670", Offset = "0x908F670", VA = "0x189090670")]
		public static bool TRJTPVFUWAE(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9090480", Offset = "0x908F480", VA = "0x189090480")]
		public static bool RKILUJZDTFQ(string a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x908FFD0", Offset = "0x908EFD0", VA = "0x18908FFD0")]
		public static string HJPEKBVLGPX(ImageSequenceFormat a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class IFRGAVXNJNC : IDisposable
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
		private static byte[] SYBGNEBRSGG;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private static byte[] OCLXBAOAGHO;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private static byte[] UTPAGLMRJUX;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private static byte[] IZQUEUCUEIU;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static byte[] KGTAXSTBCNA;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static byte[] EVAUVLZNBPO;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static byte[] YWMYWLHECUW;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private const int YPZMOZUAJDT = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private FileStream YAKCFZHPOIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private byte[] WKHUWKWVPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private int YQRIQBZKVLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private int GLMWWULPKMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private int GPAZSNCASVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private int LFMRGEJKCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private SampleFormat KLDEQICCRTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private int NUSDAMHMEDG;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x9085930", Offset = "0x9084930", VA = "0x189085930")]
		public IFRGAVXNJNC(string a, int b, int c, SampleFormat d = SampleFormat.Float32)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x9084E50", Offset = "0x9083E50", VA = "0x189084E50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x9084ED0", Offset = "0x9083ED0", VA = "0x189084ED0")]
		public void OVZOXMXLZFT(float[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x9085060", Offset = "0x9084060", VA = "0x189085060")]
		public void SEATNTUELEP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x9084D40", Offset = "0x9083D40", VA = "0x189084D40")]
		private static byte[] BBZJEHKIIHA(int a, int b = 2)
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
		[Cpp2IlInjected.Address(RVA = "0x9095260", Offset = "0x9094260", VA = "0x189095260")]
		public void RunCoroutine(IEnumerator routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
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

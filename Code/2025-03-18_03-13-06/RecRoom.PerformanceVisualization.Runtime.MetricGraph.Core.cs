using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.DataStructures;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IABFKPKPGGO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xFEDAC0", Offset = "0xFECCC0", VA = "0x180FEDAC0")]
	public static Color BMPKLFLPABB(this RRColor JLNFDAODDKP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x79359D0", Offset = "0x7934BD0", VA = "0x1879359D0")]
	public static Color BMPKLFLPABB(this RRColor32 JLNFDAODDKP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7935A30", Offset = "0x7934C30", VA = "0x187935A30")]
	public static Color32 EHKJHIMOOJH(this RRColor32 JLNFDAODDKP)
	{
		return default(Color32);
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricGraph : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private ProfilerMarker LNBCDLEOFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ProfilerMarker KEOLFNMKGDL;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int ENCPMFDAPFC = 8;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int IKALFPCDLCH = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private KJBNOJFNNJK AHOPKNCLEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool JOCIOLPINKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private float NPFOONJEJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float PNEKPNJLHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float OOOAENCANEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private float LJDDBJPLKKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float OOCALANAAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Header("Graph")]
		[SerializeField]
		private RawImage graphImageTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Space]
		[SerializeField]
		[FormerlySerializedAs("graphImageShaderFull")]
		private Shader shaderFull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		[FormerlySerializedAs("graphImageShaderLight")]
		private Shader shaderLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private bool useLightShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Header("Graph Visuals")]
		[SerializeField]
		private bool isZeroBased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[Range(1f, 10f)]
		private float resolutionScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private Color baseValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[Space]
		private bool showAverageBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private Color averageBarColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		[Space]
		private bool showThresholdBars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private int cautionValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Color cautionValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private int criticalValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Color criticalValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FIPIHBDIHLK IDDCDEHPMGA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int HBHENBOHNCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7937AC0", Offset = "0x7936CC0", VA = "0x187937AC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int GPDDAECJENB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7937AA0", Offset = "0x7936CA0", VA = "0x187937AA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int KHLPGECHBCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7937850", Offset = "0x7936A50", VA = "0x187937850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int NHHFIFKGLHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7938250", Offset = "0x7937450", VA = "0x187938250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int PHGDIGAGFEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7938220", Offset = "0x7937420", VA = "0x187938220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float HLLAPLGDFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7938180", Offset = "0x7937380", VA = "0x187938180")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float JKONFGMAKAD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x79381C0", Offset = "0x79373C0", VA = "0x1879381C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float IKLJHKHNDCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x79381A0", Offset = "0x79373A0", VA = "0x1879381A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float EHINIDAHBHB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x79381E0", Offset = "0x79373E0", VA = "0x1879381E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float BJJEFCCKAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7938200", Offset = "0x7937400", VA = "0x187938200")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x79374C0", Offset = "0x79366C0", VA = "0x1879374C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7937AE0", Offset = "0x7936CE0", VA = "0x187937AE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7937EB0", Offset = "0x79370B0", VA = "0x187937EB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7937B40", Offset = "0x7936D40", VA = "0x187937B40")]
		public void PushSample(double BKIMJPOFLFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x79374F0", Offset = "0x79366F0", VA = "0x1879374F0")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7937520", Offset = "0x7936720", VA = "0x187937520")]
		private void FNMNEAGFCEP(bool CPGNGBBHKKK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7937B70", Offset = "0x7936D70", VA = "0x187937B70")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x79378B0", Offset = "0x7936AB0", VA = "0x1879378B0")]
		public void InitData(int GNBJDOHEFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7936F50", Offset = "0x7936150", VA = "0x187936F50")]
		private void AEMBFBFCPAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7937EE0", Offset = "0x79370E0", VA = "0x187937EE0")]
		public MetricGraph()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RequireComponent(typeof(CanvasRenderer))]
	public class MetricGraphGraphic : Graphic
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private FIPIHBDIHLK IDDCDEHPMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private KJBNOJFNNJK OHDODJOALAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Material PPMCLOMIOLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool ADDIEPFHGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private bool isZeroBased;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7936EE0", Offset = "0x79360E0", VA = "0x187936EE0")]
		protected MetricGraphGraphic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x79362C0", Offset = "0x79354C0", VA = "0x1879362C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x79363A0", Offset = "0x79355A0", VA = "0x1879363A0")]
		private void PDAIGIIELDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x79362E0", Offset = "0x79354E0", VA = "0x1879362E0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7936750", Offset = "0x7935950", VA = "0x187936750")]
		public void UpdateData(double OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7936900", Offset = "0x7935B00", VA = "0x187936900")]
		public void UpdateThreshold(double AGIDBEFNMGN, double MCCMNENLGIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7936980", Offset = "0x7935B80", VA = "0x187936980")]
		public void UpdateThreshold(double AGIDBEFNMGN, double MCCMNENLGIL, RRColor32 FJNKCFIGEIG, RRColor32 LKLMGNINJEE, RRColor32 KGKFILKCBME, RRColor32 PMENIBEBGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7936B90", Offset = "0x7935D90", VA = "0x187936B90")]
		public void UpdateThreshold(EOLCDKAAMNC HPGHHNICBBG, double DIOKPOCPBHH = 1.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7936620", Offset = "0x7935820", VA = "0x187936620")]
		public void ResetValues()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[DefaultMember("Item")]
public class KJBNOJFNNJK : IEnumerable<float>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MPOACBAGELF : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private float <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public KJBNOJFNNJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		float IEnumerator<float>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xC00560", Offset = "0xBFF760", VA = "0x180C00560", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7936270", Offset = "0x7935470", VA = "0x187936270", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public MPOACBAGELF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7936190", Offset = "0x7935390", VA = "0x187936190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7936220", Offset = "0x7935420", VA = "0x187936220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float[] LAANAMEMAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private float CDNAEODPMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private float PLIBGNKHNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private float NHHEMFHDGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int OILBALNBBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private int IPBKHOJKHLJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x96C080", Offset = "0x96B280", VA = "0x18096C080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AABBHHFGOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x100BD90", Offset = "0x100AF90", VA = "0x18100BD90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float LCOIPMAPFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7935A60", Offset = "0x7934C60", VA = "0x187935A60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float AIBIHEAKBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7935A90", Offset = "0x7934C90", VA = "0x187935A90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float IGDPMPOJLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDE8360", Offset = "0xDE7560", VA = "0x180DE8360")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float NPLAJLEGCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xC30C00", Offset = "0xC2FE00", VA = "0x180C30C00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float OAKOHPICOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7935BB0", Offset = "0x7934DB0", VA = "0x187935BB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7935170", Offset = "0x7934370", VA = "0x187935170")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7936110", Offset = "0x7935310", VA = "0x187936110")]
	public KJBNOJFNNJK(int ECPBKIMJCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7935C00", Offset = "0x7934E00", VA = "0x187935C00")]
	public void PEPNFGPGDFJ(int KFOBHJHKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7935C90", Offset = "0x7934E90", VA = "0x187935C90")]
	public void PIDPBEAMAMD(float OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7935A70", Offset = "0x7934C70", VA = "0x187935A70")]
	public void DKMKPGNLIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7935220", Offset = "0x7934420", VA = "0x187935220")]
	public void HILIPOONKEH(float[] CGKPJBPKLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7935AA0", Offset = "0x7934CA0", VA = "0x187935AA0")]
	public void HILIPOONKEH(float[] CGKPJBPKLPJ, int EFPNGBMKDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7935BD0", Offset = "0x7934DD0", VA = "0x187935BD0")]
	private int MNJBJGFNCAD(int KOOLKCPAFBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7935FE0", Offset = "0x79351E0", VA = "0x187935FE0", Slot = "4")]
	[IteratorStateMachine(typeof(MPOACBAGELF))]
	IEnumerator<float> IEnumerable<float>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7936060", Offset = "0x7935260", VA = "0x187936060", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FIPIHBDIHLK
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const int OEPLLGEAHCA = 512;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const int LLPCKACLMHH = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int ILNGMHAIIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float[] PMKHKJODFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Material MDMIJJAMBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float BNFECANPNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float HDELPELBINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float HKKPOONJDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float EKNDADFOKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float MNNLBFGBNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Color DLDNNNCEPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color ECAODOJOGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color NKPPELAINLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Color ELLJPMMPHKA;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly int ALFMDKAPBDH;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly int EEOOIOKMJKB;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int NFKJDMBNBKM;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int PHHLBMJKDNO;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int JHBKELAJIFL;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int PAOLOGNJEKK;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int LNLDPMPOEJN;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int CPPOBFFDPAL;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int DCNMEHCJAKF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly int JFCMLMAAHEF;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly int FJHKGNALJAD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Material ECAGAIIDDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7935680", Offset = "0x7934880", VA = "0x187935680")]
	public void NEAHODOHJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7935600", Offset = "0x7934800", VA = "0x187935600")]
	public void KGAOJEECJAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7935720", Offset = "0x7934920", VA = "0x187935720")]
	public void OPONAFLDKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x79354C0", Offset = "0x79346C0", VA = "0x1879354C0")]
	public void BOIDMOHLIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x79353A0", Offset = "0x79345A0", VA = "0x1879353A0")]
	public void APHHGIAOEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7935320", Offset = "0x7934520", VA = "0x187935320")]
	public void AFPKNGDFGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7935560", Offset = "0x7934760", VA = "0x187935560")]
	public void CIDAIBGHDGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7935980", Offset = "0x7934B80", VA = "0x187935980")]
	public FIPIHBDIHLK()
	{
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

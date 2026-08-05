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
public static class IPHEOEKPPKA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x10C2A70", Offset = "0x10C1E70", VA = "0x1810C2A70")]
	public static Color KBNPLMHMLEL(this RRColor JLFKDHGAEDA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7E53930", Offset = "0x7E52D30", VA = "0x187E53930")]
	public static Color KBNPLMHMLEL(this RRColor32 JLFKDHGAEDA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7E53990", Offset = "0x7E52D90", VA = "0x187E53990")]
	public static Color32 PBCKMHEFDBJ(this RRColor32 JLFKDHGAEDA)
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
		private ProfilerMarker CGOAMNKKBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ProfilerMarker JCIPPKNNLKB;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int GFBKPDPDMPB = 8;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int PDAGFJKANFC = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private OIALCPPLIJO NAPOCANBDLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool EJDLBNPMEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private float KKMDLKPHIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float PBEDMCKHEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float KELEDHJDKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private float EHFDILBGFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float IGDBHIBAOKG;

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
		private HKFIBLLEOOE CFDAJOCOANC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int OGJOJGLJGGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7E54C60", Offset = "0x7E54060", VA = "0x187E54C60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int GGJPPMFLFGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7E54710", Offset = "0x7E53B10", VA = "0x187E54710")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int JLEDNLOBPFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7E54680", Offset = "0x7E53A80", VA = "0x187E54680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int PEBKEEMKHOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7E557C0", Offset = "0x7E54BC0", VA = "0x187E557C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int MGOOHJAFAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7E55790", Offset = "0x7E54B90", VA = "0x187E55790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float CHHPEPGLKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7E556F0", Offset = "0x7E54AF0", VA = "0x187E556F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float FCBJOPLGOPM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7E55730", Offset = "0x7E54B30", VA = "0x187E55730")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float AEENMDLADLP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7E55710", Offset = "0x7E54B10", VA = "0x187E55710")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float DPBKPNANOHK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7E55750", Offset = "0x7E54B50", VA = "0x187E55750")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float HICBLIKPAJC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7E55770", Offset = "0x7E54B70", VA = "0x187E55770")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7E54650", Offset = "0x7E53A50", VA = "0x187E54650")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7E55090", Offset = "0x7E54490", VA = "0x187E55090")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7E55420", Offset = "0x7E54820", VA = "0x187E55420")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7E550F0", Offset = "0x7E544F0", VA = "0x187E550F0")]
		public void PushSample(double IJPADIKGILO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E546E0", Offset = "0x7E53AE0", VA = "0x187E546E0")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E54E30", Offset = "0x7E54230", VA = "0x187E54E30")]
		private void MJGAEJCENGN(bool IMJBLFBLNHJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7E55120", Offset = "0x7E54520", VA = "0x187E55120")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7E54C80", Offset = "0x7E54080", VA = "0x187E54C80")]
		public void InitData(int OMCPOCCPPKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7E54730", Offset = "0x7E53B30", VA = "0x187E54730")]
		private void DEDMBJAMIMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7E55450", Offset = "0x7E54850", VA = "0x187E55450")]
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
		private HKFIBLLEOOE CFDAJOCOANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private OIALCPPLIJO PDFIIAGDKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Material NOAPEDMMBEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool PDPDDGEPMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private bool isZeroBased;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7E545E0", Offset = "0x7E539E0", VA = "0x187E545E0")]
		protected MetricGraphGraphic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7E539C0", Offset = "0x7E52DC0", VA = "0x187E539C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7E539E0", Offset = "0x7E52DE0", VA = "0x187E539E0")]
		private void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7E53C60", Offset = "0x7E53060", VA = "0x187E53C60", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7E53E50", Offset = "0x7E53250", VA = "0x187E53E50")]
		public void UpdateData(double OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7E54000", Offset = "0x7E53400", VA = "0x187E54000")]
		public void UpdateThreshold(double DBAEPGLKNOD, double EKLNDMMLIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7E54080", Offset = "0x7E53480", VA = "0x187E54080")]
		public void UpdateThreshold(double DBAEPGLKNOD, double EKLNDMMLIEO, RRColor32 MMFEOPPFIJC, RRColor32 MKOEBBKNBJN, RRColor32 IEALAGILHPG, RRColor32 GKJLAOKCDMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7E54290", Offset = "0x7E53690", VA = "0x187E54290")]
		public void UpdateThreshold(EMJEOJIPPNL CFPCKNKGLEN, double KPABPLHPKDL = 1.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7E53D20", Offset = "0x7E53120", VA = "0x187E53D20")]
		public void ResetValues()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[DefaultMember("Item")]
public class OIALCPPLIJO : IEnumerable<float>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class CMODJALOCOO : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private float <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public OIALCPPLIJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		float IEnumerator<float>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCE79E0", Offset = "0xCE6DE0", VA = "0x180CE79E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E531D0", Offset = "0x7E525D0", VA = "0x187E531D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public CMODJALOCOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7E530F0", Offset = "0x7E524F0", VA = "0x187E530F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7E53180", Offset = "0x7E52580", VA = "0x187E53180", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float[] AMDILILIPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private float JLCBKIPFKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private float CBHAMKJGEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private float LNCLNNJFMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int IJGPOKIMDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private int PCGLBCNIEAP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCD0", Offset = "0x9CF0D0", VA = "0x1809CFCD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MMGEIDHINCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x24F59F0", Offset = "0x24F4DF0", VA = "0x1824F59F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float LNPKCLNKNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7E55A00", Offset = "0x7E54E00", VA = "0x187E55A00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float IEEDKBNAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7E558A0", Offset = "0x7E54CA0", VA = "0x187E558A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float LKNPCGIHJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xEA4540", Offset = "0xEA3940", VA = "0x180EA4540")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float FLGIKOJBIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCF3E70", Offset = "0xCF3270", VA = "0x180CF3E70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float JDNIOAMLCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7E558B0", Offset = "0x7E54CB0", VA = "0x187E558B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7E53040", Offset = "0x7E52440", VA = "0x187E53040")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E55E90", Offset = "0x7E55290", VA = "0x187E55E90")]
	public OIALCPPLIJO(int NPKCINNDJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E557E0", Offset = "0x7E54BE0", VA = "0x187E557E0")]
	public void BPHEKBLMHPA(int JLGCIBOFIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7E55A10", Offset = "0x7E54E10", VA = "0x187E55A10")]
	public void OACBNFHCBPB(float OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E559E0", Offset = "0x7E54DE0", VA = "0x187E559E0")]
	public void LEMPIPADENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E52F40", Offset = "0x7E52340", VA = "0x187E52F40")]
	public void JKHKHNOLKLL(float[] EJCNBBIIFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E558D0", Offset = "0x7E54CD0", VA = "0x187E558D0")]
	public void JKHKHNOLKLL(float[] EJCNBBIIFBE, int MIDKAKMDFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E55870", Offset = "0x7E54C70", VA = "0x187E55870")]
	private int EGFKMPAPILE(int COPLIEINKOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E55D60", Offset = "0x7E55160", VA = "0x187E55D60", Slot = "4")]
	[IteratorStateMachine(typeof(CMODJALOCOO))]
	IEnumerator<float> IEnumerable<float>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E55DE0", Offset = "0x7E551E0", VA = "0x187E55DE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HKFIBLLEOOE
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const int NOLDFOCOCFD = 512;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const int IHFEGBJBCLL = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int PGDMLKNCLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float[] APIACPGLDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Material FFHFAEDNMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float CJIFMFPPIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float BBPANCAFOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float FHFGJMIHOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float ENIKBFJPIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float BNDOFGMADKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Color NCICFMBOLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color GGPBKACNPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color OEHCBIHHENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Color DBMCEPNIMNO;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly int PHBKECFBFML;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly int GABGHENKFHO;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int PHAHGDKJMED;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int EJJCDJIBOJJ;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int EBGNJOBOFLG;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int IAKKLCKCGID;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int DJEGFOFMGLG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int CLOKDGAAHGP;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int KFBEALLEBFK;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly int PPLPHNBFAFM;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly int HNDEAPMDGCL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Material KGJJNNOKCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9CCC50", Offset = "0x9CC050", VA = "0x1809CCC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7E533C0", Offset = "0x7E527C0", VA = "0x187E533C0")]
	public void EELINHCCGMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7E53460", Offset = "0x7E52860", VA = "0x187E53460")]
	public void FFCNODMKIIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E53650", Offset = "0x7E52A50", VA = "0x187E53650")]
	public void NIMMCICGNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E534F0", Offset = "0x7E528F0", VA = "0x187E534F0")]
	public void FJPOBKJJFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E532A0", Offset = "0x7E526A0", VA = "0x187E532A0")]
	public void DNEDKCPNMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7E53220", Offset = "0x7E52620", VA = "0x187E53220")]
	public void DHFJCEDFEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7E535A0", Offset = "0x7E529A0", VA = "0x187E535A0")]
	public void JBMKKCFOFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7E538E0", Offset = "0x7E52CE0", VA = "0x187E538E0")]
	public HKFIBLLEOOE()
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

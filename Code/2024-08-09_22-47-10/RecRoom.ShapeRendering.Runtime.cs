using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.ClusterLODs;
using RecRoom.Configs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ShapeRendering;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : DLJCNHBICIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x724F210", Offset = "0x724E610", VA = "0x18724F210", Slot = "4")]
		public override void NLGJOIAOEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GGGPINCJGFA : MAAHJOMNMJG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte COMKIJCJGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] OKAMBHKEIDC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OMOIFBIPLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9874E0", Offset = "0x9868E0", VA = "0x1809874E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x986F90", Offset = "0x986390", VA = "0x180986F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PBNCIMLDBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88BB00", Offset = "0x88AF00", VA = "0x18088BB00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88B150", Offset = "0x88A550", VA = "0x18088B150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float EHAFEKBEHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x95D460", Offset = "0x95C860", VA = "0x18095D460", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA5F670", Offset = "0xA5EA70", VA = "0x180A5F670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float NDKBDAMGANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x95D4C0", Offset = "0x95C8C0", VA = "0x18095D4C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9A0", Offset = "0xA5EDA0", VA = "0x180A5F9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> PHBNOOANLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72498F0", Offset = "0x7248CF0", VA = "0x1872498F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> FFDMGPFEJHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72498C0", Offset = "0x7248CC0", VA = "0x1872498C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject JIDLAENMFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x851800", Offset = "0x850C00", VA = "0x180851800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte KIELDLDIMFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7249870", Offset = "0x7248C70", VA = "0x187249870", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7249BB0", Offset = "0x7248FB0", VA = "0x187249BB0")]
	public GGGPINCJGFA(List<BJDFAEALIDP> GGOPOOGMNGP, List<BJDFAEALIDP> HDFBABJNNGH, List<DNCGBCFJOKI> PGFDOBDONPF, Material JOFMGPCHADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7249A90", Offset = "0x7248E90", VA = "0x187249A90")]
	private int PKGEGPGBNGG(List<BJDFAEALIDP> PGOOPHHPJBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72495D0", Offset = "0x72489D0", VA = "0x1872495D0")]
	private void DJBICCIPGJG(int EGHNPAJPDPL, bool LIFMKOAECLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7249940", Offset = "0x7248D40", VA = "0x187249940")]
	public void MFHANOEGLLP(Vector3 CDIBDMKFKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7249770", Offset = "0x7248B70", VA = "0x187249770", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7249730", Offset = "0x7248B30", VA = "0x187249730")]
	public void DOIJCLLDGDF(Transform LFGKPMGGNAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EJFEHMBHHJL : HLCLGNMDMFP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class FMKJHJCFAPJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EJFEHMBHHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x89EDF0", Offset = "0x89E1F0", VA = "0x18089EDF0")]
		[DebuggerHidden]
		public FMKJHJCFAPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7248320", Offset = "0x7247720", VA = "0x187248320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7247CC0", Offset = "0x72470C0", VA = "0x187247CC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7247C70", Offset = "0x7247070", VA = "0x187247C70")]
		private void HMGBLPCOLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x72481D0", Offset = "0x72475D0", VA = "0x1872481D0")]
		private void OANBEGBCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7247C20", Offset = "0x7247020", VA = "0x187247C20")]
		private void EGIGMFAGLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72482D0", Offset = "0x72476D0", VA = "0x1872482D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7248220", Offset = "0x7247620", VA = "0x187248220", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7248220", Offset = "0x7247620", VA = "0x187248220", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class ADPLFONEGOJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public EJFEHMBHHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x89EDF0", Offset = "0x89E1F0", VA = "0x18089EDF0")]
		[DebuggerHidden]
		public ADPLFONEGOJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7242AF0", Offset = "0x7241EF0", VA = "0x187242AF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7242630", Offset = "0x7241A30", VA = "0x187242630", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72425E0", Offset = "0x72419E0", VA = "0x1872425E0")]
		private void HMGBLPCOLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72429A0", Offset = "0x7241DA0", VA = "0x1872429A0")]
		private void OANBEGBCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7242AA0", Offset = "0x7241EA0", VA = "0x187242AA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x72429F0", Offset = "0x7241DF0", VA = "0x1872429F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x72429F0", Offset = "0x7241DF0", VA = "0x1872429F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly JGFLLGGENAN KNLBLOKDGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<JIJHAFAALOB> DOGBBLEKCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> DELMIMBAEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer PBMHKILDDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool PKNLHCACEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool IEHGPKOPAOI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<MHOPGKFJMAL> NBBGPMALEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MDBFFCDFCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7246770", Offset = "0x7245B70", VA = "0x187246770", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DNCGBCFJOKI JAIMKBEADMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72462D0", Offset = "0x72456D0", VA = "0x1872462D0", Slot = "8")]
		get
		{
			return default(DNCGBCFJOKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> LADDKAFNDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8541A0", Offset = "0x8535A0", VA = "0x1808541A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7247280", Offset = "0x7246680", VA = "0x187247280")]
	private bool LLBFEPFNBIE(JIJHAFAALOB HNIPAMKIPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7246E50", Offset = "0x7246250", VA = "0x187246E50")]
	private static bool ICOLCNBJBJM(JIJHAFAALOB HNIPAMKIPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7247A60", Offset = "0x7246E60", VA = "0x187247A60")]
	public EJFEHMBHHJL(JGFLLGGENAN LDNEPNAGEGN, bool NGILHLJDDKK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x72465F0", Offset = "0x72459F0", VA = "0x1872465F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7246CB0", Offset = "0x72460B0", VA = "0x187246CB0")]
	public void HINMMBAADBG(JIJHAFAALOB HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7247160", Offset = "0x7246560", VA = "0x187247160")]
	public void LHAIFCNDDDC(JIJHAFAALOB HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72467B0", Offset = "0x7245BB0", VA = "0x1872467B0", Slot = "4")]
	public void GNOPDDNOPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72463A0", Offset = "0x72457A0", VA = "0x1872463A0")]
	public void DKKALNJCGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7246F20", Offset = "0x7246320", VA = "0x187246F20")]
	private void JCEOEBNNEBE(List<JIJHAFAALOB> DOGBBLEKCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7242DE0", Offset = "0x72421E0", VA = "0x187242DE0")]
	private static Material HJLKGJOKDIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7246E70", Offset = "0x7246270", VA = "0x187246E70")]
	private void JCEOEBNNEBE(JIJHAFAALOB HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7247850", Offset = "0x7246C50", VA = "0x187247850")]
	private void OMIAMNNPOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72472A0", Offset = "0x72466A0", VA = "0x1872472A0")]
	public void MJKKEGJPNGI(bool JEBNCKHDLDC, bool MJCLIPJCPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x72479A0", Offset = "0x7246DA0", VA = "0x1872479A0")]
	protected void PNGLGAIMBKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x72470E0", Offset = "0x72464E0", VA = "0x1872470E0")]
	[IteratorStateMachine(typeof(FMKJHJCFAPJ))]
	public IEnumerable<Renderer> JKDFPALJNLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7247920", Offset = "0x7246D20", VA = "0x187247920")]
	[IteratorStateMachine(typeof(ADPLFONEGOJ))]
	public IEnumerable<Renderer> PDBMPHFLHIB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class KAODOIENMMH : JIJHAFAALOB
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct DKBIDFBBFNL : PMNCEEDNKGK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private AGIFCHBLDPN GFKLPJBCEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle DBNLEGDAPHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private HHHCDBIAJNM HDGHGPJIHNG;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7246270", Offset = "0x7245670", VA = "0x187246270")]
		public DKBIDFBBFNL(AGIFCHBLDPN GFKLPJBCEPF, JobHandle DBNLEGDAPHE, HHHCDBIAJNM HDGHGPJIHNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7246240", Offset = "0x7245640", VA = "0x187246240", Slot = "4")]
		public AGIFCHBLDPN IBMHMHPCIDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x72461F0", Offset = "0x72455F0", VA = "0x1872461F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly CCJOPIDFGGK FENKEBGBPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float BAHHEOBFIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 EGFBGKKIGNK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 OFJEKOAJDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x724D6C0", Offset = "0x724CAC0", VA = "0x18724D6C0", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x724F110", Offset = "0x724E510", VA = "0x18724F110")]
	public KAODOIENMMH(EJFEHMBHHJL MILPLABKJCF, CCJOPIDFGGK LDNEPNAGEGN, bool NGILHLJDDKK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "17")]
	public override bool NPBLDNGPJNH(DNCGBCFJOKI MILPLABKJCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x724EF40", Offset = "0x724E340", VA = "0x18724EF40", Slot = "18")]
	public override int PKGEGPGBNGG(HGFHPCOBBNK DDIIAJHFBBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x724D7F0", Offset = "0x724CBF0", VA = "0x18724D7F0", Slot = "19")]
	public override int BPKFFAMBFEB(HGFHPCOBBNK DDIIAJHFBBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x724DB70", Offset = "0x724CF70", VA = "0x18724DB70", Slot = "20")]
	public override Bounds HMECCAINCJF()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x94E0F0", Offset = "0x94D4F0", VA = "0x18094E0F0", Slot = "21")]
	public override float LPEELCFOFID()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x724E0B0", Offset = "0x724D4B0", VA = "0x18724E0B0", Slot = "22")]
	public override void LPLCMNPPKIC(HGFHPCOBBNK DDIIAJHFBBE, MAFKMJEPOIF IGCJCAEEHNP, int GFCJLGBPMAF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x724EE70", Offset = "0x724E270", VA = "0x18724EE70", Slot = "23")]
	public override DNCGBCFJOKI PAPEGGNEKDL()
	{
		return default(DNCGBCFJOKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x724D9C0", Offset = "0x724CDC0", VA = "0x18724D9C0", Slot = "25")]
	public override NNKOKNICPNH CBJNIBBFJNB()
	{
		return default(NNKOKNICPNH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x724E6A0", Offset = "0x724DAA0", VA = "0x18724E6A0", Slot = "26")]
	public override PMNCEEDNKGK NNPLDFJIBBN(HGFHPCOBBNK DDIIAJHFBBE, JobHandle DBNLEGDAPHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface DADPPEAJGHB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EJFEHMBHHJL OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JIJHAFAALOB OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CCJJEIHIDOB OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class NDAPPIGKJHD : PALHKGMEJPO, IDisposable, DADPPEAJGHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BADNDDBEDDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NDAPPIGKJHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x72430B0", Offset = "0x72424B0", VA = "0x1872430B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x72435D0", Offset = "0x72429D0", VA = "0x1872435D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly KCGPEJOMFAP<EDPGEOPEJPG, EJFEHMBHHJL> NAGCBMJPODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly KCGPEJOMFAP<PMCFHCPKMHL, JIJHAFAALOB> DOGBBLEKCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly KCGPEJOMFAP<DJDMCHEBNDO, CCJJEIHIDOB> ONLBCMOGPKK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EJFEHMBHHJL OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7250380", Offset = "0x724F780", VA = "0x187250380", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public JIJHAFAALOB OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x72502C0", Offset = "0x724F6C0", VA = "0x1872502C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CCJJEIHIDOB OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7250320", Offset = "0x724F720", VA = "0x187250320", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool KLHPIOJKKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB41E20", Offset = "0xB41220", VA = "0x180B41E20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xC38310", Offset = "0xC37710", VA = "0x180C38310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x72513B0", Offset = "0x72507B0", VA = "0x1872513B0")]
	public NDAPPIGKJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x724F860", Offset = "0x724EC60", VA = "0x18724F860", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x724F3D0", Offset = "0x724E7D0", VA = "0x18724F3D0", Slot = "4")]
	public EDPGEOPEJPG DCGLMDPENNK(JGFLLGGENAN LDNEPNAGEGN)
	{
		return default(EDPGEOPEJPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x724F3E0", Offset = "0x724E7E0", VA = "0x18724F3E0", Slot = "5")]
	public EDPGEOPEJPG DCGLMDPENNK(JGFLLGGENAN LDNEPNAGEGN, bool NGILHLJDDKK)
	{
		return default(EDPGEOPEJPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7250A70", Offset = "0x724FE70", VA = "0x187250A70", Slot = "6")]
	public void JJLKLCMANLL(EDPGEOPEJPG MILPLABKJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x724FED0", Offset = "0x724F2D0", VA = "0x18724FED0", Slot = "7")]
	public void FJANMJEHOKJ(EDPGEOPEJPG MILPLABKJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x724F9F0", Offset = "0x724EDF0", VA = "0x18724F9F0", Slot = "8")]
	public PMCFHCPKMHL EGEDHDAGJBB(EDPGEOPEJPG MILPLABKJCF, EJGABLBDAMK LDNEPNAGEGN)
	{
		return default(PMCFHCPKMHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7250ED0", Offset = "0x72502D0", VA = "0x187250ED0", Slot = "9")]
	public PMCFHCPKMHL OIJMCPIJBOM(EDPGEOPEJPG MILPLABKJCF, CCJOPIDFGGK LDNEPNAGEGN)
	{
		return default(PMCFHCPKMHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7250450", Offset = "0x724F850", VA = "0x187250450", Slot = "11")]
	public void HPBKMGMFKIK(PMCFHCPKMHL HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7250810", Offset = "0x724FC10", VA = "0x187250810", Slot = "10")]
	public void IJNDCEBLPLL(PMCFHCPKMHL HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x724F7F0", Offset = "0x724EBF0", VA = "0x18724F7F0", Slot = "20")]
	public IEnumerable<Renderer> DIMDKGCGGBP(EDPGEOPEJPG MILPLABKJCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7250CD0", Offset = "0x72500D0", VA = "0x187250CD0", Slot = "12")]
	public DJDMCHEBNDO NGDHMKDDKKA(BAEHPKGHJDI LDNEPNAGEGN)
	{
		return default(DJDMCHEBNDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72503E0", Offset = "0x724F7E0", VA = "0x1872503E0", Slot = "14")]
	public void HOFPMNMGCDM(DJDMCHEBNDO LLFJIOEFJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x724F660", Offset = "0x724EA60", VA = "0x18724F660", Slot = "16")]
	public Task DCNMNAJJAAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7250D50", Offset = "0x7250150", VA = "0x187250D50", Slot = "17")]
	public Task NNALNKFHEDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x724F2A0", Offset = "0x724E6A0", VA = "0x18724F2A0", Slot = "18")]
	[AsyncStateMachine(typeof(BADNDDBEDDI))]
	public Task BNPIACEMJOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7250230", Offset = "0x724F630", VA = "0x187250230", Slot = "19")]
	public void HHJBCGPKFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x724F370", Offset = "0x724E770", VA = "0x18724F370", Slot = "13")]
	public void BPBJEGJHKBN(DJDMCHEBNDO LLFJIOEFJHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class OKFCBMENNHI : JIJHAFAALOB
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct FEHLBLDOJGN : PMNCEEDNKGK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private AGIFCHBLDPN GFKLPJBCEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle DBNLEGDAPHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private DLKOAOFCNIK HDGHGPJIHNG;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7247BD0", Offset = "0x7246FD0", VA = "0x187247BD0")]
		public FEHLBLDOJGN(AGIFCHBLDPN GFKLPJBCEPF, JobHandle DBNLEGDAPHE, DLKOAOFCNIK HDGHGPJIHNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7247BA0", Offset = "0x7246FA0", VA = "0x187247BA0", Slot = "4")]
		public AGIFCHBLDPN IBMHMHPCIDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7247B50", Offset = "0x7246F50", VA = "0x187247B50", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly EJGABLBDAMK GAMKDEPHLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] HAHGNNHFDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 EGFBGKKIGNK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 OCOKBKKAHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7252210", Offset = "0x7251610", VA = "0x187252210")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 OFJEKOAJDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7251A20", Offset = "0x7250E20", VA = "0x187251A20", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7253DD0", Offset = "0x72531D0", VA = "0x187253DD0")]
	public OKFCBMENNHI(EJFEHMBHHJL MILPLABKJCF, EJGABLBDAMK LDNEPNAGEGN, bool CCAKPBNNILD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7253540", Offset = "0x7252940", VA = "0x187253540", Slot = "17")]
	public override bool NPBLDNGPJNH(DNCGBCFJOKI MILPLABKJCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7251DA0", Offset = "0x72511A0", VA = "0x187251DA0")]
	private GOALGAAPFMD CKENILICJEL([In] UniformTRS BFGJBEIBPFI, [In] float3 PMCMEFLOHKM)
	{
		return default(GOALGAAPFMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7253D30", Offset = "0x7253130", VA = "0x187253D30", Slot = "18")]
	public override int PKGEGPGBNGG(HGFHPCOBBNK DDIIAJHFBBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7251B50", Offset = "0x7250F50", VA = "0x187251B50", Slot = "19")]
	public override int BPKFFAMBFEB(HGFHPCOBBNK DDIIAJHFBBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7252440", Offset = "0x7251840", VA = "0x187252440", Slot = "20")]
	public override Bounds HMECCAINCJF()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x72524C0", Offset = "0x72518C0", VA = "0x1872524C0", Slot = "21")]
	public override float LPEELCFOFID()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7251FA0", Offset = "0x72513A0", VA = "0x187251FA0")]
	private int GGGBHPECABP(HGFHPCOBBNK DDIIAJHFBBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72525B0", Offset = "0x72519B0", VA = "0x1872525B0", Slot = "22")]
	public override void LPLCMNPPKIC(HGFHPCOBBNK DDIIAJHFBBE, MAFKMJEPOIF IGCJCAEEHNP, int GFCJLGBPMAF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7253C60", Offset = "0x7253060", VA = "0x187253C60", Slot = "23")]
	public override DNCGBCFJOKI PAPEGGNEKDL()
	{
		return default(DNCGBCFJOKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7251BF0", Offset = "0x7250FF0", VA = "0x187251BF0", Slot = "25")]
	public override NNKOKNICPNH CBJNIBBFJNB()
	{
		return default(NNKOKNICPNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7252DD0", Offset = "0x72521D0", VA = "0x187252DD0", Slot = "26")]
	public override PMNCEEDNKGK NNPLDFJIBBN(HGFHPCOBBNK DDIIAJHFBBE, JobHandle DBNLEGDAPHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MGJNKBGKHBL
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMEAOCMEMOC(DNHAAFIFMOK EPPKBKJHHHJ, Renderer CODANAEIMCO, int PACHHPLJFFD);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNGNGEOIEAC(Renderer CODANAEIMCO, HECLEHGGILO AKBLLKMCGKM, Vector3 GLMLHALNPFB, Vector3 BMPPIOCDLLM, Vector3 FDIPCNDIOLA, float FAKDCENLNFD, float DPBOKCIHGJM, float PLNJMEHBDID = -1f, [Optional] Color? IGDDAGDAAIO, [Optional] IReadOnlyList<Camera> MPCHJPEFNNA);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GEDGCOHGCII(Renderer CODANAEIMCO, int PACHHPLJFFD);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GGMNKJOMEMB();

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CEMILFBDEDP(int FIDEJACEMOD, FNNEHMDPCHL EPPKBKJHHHJ, Renderer CODANAEIMCO, int PACHHPLJFFD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ICIEPMGNIEA : NACMLLNMKKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class LBJKJGDIIBI : JKBHJIEFOEM<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x724F1C0", Offset = "0x724E5C0", VA = "0x18724F1C0")]
		public LBJKJGDIIBI(string FIKHOKLHCII)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly MGJNKBGKHBL MINIDMMHNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DADPPEAJGHB AAJLLDPEFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer GFDIHLDEJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private LBJKJGDIIBI ACNNBLEAIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool AIBPLALKCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer AIDCAIHGNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private LBJKJGDIIBI ODEOMPLGDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool GILLOCMLGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer PGCJGPAOFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private LBJKJGDIIBI FMJGCNCHCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool CNIDFMKHIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool BHKOIIDPEHB;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x85AB00", Offset = "0x859F00", VA = "0x18085AB00")]
	public ICIEPMGNIEA(MGJNKBGKHBL AHBGNMGHHAN, DADPPEAJGHB AAJLLDPEFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x724B040", Offset = "0x724A440", VA = "0x18724B040", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x724BAC0", Offset = "0x724AEC0", VA = "0x18724BAC0")]
	private void HLOKHGIOOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x724B730", Offset = "0x724AB30", VA = "0x18724B730", Slot = "4")]
	public void HGKOOCGGBBN(EDPGEOPEJPG MILPLABKJCF, FNNEHMDPCHL DJEGNGNMJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x724B510", Offset = "0x724A910", VA = "0x18724B510", Slot = "5")]
	public void HGKOOCGGBBN(PMCFHCPKMHL HNIPAMKIPII, FNNEHMDPCHL DJEGNGNMJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x724C8F0", Offset = "0x724BCF0", VA = "0x18724C8F0", Slot = "6")]
	public void LCLAFMCMPAD(PMCFHCPKMHL HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x724B1F0", Offset = "0x724A5F0", VA = "0x18724B1F0", Slot = "7")]
	public void FLGBFCKNIGB(PMCFHCPKMHL HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x724D4F0", Offset = "0x724C8F0", VA = "0x18724D4F0", Slot = "24")]
	public void PIABJAIOOBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x984C40", Offset = "0x984040", VA = "0x180984C40", Slot = "8")]
	public void IMDDJKHJMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x724B3A0", Offset = "0x724A7A0", VA = "0x18724B3A0", Slot = "9")]
	public void HFDFDEFFJFN(FNNEHMDPCHL DJEGNGNMJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x724CD90", Offset = "0x724C190", VA = "0x18724CD90", Slot = "10")]
	public void NCMJBIDGNGD(EDPGEOPEJPG MILPLABKJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x724D070", Offset = "0x724C470", VA = "0x18724D070", Slot = "11")]
	public void NCMJBIDGNGD(PMCFHCPKMHL HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x724CA20", Offset = "0x724BE20", VA = "0x18724CA20", Slot = "12")]
	public void LENEMDNKAHE(PMCFHCPKMHL HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x724BA30", Offset = "0x724AE30", VA = "0x18724BA30", Slot = "13")]
	public void HIHJPELGEKK(PMCFHCPKMHL HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x724ADF0", Offset = "0x724A1F0", VA = "0x18724ADF0")]
	private void DLCLEOFKPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA3B8F0", Offset = "0xA3ACF0", VA = "0x180A3B8F0", Slot = "14")]
	public void LNBHIKENBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x724C580", Offset = "0x724B980", VA = "0x18724C580", Slot = "15")]
	public void KJMLNCBMOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x724CAC0", Offset = "0x724BEC0", VA = "0x18724CAC0", Slot = "16")]
	public void LFBKOJCBMOF(EDPGEOPEJPG MILPLABKJCF, DNHAAFIFMOK EPPKBKJHHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x724B300", Offset = "0x724A700", VA = "0x18724B300", Slot = "17")]
	public void GNEGILBCDIP(PMCFHCPKMHL HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x724AD60", Offset = "0x724A160", VA = "0x18724AD60", Slot = "18")]
	public void DFJDMDGPGNI(PMCFHCPKMHL HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xB47D70", Offset = "0xB47170", VA = "0x180B47D70", Slot = "19")]
	public void LAOHNPMKIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x724D3C0", Offset = "0x724C7C0", VA = "0x18724D3C0", Slot = "20")]
	public void OEFIFGJIMHF(DNHAAFIFMOK EPPKBKJHHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x724C6A0", Offset = "0x724BAA0", VA = "0x18724C6A0")]
	private void KLBHBJJNDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x724C1B0", Offset = "0x724B5B0", VA = "0x18724C1B0", Slot = "21")]
	public void IMNLJMICJBI(EDPGEOPEJPG MILPLABKJCF, Vector3 GLMLHALNPFB, Vector3 BMPPIOCDLLM, Vector3 FDIPCNDIOLA, float FAKDCENLNFD, float DPBOKCIHGJM, IReadOnlyList<Camera> DONAKLDMEIM, HECLEHGGILO AKBLLKMCGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x724BD10", Offset = "0x724B110", VA = "0x18724BD10", Slot = "22")]
	public void IMNLJMICJBI(DJDMCHEBNDO LLFJIOEFJHA, Vector3 GLMLHALNPFB, Vector3 BMPPIOCDLLM, Vector3 FDIPCNDIOLA, float FAKDCENLNFD, float DPBOKCIHGJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class JIJHAFAALOB : HOBLKNANFMC, MHOPGKFJMAL, NMPHADIBBFB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly EJFEHMBHHJL JIDLAENMFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected Bounds BENPKPOPCDD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds ELNEOKAEAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x115E770", Offset = "0x115DB70", VA = "0x18115E770", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool IEHGPKOPAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA5F680", Offset = "0xA5EA80", VA = "0x180A5F680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA5F990", Offset = "0xA5ED90", VA = "0x180A5F990")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 OFJEKOAJDHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int LKMCBFCPIJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9A10D0", Offset = "0x9A04D0", VA = "0x1809A10D0", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public MOPBPLODBPK NHFCNOMEENP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8541A0", Offset = "0x8535A0", VA = "0x1808541A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool BIMNFKBGAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x151F250", Offset = "0x151E650", VA = "0x18151F250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	protected JIJHAFAALOB(EJFEHMBHHJL MILPLABKJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x724D530", Offset = "0x724C930", VA = "0x18724D530", Slot = "16")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "17")]
	public virtual bool NPBLDNGPJNH(DNCGBCFJOKI MILPLABKJCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int PKGEGPGBNGG(HGFHPCOBBNK DDIIAJHFBBE);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int BPKFFAMBFEB(HGFHPCOBBNK DDIIAJHFBBE);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract Bounds HMECCAINCJF();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract float LPEELCFOFID();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract void LPLCMNPPKIC(HGFHPCOBBNK DDIIAJHFBBE, MAFKMJEPOIF IGCJCAEEHNP, int GFCJLGBPMAF = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract DNCGBCFJOKI PAPEGGNEKDL();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x724D660", Offset = "0x724CA60", VA = "0x18724D660", Slot = "12")]
	public Hash128 LGDOPAGJNMB(int DDIIAJHFBBE)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract NNKOKNICPNH CBJNIBBFJNB();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract PMNCEEDNKGK NNPLDFJIBBN(HGFHPCOBBNK DDIIAJHFBBE, JobHandle DBNLEGDAPHE);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x724D690", Offset = "0x724CA90", VA = "0x18724D690", Slot = "11")]
	public PMNCEEDNKGK PHIMDKJGEPF(int DDIIAJHFBBE)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ShapeRendererConfig : SingletonScriptableObject<ShapeRendererConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7253E80", Offset = "0x7253280", VA = "0x187253E80")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GIGCPHGNAOG
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NMDPIEDHBBI : IEnumerable<NICEIHIECLG>, IEnumerable, IEnumerator<NICEIHIECLG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NICEIHIECLG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private NICEIHIECLG System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x89EDF0", Offset = "0x89E1F0", VA = "0x18089EDF0")]
		[DebuggerHidden]
		public NMDPIEDHBBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7251860", Offset = "0x7250C60", VA = "0x187251860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x72519D0", Offset = "0x7250DD0", VA = "0x1872519D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7251930", Offset = "0x7250D30", VA = "0x187251930", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NICEIHIECLG> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7251930", Offset = "0x7250D30", VA = "0x187251930", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static NICEIHIECLG[][] IIOONFBGPAP;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static JCDIBLMPGLA CEPMFKNJCDH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ShapeRendererConfig LKKHAHNPGCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x724AB10", Offset = "0x7249F10", VA = "0x18724AB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ComputeShader GEFNHBPLPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x724A690", Offset = "0x7249A90", VA = "0x18724A690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static SkinnedShapeRenderer EKINIPDPCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7249FD0", Offset = "0x72493D0", VA = "0x187249FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7249F20", Offset = "0x7249320", VA = "0x187249F20")]
	public static Mesh CHHLACMFDDI(IFHHPMNIMHJ FHBNOKDAMHE, int DDIIAJHFBBE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x724AB00", Offset = "0x7249F00", VA = "0x18724AB00")]
	public static int KFFFLLPNNCB(IFHHPMNIMHJ FHBNOKDAMHE, int DDIIAJHFBBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x724A9B0", Offset = "0x7249DB0", VA = "0x18724A9B0")]
	public static JCDIBLMPGLA KBIGHCJCHGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7249EC0", Offset = "0x72492C0", VA = "0x187249EC0")]
	[IteratorStateMachine(typeof(NMDPIEDHBBI))]
	private static IEnumerable<NICEIHIECLG> APNHCHFDHBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x724A700", Offset = "0x7249B00", VA = "0x18724A700")]
	public static NICEIHIECLG JOPFFNNMFKA(IFHHPMNIMHJ FHBNOKDAMHE, int DDIIAJHFBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x724A050", Offset = "0x7249450", VA = "0x18724A050")]
	public static bool GLEJELHIGPN(this IFHHPMNIMHJ FHBNOKDAMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x724AB40", Offset = "0x7249F40", VA = "0x18724AB40")]
	public static void LPDBEKGKCGP(IFHHPMNIMHJ FHBNOKDAMHE, float3 HBCKFLHFLLD, [Out] MCJHAKEBCFO KHGFLOJGDOH, [Out] float3 IEEBJNNGMNH, [Out] float JDONBMAIJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x724A070", Offset = "0x7249470", VA = "0x18724A070")]
	public static void HBAJNBPCGIN(Vector3 HBCKFLHFLLD, IFHHPMNIMHJ FHBNOKDAMHE, [Out] Vector3 IEEBJNNGMNH, [Out] float JDONBMAIJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x724A040", Offset = "0x7249440", VA = "0x18724A040")]
	[HDKHJAIFDLK(BCKDJIPKKOK.ExitingPlayMode, 0)]
	[JELMKLGNAKH(0)]
	private static void GFEKJFBNFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x724A4C0", Offset = "0x72498C0", VA = "0x18724A4C0")]
	[HDKHJAIFDLK(BCKDJIPKKOK.ExitingPlayMode, 0)]
	[JELMKLGNAKH(0)]
	private static void HMDOIEJEPNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class FOKHGHPGEKO : PALHKGMEJPO, IDisposable, DADPPEAJGHB
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly KCGPEJOMFAP<EDPGEOPEJPG, EJFEHMBHHJL> NAGCBMJPODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly KCGPEJOMFAP<PMCFHCPKMHL, JIJHAFAALOB> DOGBBLEKCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly KCGPEJOMFAP<DJDMCHEBNDO, CCJJEIHIDOB> ONLBCMOGPKK;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public EJFEHMBHHJL OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7248A10", Offset = "0x7247E10", VA = "0x187248A10", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public JIJHAFAALOB OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7248A70", Offset = "0x7247E70", VA = "0x187248A70", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public CCJJEIHIDOB OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7248AD0", Offset = "0x7247ED0", VA = "0x187248AD0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool KLHPIOJKKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xB41E20", Offset = "0xB41220", VA = "0x180B41E20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xC38310", Offset = "0xC37710", VA = "0x180C38310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7248FE0", Offset = "0x72483E0", VA = "0x187248FE0")]
	public FOKHGHPGEKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x72487C0", Offset = "0x7247BC0", VA = "0x1872487C0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7248610", Offset = "0x7247A10", VA = "0x187248610", Slot = "4")]
	public EDPGEOPEJPG DCGLMDPENNK(JGFLLGGENAN LDNEPNAGEGN)
	{
		return default(EDPGEOPEJPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7248610", Offset = "0x7247A10", VA = "0x187248610", Slot = "5")]
	public EDPGEOPEJPG DCGLMDPENNK(JGFLLGGENAN LDNEPNAGEGN, bool NGILHLJDDKK)
	{
		return default(EDPGEOPEJPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7248C90", Offset = "0x7248090", VA = "0x187248C90", Slot = "6")]
	public void JJLKLCMANLL(EDPGEOPEJPG MILPLABKJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7248990", Offset = "0x7247D90", VA = "0x187248990", Slot = "7")]
	public void FJANMJEHOKJ(EDPGEOPEJPG MILPLABKJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7248850", Offset = "0x7247C50", VA = "0x187248850", Slot = "8")]
	public PMCFHCPKMHL EGEDHDAGJBB(EDPGEOPEJPG MILPLABKJCF, EJGABLBDAMK LDNEPNAGEGN)
	{
		return default(PMCFHCPKMHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7248E10", Offset = "0x7248210", VA = "0x187248E10", Slot = "9")]
	public PMCFHCPKMHL OIJMCPIJBOM(EDPGEOPEJPG MILPLABKJCF, CCJOPIDFGGK LDNEPNAGEGN)
	{
		return default(PMCFHCPKMHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7248BA0", Offset = "0x7247FA0", VA = "0x187248BA0", Slot = "11")]
	public void HPBKMGMFKIK(PMCFHCPKMHL HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7248C30", Offset = "0x7248030", VA = "0x187248C30", Slot = "10")]
	public void IJNDCEBLPLL(PMCFHCPKMHL HNIPAMKIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7248750", Offset = "0x7247B50", VA = "0x187248750", Slot = "20")]
	public IEnumerable<Renderer> DIMDKGCGGBP(EDPGEOPEJPG MILPLABKJCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7248CF0", Offset = "0x72480F0", VA = "0x187248CF0", Slot = "12")]
	public DJDMCHEBNDO NGDHMKDDKKA(BAEHPKGHJDI LDNEPNAGEGN)
	{
		return default(DJDMCHEBNDO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7248B30", Offset = "0x7247F30", VA = "0x187248B30", Slot = "14")]
	public void HOFPMNMGCDM(DJDMCHEBNDO LLFJIOEFJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x72486B0", Offset = "0x7247AB0", VA = "0x1872486B0", Slot = "16")]
	public Task DCNMNAJJAAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7248D70", Offset = "0x7248170", VA = "0x187248D70", Slot = "17")]
	public Task NNALNKFHEDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7248510", Offset = "0x7247910", VA = "0x187248510", Slot = "18")]
	public Task BNPIACEMJOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1EF52E0", Offset = "0x1EF46E0", VA = "0x181EF52E0", Slot = "19")]
	public void HHJBCGPKFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x72485B0", Offset = "0x72479B0", VA = "0x1872485B0", Slot = "13")]
	public void BPBJEGJHKBN(DJDMCHEBNDO LLFJIOEFJHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OOLANLHLDDP
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MGONFEFNNBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material GDAFNFKDAEB();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material HJLKGJOKDIJ();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material HOLEOAGHDAF();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KNKHPEFKLKH(PFIKKCHFOII OHAGAMPKHIE);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FNNOOPOEDFA(DAJLLIPPJDK LEPGFDNNHNJ);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LBGNEMENCJK(GameObject LALIGKIKEBM);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GAHFMMEAKOH(GameObject LALIGKIKEBM, bool NOFLLGAFDIH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class AHMCNNHCBAO
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static OOLANLHLDDP DJKNDPHDPMJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool MGONFEFNNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7243050", Offset = "0x7242450", VA = "0x187243050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7242FF0", Offset = "0x72423F0", VA = "0x187242FF0")]
	public static void MJDCKFLAONG(OOLANLHLDDP PECIFEKOKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7242D80", Offset = "0x7242180", VA = "0x187242D80")]
	public static Material GDAFNFKDAEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7242DE0", Offset = "0x72421E0", VA = "0x187242DE0")]
	public static Material HJLKGJOKDIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7242E40", Offset = "0x7242240", VA = "0x187242E40")]
	public static Material HOLEOAGHDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7242EA0", Offset = "0x72422A0", VA = "0x187242EA0")]
	public static int KNKHPEFKLKH(PFIKKCHFOII OHAGAMPKHIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7242C20", Offset = "0x7242020", VA = "0x187242C20")]
	public static int FNNOOPOEDFA(DAJLLIPPJDK LEPGFDNNHNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7242F10", Offset = "0x7242310", VA = "0x187242F10")]
	public static void LBGNEMENCJK(GameObject LALIGKIKEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7242C90", Offset = "0x7242090", VA = "0x187242C90")]
	public static void GAHFMMEAKOH(GameObject LALIGKIKEBM, bool NOFLLGAFDIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CCJJEIHIDOB : HLCLGNMDMFP
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class DCBOAJBGMML : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CCJJEIHIDOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x89EDF0", Offset = "0x89E1F0", VA = "0x18089EDF0")]
		[DebuggerHidden]
		public DCBOAJBGMML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7246160", Offset = "0x7245560", VA = "0x187246160", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7245E40", Offset = "0x7245240", VA = "0x187245E40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7245DF0", Offset = "0x72451F0", VA = "0x187245DF0")]
		private void HMGBLPCOLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7246110", Offset = "0x7245510", VA = "0x187246110", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7246060", Offset = "0x7245460", VA = "0x187246060", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7246060", Offset = "0x7245460", VA = "0x187246060", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly BAEHPKGHJDI AOOPDONAIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly DADPPEAJGHB AAJLLDPEFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private GGGPINCJGFA NBDKBJNIKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private List<BJDFAEALIDP> GFGMDGIDJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<BJDFAEALIDP> PPAGGIDICMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private GameObject JLOBBKPDAAB;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7245BC0", Offset = "0x7244FC0", VA = "0x187245BC0")]
	public static CCJJEIHIDOB KJHCFIPFLJF(BAEHPKGHJDI LDNEPNAGEGN, DADPPEAJGHB AAJLLDPEFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7245D10", Offset = "0x7245110", VA = "0x187245D10")]
	private CCJJEIHIDOB(BAEHPKGHJDI LDNEPNAGEGN, DADPPEAJGHB AAJLLDPEFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x72456B0", Offset = "0x7244AB0", VA = "0x1872456B0")]
	public void HGGBIMJODNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7245B40", Offset = "0x7244F40", VA = "0x187245B40")]
	[IteratorStateMachine(typeof(DCBOAJBGMML))]
	public IEnumerable<Renderer> JKDFPALJNLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7244BE0", Offset = "0x7243FE0", VA = "0x187244BE0", Slot = "4")]
	public void GNOPDDNOPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7244960", Offset = "0x7243D60", VA = "0x187244960")]
	private void AGHANBDAGJD(Vector3 CDIBDMKFKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7244990", Offset = "0x7243D90", VA = "0x187244990")]
	public void DKKALNJCGIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BJDFAEALIDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct PNPHHDBDHNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public MAFKMJEPOIF BFGDOHHNEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DNCGBCFJOKI GBIGLHKMGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int ANFFFAJNOIJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GCAAHKNHPNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public BJDFAEALIDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public HGFHPCOBBNK lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<PNPHHDBDHNC> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AGIFCHBLDPN combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public GCAAHKNHPNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7249540", Offset = "0x7248940", VA = "0x187249540")]
		internal JobHandle EDPCOFAEBIN()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x72495A0", Offset = "0x72489A0", VA = "0x1872495A0")]
		internal void GLEPMFECKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x72493D0", Offset = "0x72487D0", VA = "0x1872493D0")]
		internal void DOMIMOKHDKH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int[] HFJIOBOJFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NGAHHGJNOJP LADBCCOENIG;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static Matrix4x4 DFFPCPMEFJA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Mesh NDKNOJPDHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int GLEMFOKAEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x850BF0", VA = "0x1808517F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x851810", Offset = "0x850C10", VA = "0x180851810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x72441B0", Offset = "0x72435B0", VA = "0x1872441B0")]
	public void PLMCBDMFPBC(List<DNCGBCFJOKI> CBNBHCFHNMD, Matrix4x4[] FHKACCABGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7243A40", Offset = "0x7242E40", VA = "0x187243A40")]
	public static List<BJDFAEALIDP> IBMNHJIAJMD(List<EJFEHMBHHJL> BPJHLMBDFDA, HGFHPCOBBNK DDIIAJHFBBE, Bounds EOHHKBPCFGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7243630", Offset = "0x7242A30", VA = "0x187243630")]
	private JobHandle BCEKOPGBBFC(AGIFCHBLDPN MDPBGKMELLB, int NEAMGOHHBGB, int EFLEFHDHJNC, HGFHPCOBBNK DDIIAJHFBBE, List<PNPHHDBDHNC> PMHDCDNLFCA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72440D0", Offset = "0x72434D0", VA = "0x1872440D0")]
	private void JELABPKFPLM(List<PNPHHDBDHNC> PMHDCDNLFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7244540", Offset = "0x7243940", VA = "0x187244540")]
	private BJDFAEALIDP(List<PNPHHDBDHNC> PMHDCDNLFCA, int NEAMGOHHBGB, int EFLEFHDHJNC, HGFHPCOBBNK DDIIAJHFBBE, Bounds EOHHKBPCFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x72439A0", Offset = "0x7242DA0", VA = "0x1872439A0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private MaterialPropertyBlock GMHBLNBDCNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private BJDFAEALIDP GFKLPJBCEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private List<DNCGBCFJOKI> PGFDOBDONPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private RenderTexture ILAIIFMCNMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ComputeBuffer LDPMFLGPPII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeShader CIKJMNPNLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Matrix4x4[] CDGOJHDGIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int PKMJGBHGDNF;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MeshRenderer GKDIFPHDPFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int MENOCFLICFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7254BE0", Offset = "0x7253FE0", VA = "0x187254BE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7253EE0", Offset = "0x72532E0", VA = "0x187253EE0")]
		public static List<SkinnedShapeRenderer> Create(GameObject MILPLABKJCF, List<BJDFAEALIDP> PGOOPHHPJBJ, List<DNCGBCFJOKI> PGFDOBDONPF, Material JOFMGPCHADM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7254190", Offset = "0x7253590", VA = "0x187254190")]
		public void Init(BJDFAEALIDP GFKLPJBCEPF, List<DNCGBCFJOKI> PGFDOBDONPF, Material JOFMGPCHADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x72547D0", Offset = "0x7253BD0", VA = "0x1872547D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7254730", Offset = "0x7253B30", VA = "0x187254730")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x72546F0", Offset = "0x7253AF0", VA = "0x1872546F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7254630", Offset = "0x7253A30", VA = "0x187254630")]
		private void KHOEMHAPHHN(ScriptableRenderContext NMIKEFKOPMC, Camera[] GILIMAFHNHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7254870", Offset = "0x7253C70", VA = "0x187254870")]
		private void PLMCBDMFPBC(CommandBuffer IBAOLAHLJEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		public SkinnedShapeRenderer()
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

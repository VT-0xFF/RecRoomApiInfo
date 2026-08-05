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
	public class LogRegistrationIndex : OACCHOKJOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x777B4D0", Offset = "0x777A8D0", VA = "0x18777B4D0", Slot = "4")]
		public override void PFLPBBOAAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BDKADGIBNPI : JFJBECMINEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte HNOJAGENCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] OKHAGJIJEGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EMMIMKJEDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x952F70", Offset = "0x952370", VA = "0x180952F70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA8F190", Offset = "0xA8E590", VA = "0x180A8F190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JCOBCDAKFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8EA370", VA = "0x1808EAF70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8EA560", Offset = "0x8E9960", VA = "0x1808EA560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float PODEDHCIHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA88500", Offset = "0xA87900", VA = "0x180A88500", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5600", VA = "0x180CF6200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float NNJKAJNMKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA884F0", Offset = "0xA878F0", VA = "0x180A884F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x15FC510", Offset = "0x15FB910", VA = "0x1815FC510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> OPPFGIFCNJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x776CF40", Offset = "0x776C340", VA = "0x18776CF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> EJPCMPPNHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x776CF90", Offset = "0x776C390", VA = "0x18776CF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject FKDEHKMEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4F0", Offset = "0x8AD8F0", VA = "0x1808AE4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte GPHHDJPKDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x776CFC0", Offset = "0x776C3C0", VA = "0x18776CFC0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x776D420", Offset = "0x776C820", VA = "0x18776D420")]
	public BDKADGIBNPI(List<IIHBKNKFJCA> OAKCAOENHNO, List<IIHBKNKFJCA> MNJFEBAIDAP, List<FHDOGMIMPJP> FOPPIKLJDDF, Material LBOPCEJDNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x776D010", Offset = "0x776C410", VA = "0x18776D010")]
	private int MBFIPOJCFMC(List<IIHBKNKFJCA> HIHJMBIFPKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x776D130", Offset = "0x776C530", VA = "0x18776D130")]
	private void MLKBJIKPEBP(int PPCPDNBIMPF, bool MEFHKNCMBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x776D290", Offset = "0x776C690", VA = "0x18776D290")]
	public void MOAIFDPKPCA(Vector3 OPCIBHCGCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x776CE40", Offset = "0x776C240", VA = "0x18776CE40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x776D3E0", Offset = "0x776C7E0", VA = "0x18776D3E0")]
	public void NOBNNOPEKPO(Transform CLIMKEGNKME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GKKGLDMJDNK : PCGNDIJDFIF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class AOMPEPMDDCF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GKKGLDMJDNK <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
		[DebuggerHidden]
		public AOMPEPMDDCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x776CC50", Offset = "0x776C050", VA = "0x18776CC50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x776C5A0", Offset = "0x776B9A0", VA = "0x18776C5A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x776CB00", Offset = "0x776BF00", VA = "0x18776CB00")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x776C550", Offset = "0x776B950", VA = "0x18776C550")]
		private void EMBCDMFMIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x776CAB0", Offset = "0x776BEB0", VA = "0x18776CAB0")]
		private void PHMEOOPABOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x776CC00", Offset = "0x776C000", VA = "0x18776CC00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x776CB50", Offset = "0x776BF50", VA = "0x18776CB50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x776CB50", Offset = "0x776BF50", VA = "0x18776CB50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class BHDJJNAENCH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GKKGLDMJDNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
		[DebuggerHidden]
		public BHDJJNAENCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x776DC50", Offset = "0x776D050", VA = "0x18776DC50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x776D790", Offset = "0x776CB90", VA = "0x18776D790", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x776DB00", Offset = "0x776CF00", VA = "0x18776DB00")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x776D740", Offset = "0x776CB40", VA = "0x18776D740")]
		private void EMBCDMFMIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x776DC00", Offset = "0x776D000", VA = "0x18776DC00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x776DB50", Offset = "0x776CF50", VA = "0x18776DB50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x776DB50", Offset = "0x776CF50", VA = "0x18776DB50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HIOHBANOJEJ DPLFPHNCENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<DCEOLFOAJKN> EDDGNDLHENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> KJAPFMNCIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer BBELENNNKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool LODGBONPJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool MEEFCCJHBBI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<OFBHAEBDFJC> FMIBELMCPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int OGIDPOAKDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7774510", Offset = "0x7773910", VA = "0x187774510", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FHDOGMIMPJP FHLGBBKCAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7774FB0", Offset = "0x77743B0", VA = "0x187774FB0", Slot = "8")]
		get
		{
			return default(FHDOGMIMPJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> FCMODKPIJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F50", Offset = "0x8A9350", VA = "0x1808A9F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B75A0", VA = "0x1808B81A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x77751A0", Offset = "0x77745A0", VA = "0x1877751A0")]
	private bool MGEOFIOCAHO(DCEOLFOAJKN FLALLMFKGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7774550", Offset = "0x7773950", VA = "0x187774550")]
	private static bool HGBMKMHELHA(DCEOLFOAJKN FLALLMFKGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7775930", Offset = "0x7774D30", VA = "0x187775930")]
	public GKKGLDMJDNK(HIOHBANOJEJ MPMEGOKIEPF, bool NOCLPHGHIEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7774390", Offset = "0x7773790", VA = "0x187774390", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7775790", Offset = "0x7774B90", VA = "0x187775790")]
	public void PJLPMKJIOFF(DCEOLFOAJKN FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7775080", Offset = "0x7774480", VA = "0x187775080")]
	public void MAHJHHAHNPL(DCEOLFOAJKN FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7775290", Offset = "0x7774690", VA = "0x187775290", Slot = "4")]
	public void NNCOLLGDHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7774140", Offset = "0x7773540", VA = "0x187774140")]
	public void BNOGHBKOPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7774C60", Offset = "0x7774060", VA = "0x187774C60")]
	private void KDGFPECNADD(List<DCEOLFOAJKN> EDDGNDLHENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7774ED0", Offset = "0x77742D0", VA = "0x187774ED0")]
	private static Material KDJKHMDEELK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7774E20", Offset = "0x7774220", VA = "0x187774E20")]
	private void KDGFPECNADD(DCEOLFOAJKN FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x77751C0", Offset = "0x77745C0", VA = "0x1877751C0")]
	private void MOBECAIGDEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7774570", Offset = "0x7773970", VA = "0x187774570")]
	public void IDLOPNOJEPL(bool JEPBOBDKPLK, bool BIMJACDACIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7774BA0", Offset = "0x7773FA0", VA = "0x187774BA0")]
	protected void JOEGIKKOEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7774B20", Offset = "0x7773F20", VA = "0x187774B20")]
	public void IDPFKBOBBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x77740C0", Offset = "0x77734C0", VA = "0x1877740C0")]
	[IteratorStateMachine(typeof(AOMPEPMDDCF))]
	public IEnumerable<Renderer> AKLAGJPENOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7774F30", Offset = "0x7774330", VA = "0x187774F30")]
	[IteratorStateMachine(typeof(BHDJJNAENCH))]
	public IEnumerable<Renderer> KHHFDIPDFEO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class MNLLIENNKHF : DCEOLFOAJKN
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct OPEFLEOAGGE : AFFHHGAMIDE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private JHEIAOJDPDC JIPKNCLPFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle LGCKIPFOBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private MJIMMGLKGDN CBDNNDEHCDP;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x777DC30", Offset = "0x777D030", VA = "0x18777DC30")]
		public OPEFLEOAGGE(JHEIAOJDPDC JIPKNCLPFGJ, JobHandle LGCKIPFOBAH, MJIMMGLKGDN CBDNNDEHCDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x777DC00", Offset = "0x777D000", VA = "0x18777DC00", Slot = "4")]
		public JHEIAOJDPDC ONAFBBOMACN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x777DBB0", Offset = "0x777CFB0", VA = "0x18777DBB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly DPNFHPNEDCD BAMHNHMCCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float PINGBFCNKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 GGEFGFDAAGI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 AMMFCMDHPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x777D020", Offset = "0x777C420", VA = "0x18777D020", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x777D4F0", Offset = "0x777C8F0", VA = "0x18777D4F0")]
	public MNLLIENNKHF(GKKGLDMJDNK FINELPFBLOK, DPNFHPNEDCD MPMEGOKIEPF, bool NOCLPHGHIEB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "17")]
	public override bool FNBGHKEGPIP(FHDOGMIMPJP FINELPFBLOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x777D150", Offset = "0x777C550", VA = "0x18777D150", Slot = "18")]
	public override int MBFIPOJCFMC(HOEGHAPJAGH KFELJFNOKBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x777D320", Offset = "0x777C720", VA = "0x18777D320", Slot = "19")]
	public override int OHDBIHJBDOO(HOEGHAPJAGH KFELJFNOKBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x777BAC0", Offset = "0x777AEC0", VA = "0x18777BAC0", Slot = "20")]
	public override Bounds APEDAPPHIEK()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xB8C110", Offset = "0xB8B510", VA = "0x180B8C110", Slot = "21")]
	public override float OPCPKLLHPLM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x777C1B0", Offset = "0x777B5B0", VA = "0x18777C1B0", Slot = "22")]
	public override void BPPKBJBKJNK(HOEGHAPJAGH KFELJFNOKBH, IGMDHOIMGAD NFMPKGPMOHC, int BICFOPHJEGF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x777C780", Offset = "0x777BB80", VA = "0x18777C780", Slot = "23")]
	public override FHDOGMIMPJP FIIOGPBNPNI()
	{
		return default(FHDOGMIMPJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x777C000", Offset = "0x777B400", VA = "0x18777C000", Slot = "25")]
	public override KJEIPAMCNBJ BBDAEKKKMMA()
	{
		return default(KJEIPAMCNBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x777C850", Offset = "0x777BC50", VA = "0x18777C850", Slot = "26")]
	public override AFFHHGAMIDE HOMAGBNFANE(HOEGHAPJAGH KFELJFNOKBH, JobHandle LGCKIPFOBAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface MBKAAEPIIKF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	GKKGLDMJDNK CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DCEOLFOAJKN CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	EEHOOCKKIHH CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class LHDDJDALFBO : PIAONEGPKBE, IDisposable, MBKAAEPIIKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct MGDOKIMJCJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public LHDDJDALFBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x777B560", Offset = "0x777A960", VA = "0x18777B560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x777BA60", Offset = "0x777AE60", VA = "0x18777BA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly EGOMDMDNJIL<KEPCBPCCBKC, GKKGLDMJDNK> CEFEEBLDODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly EGOMDMDNJIL<CAHFOPGMBNB, DCEOLFOAJKN> EDDGNDLHENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly EGOMDMDNJIL<IKJAJMHDONF, EEHOOCKKIHH> IHKNFMJOPOB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GKKGLDMJDNK CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7779EB0", Offset = "0x77792B0", VA = "0x187779EB0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DCEOLFOAJKN CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7779F10", Offset = "0x7779310", VA = "0x187779F10", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public EEHOOCKKIHH CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7779F70", Offset = "0x7779370", VA = "0x187779F70", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool AIBMILNLOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x982980", Offset = "0x981D80", VA = "0x180982980", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x982840", Offset = "0x981C40", VA = "0x180982840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x777A1E0", Offset = "0x77795E0", VA = "0x18777A1E0")]
	public LHDDJDALFBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7778470", Offset = "0x7777870", VA = "0x187778470", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7779EA0", Offset = "0x77792A0", VA = "0x187779EA0", Slot = "4")]
	public KEPCBPCCBKC NMICHBDBMPA(HIOHBANOJEJ MPMEGOKIEPF)
	{
		return default(KEPCBPCCBKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7779C30", Offset = "0x7779030", VA = "0x187779C30", Slot = "5")]
	public KEPCBPCCBKC NMICHBDBMPA(HIOHBANOJEJ MPMEGOKIEPF, bool NOCLPHGHIEB)
	{
		return default(KEPCBPCCBKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x77799E0", Offset = "0x7778DE0", VA = "0x1877799E0", Slot = "6")]
	public void MAPMKGIMKBL(KEPCBPCCBKC FINELPFBLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7779110", Offset = "0x7778510", VA = "0x187779110", Slot = "7")]
	public void FOKBPHLBOCB(KEPCBPCCBKC FINELPFBLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7778720", Offset = "0x7777B20", VA = "0x187778720", Slot = "8")]
	public CAHFOPGMBNB FANNAPMNPPE(KEPCBPCCBKC FINELPFBLOK, FHNHHFHLCLD MPMEGOKIEPF)
	{
		return default(CAHFOPGMBNB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7778C50", Offset = "0x7778050", VA = "0x187778C50", Slot = "9")]
	public CAHFOPGMBNB FGGPCCBHCCE(KEPCBPCCBKC FINELPFBLOK, DPNFHPNEDCD MPMEGOKIEPF)
	{
		return default(CAHFOPGMBNB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7779640", Offset = "0x7778A40", VA = "0x187779640", Slot = "11")]
	public void JDFMILGHEFA(CAHFOPGMBNB FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7778220", Offset = "0x7777620", VA = "0x187778220", Slot = "10")]
	public void DLFLFJAEHFD(CAHFOPGMBNB FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7778BE0", Offset = "0x7777FE0", VA = "0x187778BE0", Slot = "20")]
	public IEnumerable<Renderer> FBMNJKDNINN(KEPCBPCCBKC FINELPFBLOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x77781A0", Offset = "0x77775A0", VA = "0x1877781A0", Slot = "12")]
	public IKJAJMHDONF ANACDDGHLEI(HPKNLABEANK MPMEGOKIEPF)
	{
		return default(IKJAJMHDONF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7779450", Offset = "0x7778850", VA = "0x187779450", Slot = "14")]
	public void GIFDJHDPFGC(IKJAJMHDONF PILDPOBEDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x77794C0", Offset = "0x77788C0", VA = "0x1877794C0", Slot = "16")]
	public Task JAIEOFKPNHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7779FD0", Offset = "0x77793D0", VA = "0x187779FD0", Slot = "17")]
	public Task OKHEIKJBMGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x77785F0", Offset = "0x77779F0", VA = "0x1877785F0", Slot = "18")]
	[AsyncStateMachine(typeof(MGDOKIMJCJI))]
	public Task EBLDFGEAMOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x777A150", Offset = "0x7779550", VA = "0x18777A150", Slot = "19")]
	public void PEPAEAMBAMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x77786C0", Offset = "0x7777AC0", VA = "0x1877786C0", Slot = "13")]
	public void EEKHDOBGKAF(IKJAJMHDONF PILDPOBEDBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class FEBBBGEKKNL : DCEOLFOAJKN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct BLNEGDPMNDD : AFFHHGAMIDE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private JHEIAOJDPDC JIPKNCLPFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle LGCKIPFOBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private LKFGHDMELOC CBDNNDEHCDP;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x776DE00", Offset = "0x776D200", VA = "0x18776DE00")]
		public BLNEGDPMNDD(JHEIAOJDPDC JIPKNCLPFGJ, JobHandle LGCKIPFOBAH, LKFGHDMELOC CBDNNDEHCDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x776DDD0", Offset = "0x776D1D0", VA = "0x18776DDD0", Slot = "4")]
		public JHEIAOJDPDC ONAFBBOMACN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x776DD80", Offset = "0x776D180", VA = "0x18776DD80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly FHNHHFHLCLD BAFNFCIODAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] IBKKBMFNJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 GGEFGFDAAGI;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 ELNJGPMPMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7773940", Offset = "0x7772D40", VA = "0x187773940")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 AMMFCMDHPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7773610", Offset = "0x7772A10", VA = "0x187773610", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7774010", Offset = "0x7773410", VA = "0x187774010")]
	public FEBBBGEKKNL(GKKGLDMJDNK FINELPFBLOK, FHNHHFHLCLD MPMEGOKIEPF, bool FEMBJMCMHJI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7772790", Offset = "0x7771B90", VA = "0x187772790", Slot = "17")]
	public override bool FNBGHKEGPIP(FHDOGMIMPJP FINELPFBLOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7773740", Offset = "0x7772B40", VA = "0x187773740")]
	private NOLMEEDJECJ KLHGEDCJJLM([In] UniformTRS KNPMFHLBEKA, [In] float3 HOJHFHKFJHD)
	{
		return default(NOLMEEDJECJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7773B70", Offset = "0x7772F70", VA = "0x187773B70", Slot = "18")]
	public override int MBFIPOJCFMC(HOEGHAPJAGH KFELJFNOKBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7773C10", Offset = "0x7773010", VA = "0x187773C10", Slot = "19")]
	public override int OHDBIHJBDOO(HOEGHAPJAGH KFELJFNOKBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7771C70", Offset = "0x7771070", VA = "0x187771C70", Slot = "20")]
	public override Bounds APEDAPPHIEK()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7773CB0", Offset = "0x77730B0", VA = "0x187773CB0", Slot = "21")]
	public override float OPCPKLLHPLM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7773DA0", Offset = "0x77731A0", VA = "0x187773DA0")]
	private int PPPHLHBDPLK(HOEGHAPJAGH KFELJFNOKBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7771EA0", Offset = "0x77712A0", VA = "0x187771EA0", Slot = "22")]
	public override void BPPKBJBKJNK(HOEGHAPJAGH KFELJFNOKBH, IGMDHOIMGAD NFMPKGPMOHC, int BICFOPHJEGF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x77726C0", Offset = "0x7771AC0", VA = "0x1877726C0", Slot = "23")]
	public override FHDOGMIMPJP FIIOGPBNPNI()
	{
		return default(FHDOGMIMPJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7771CF0", Offset = "0x77710F0", VA = "0x187771CF0", Slot = "25")]
	public override KJEIPAMCNBJ BBDAEKKKMMA()
	{
		return default(KJEIPAMCNBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7772EB0", Offset = "0x77722B0", VA = "0x187772EB0", Slot = "26")]
	public override AFFHHGAMIDE HOMAGBNFANE(HOEGHAPJAGH KFELJFNOKBH, JobHandle LGCKIPFOBAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FEGJPNDGLFL
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHCOEDAEIIM(FLEFIJKHEBL LGJDMOCCBDP, Renderer OEGINKHKPKI, int ABKCCJEPNLG);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIMPNOPBODA(Renderer OEGINKHKPKI, NOEMLKNPAEK EPAJBMCMMED, Vector3 PBCGOIFFLDI, Vector3 JGIGKIKFIEE, Vector3 AKCEHJDGDPH, float EGLFMCIKDMC, float JBIKFBAIKJI, float NIEMIALCDKN = -1f, [Optional] Color? DFKHKPKCOFI, [Optional] IReadOnlyList<Camera> HPNLCGFHIIN);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOEMBBIIKOE(Renderer OEGINKHKPKI, int ABKCCJEPNLG);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LPNLOAGNCII();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDFBGEMPMKC(int JKENBLLABHI, MHIAMIGKIGC LGJDMOCCBDP, Renderer OEGINKHKPKI, int ABKCCJEPNLG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EMKNODKMMMH : FDCIAKKAPMA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class OJBPJPINOFG : HPGEKDOFCMJ<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x777DB60", Offset = "0x777CF60", VA = "0x18777DB60")]
		public OJBPJPINOFG(string ADANIHOIEKJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FEGJPNDGLFL NCMKENKGBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly MBKAAEPIIKF DIKDFKMAMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer HCKDJFFKEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private OJBPJPINOFG GJPOOGELIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool INDDEDGMCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer FILOBPIPDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private OJBPJPINOFG FGHLPKPFHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool GKAOKBOCNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer ONLOOHGNHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private OJBPJPINOFG IBELEJFMAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool BDPCGKKGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool HLAMJAHICLD;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CD0", Offset = "0x8A90D0", VA = "0x1808A9CD0")]
	public EMKNODKMMMH(FEGJPNDGLFL HAPLABELDEB, MBKAAEPIIKF DIKDFKMAMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x776FAC0", Offset = "0x776EEC0", VA = "0x18776FAC0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x776F550", Offset = "0x776E950", VA = "0x18776F550")]
	private void BCAMPJFHICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7770610", Offset = "0x776FA10", VA = "0x187770610", Slot = "4")]
	public void GIPMANHFLDE(KEPCBPCCBKC FINELPFBLOK, MHIAMIGKIGC GIBLAOMCIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7770920", Offset = "0x776FD20", VA = "0x187770920", Slot = "5")]
	public void GIPMANHFLDE(CAHFOPGMBNB FLALLMFKGLH, MHIAMIGKIGC GIBLAOMCIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x77704E0", Offset = "0x776F8E0", VA = "0x1877704E0", Slot = "6")]
	public void EMDCLJHLDIK(CAHFOPGMBNB FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7771840", Offset = "0x7770C40", VA = "0x187771840", Slot = "7")]
	public void MHIOPMGCJCK(CAHFOPGMBNB FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7771760", Offset = "0x7770B60", VA = "0x187771760", Slot = "24")]
	public void JKAOMDNLBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xBB2900", Offset = "0xBB1D00", VA = "0x180BB2900", Slot = "8")]
	public void IKNGFHPJIDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7771950", Offset = "0x7770D50", VA = "0x187771950", Slot = "9")]
	public void NIDGHFAOGDH(MHIAMIGKIGC GIBLAOMCIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7770EC0", Offset = "0x77702C0", VA = "0x187770EC0", Slot = "10")]
	public void IKNGIALKONH(KEPCBPCCBKC FINELPFBLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7771190", Offset = "0x7770590", VA = "0x187771190", Slot = "11")]
	public void IKNGIALKONH(CAHFOPGMBNB FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7770B40", Offset = "0x776FF40", VA = "0x187770B40", Slot = "12")]
	public void HGDPFBBEDAN(CAHFOPGMBNB FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x776F7C0", Offset = "0x776EBC0", VA = "0x18776F7C0", Slot = "13")]
	public void DDCNGEMBNDO(CAHFOPGMBNB FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x776F850", Offset = "0x776EC50", VA = "0x18776F850")]
	private void DIECFNAMJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xC88330", Offset = "0xC87730", VA = "0x180C88330", Slot = "14")]
	public void GJJBEMDPHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7771AC0", Offset = "0x7770EC0", VA = "0x187771AC0", Slot = "15")]
	public void NJDMFGOBKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7770BE0", Offset = "0x776FFE0", VA = "0x187770BE0", Slot = "16")]
	public void HGLECFLGEFL(KEPCBPCCBKC FINELPFBLOK, FLEFIJKHEBL LGJDMOCCBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x77717A0", Offset = "0x7770BA0", VA = "0x1877717A0", Slot = "17")]
	public void LLMNLCMIKFA(CAHFOPGMBNB FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7771BE0", Offset = "0x7770FE0", VA = "0x187771BE0", Slot = "18")]
	public void ONLOBMIEDPJ(CAHFOPGMBNB FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x91F2C0", Offset = "0x91E6C0", VA = "0x18091F2C0", Slot = "19")]
	public void HENAMMBHFAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x776F420", Offset = "0x776E820", VA = "0x18776F420", Slot = "20")]
	public void ALPAKBPAJLC(FLEFIJKHEBL LGJDMOCCBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x77714F0", Offset = "0x77708F0", VA = "0x1877714F0")]
	private void JFNAPFKPOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x776FC70", Offset = "0x776F070", VA = "0x18776FC70", Slot = "21")]
	public void ECELCJGOGKN(KEPCBPCCBKC FINELPFBLOK, Vector3 PBCGOIFFLDI, Vector3 JGIGKIKFIEE, Vector3 AKCEHJDGDPH, float EGLFMCIKDMC, float JBIKFBAIKJI, IReadOnlyList<Camera> LDKALEGNGAL, NOEMLKNPAEK EPAJBMCMMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7770040", Offset = "0x776F440", VA = "0x187770040", Slot = "22")]
	public void ECELCJGOGKN(IKJAJMHDONF PILDPOBEDBC, Vector3 PBCGOIFFLDI, Vector3 JGIGKIKFIEE, Vector3 AKCEHJDGDPH, float EGLFMCIKDMC, float JBIKFBAIKJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class DCEOLFOAJKN : AGFDCDIOIJM, OFBHAEBDFJC, DGJCECDPCLD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly GKKGLDMJDNK FKDEHKMEOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected Bounds MAEIKOENPLC;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds DDNHIHIDADG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x1395BB0", Offset = "0x1394FB0", VA = "0x181395BB0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool MEEFCCJHBBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x927B80", Offset = "0x926F80", VA = "0x180927B80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9229F0", Offset = "0x921DF0", VA = "0x1809229F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 AMMFCMDHPPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CAOCOMLLJPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9178F0", Offset = "0x916CF0", VA = "0x1809178F0", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public JFOCFCCEAKN FOOBCMMNHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F50", Offset = "0x8A9350", VA = "0x1808A9F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B75A0", VA = "0x1808B81A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EDFLLBFFACA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xD582B0", Offset = "0xD576B0", VA = "0x180D582B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	protected DCEOLFOAJKN(GKKGLDMJDNK FINELPFBLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x776DE80", Offset = "0x776D280", VA = "0x18776DE80", Slot = "16")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "17")]
	public virtual bool FNBGHKEGPIP(FHDOGMIMPJP FINELPFBLOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int MBFIPOJCFMC(HOEGHAPJAGH KFELJFNOKBH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int OHDBIHJBDOO(HOEGHAPJAGH KFELJFNOKBH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract Bounds APEDAPPHIEK();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract float OPCPKLLHPLM();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract void BPPKBJBKJNK(HOEGHAPJAGH KFELJFNOKBH, IGMDHOIMGAD NFMPKGPMOHC, int BICFOPHJEGF = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract FHDOGMIMPJP FIIOGPBNPNI();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x776DFB0", Offset = "0x776D3B0", VA = "0x18776DFB0", Slot = "12")]
	public Hash128 MNDNNEMFDAD(int KFELJFNOKBH)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract KJEIPAMCNBJ BBDAEKKKMMA();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract AFFHHGAMIDE HOMAGBNFANE(HOEGHAPJAGH KFELJFNOKBH, JobHandle LGCKIPFOBAH);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x776DE50", Offset = "0x776D250", VA = "0x18776DE50", Slot = "11")]
	public AFFHHGAMIDE BJCDAANMOCA(int KFELJFNOKBH)
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

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x777DC90", Offset = "0x777D090", VA = "0x18777DC90")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LPGOMLNBNLI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NAOGMKGOIHF : IEnumerable<GLNJNDHBHFA>, IEnumerable, IEnumerator<GLNJNDHBHFA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private GLNJNDHBHFA <>2__current;

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
		private GLNJNDHBHFA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
		[DebuggerHidden]
		public NAOGMKGOIHF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x777D5A0", Offset = "0x777C9A0", VA = "0x18777D5A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x777D710", Offset = "0x777CB10", VA = "0x18777D710", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x777D670", Offset = "0x777CA70", VA = "0x18777D670", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GLNJNDHBHFA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x777D670", Offset = "0x777CA70", VA = "0x18777D670", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static GLNJNDHBHFA[][] LGADNMAAJDE;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static KBGPMHOBMPJ IHODGMEMPLB;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ShapeRendererConfig IMGILBBMLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x777AC60", Offset = "0x777A060", VA = "0x18777AC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ComputeShader MCDFIGHMELC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x777B380", Offset = "0x777A780", VA = "0x18777B380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static SkinnedShapeRenderer AAODNBCCHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x777B3F0", Offset = "0x777A7F0", VA = "0x18777B3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x777AB50", Offset = "0x7779F50", VA = "0x18777AB50")]
	public static Mesh HAMCAGEONHG(PCPFHMNMHBK IKMENOMJCFK, int KFELJFNOKBH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x777A840", Offset = "0x7779C40", VA = "0x18777A840")]
	public static int FOLKCLKLKJE(PCPFHMNMHBK IKMENOMJCFK, int KFELJFNOKBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x777A850", Offset = "0x7779C50", VA = "0x18777A850")]
	public static KBGPMHOBMPJ GFCJAICDCBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x777AC00", Offset = "0x777A000", VA = "0x18777AC00")]
	[IteratorStateMachine(typeof(NAOGMKGOIHF))]
	private static IEnumerable<GLNJNDHBHFA> IHALBKOEPHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x777B0E0", Offset = "0x777A4E0", VA = "0x18777B0E0")]
	public static GLNJNDHBHFA LHMMPEGGFJD(PCPFHMNMHBK IKMENOMJCFK, int KFELJFNOKBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x777A820", Offset = "0x7779C20", VA = "0x18777A820")]
	public static bool EDECPLOILHG(this PCPFHMNMHBK IKMENOMJCFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x777A670", Offset = "0x7779A70", VA = "0x18777A670")]
	public static void EDALIACAAPH(PCPFHMNMHBK IKMENOMJCFK, float3 FIJGMIAHBJO, [Out] LMGKIBLKANC JJENIJLPLOM, [Out] float3 JKCAGPMDPGB, [Out] float LAHCNGANFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x777AC90", Offset = "0x777A090", VA = "0x18777AC90")]
	public static void LBIADBBLONF(Vector3 FIJGMIAHBJO, PCPFHMNMHBK IKMENOMJCFK, [Out] Vector3 JKCAGPMDPGB, [Out] float LAHCNGANFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x777A660", Offset = "0x7779A60", VA = "0x18777A660")]
	[PNBDIHKPGLO(BDADFFMLEGJ.ExitingPlayMode, 0)]
	[BPBADFCBICM(0)]
	private static void BOPNBLFACHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x777A990", Offset = "0x7779D90", VA = "0x18777A990")]
	[PNBDIHKPGLO(BDADFFMLEGJ.ExitingPlayMode, 0)]
	[BPBADFCBICM(0)]
	private static void GGKHMKLDDNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class JEDMIHCEBLN : PIAONEGPKBE, IDisposable, MBKAAEPIIKF
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly EGOMDMDNJIL<KEPCBPCCBKC, GKKGLDMJDNK> CEFEEBLDODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly EGOMDMDNJIL<CAHFOPGMBNB, DCEOLFOAJKN> EDDGNDLHENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly EGOMDMDNJIL<IKJAJMHDONF, EEHOOCKKIHH> IHKNFMJOPOB;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GKKGLDMJDNK CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7777A60", Offset = "0x7776E60", VA = "0x187777A60", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public DCEOLFOAJKN CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x77779A0", Offset = "0x7776DA0", VA = "0x1877779A0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public EEHOOCKKIHH CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7777A00", Offset = "0x7776E00", VA = "0x187777A00", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool AIBMILNLOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x982980", Offset = "0x981D80", VA = "0x180982980", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x982840", Offset = "0x981C40", VA = "0x180982840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7777BE0", Offset = "0x7776FE0", VA = "0x187777BE0")]
	public JEDMIHCEBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7777200", Offset = "0x7776600", VA = "0x187777200", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7777900", Offset = "0x7776D00", VA = "0x187777900", Slot = "4")]
	public KEPCBPCCBKC NMICHBDBMPA(HIOHBANOJEJ MPMEGOKIEPF)
	{
		return default(KEPCBPCCBKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7777900", Offset = "0x7776D00", VA = "0x187777900", Slot = "5")]
	public KEPCBPCCBKC NMICHBDBMPA(HIOHBANOJEJ MPMEGOKIEPF, bool NOCLPHGHIEB)
	{
		return default(KEPCBPCCBKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x77778A0", Offset = "0x7776CA0", VA = "0x1877778A0", Slot = "6")]
	public void MAPMKGIMKBL(KEPCBPCCBKC FINELPFBLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7777680", Offset = "0x7776A80", VA = "0x187777680", Slot = "7")]
	public void FOKBPHLBOCB(KEPCBPCCBKC FINELPFBLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7777390", Offset = "0x7776790", VA = "0x187777390", Slot = "8")]
	public CAHFOPGMBNB FANNAPMNPPE(KEPCBPCCBKC FINELPFBLOK, FHNHHFHLCLD MPMEGOKIEPF)
	{
		return default(CAHFOPGMBNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7777540", Offset = "0x7776940", VA = "0x187777540", Slot = "9")]
	public CAHFOPGMBNB FGGPCCBHCCE(KEPCBPCCBKC FINELPFBLOK, DPNFHPNEDCD MPMEGOKIEPF)
	{
		return default(CAHFOPGMBNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7777810", Offset = "0x7776C10", VA = "0x187777810", Slot = "11")]
	public void JDFMILGHEFA(CAHFOPGMBNB FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x77771A0", Offset = "0x77765A0", VA = "0x1877771A0", Slot = "10")]
	public void DLFLFJAEHFD(CAHFOPGMBNB FLALLMFKGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x77774D0", Offset = "0x77768D0", VA = "0x1877774D0", Slot = "20")]
	public IEnumerable<Renderer> FBMNJKDNINN(KEPCBPCCBKC FINELPFBLOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7777120", Offset = "0x7776520", VA = "0x187777120", Slot = "12")]
	public IKJAJMHDONF ANACDDGHLEI(HPKNLABEANK MPMEGOKIEPF)
	{
		return default(IKJAJMHDONF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7777700", Offset = "0x7776B00", VA = "0x187777700", Slot = "14")]
	public void GIFDJHDPFGC(IKJAJMHDONF PILDPOBEDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7777770", Offset = "0x7776B70", VA = "0x187777770", Slot = "16")]
	public Task JAIEOFKPNHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7777AC0", Offset = "0x7776EC0", VA = "0x187777AC0", Slot = "17")]
	public Task OKHEIKJBMGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7777290", Offset = "0x7776690", VA = "0x187777290", Slot = "18")]
	public Task EBLDFGEAMOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2133680", Offset = "0x2132A80", VA = "0x182133680", Slot = "19")]
	public void PEPAEAMBAMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7777330", Offset = "0x7776730", VA = "0x187777330", Slot = "13")]
	public void EEKHDOBGKAF(IKJAJMHDONF PILDPOBEDBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DGPHPGBEHBI
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool BDFIIOIKLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material ECDJFIOKBPP();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material KDJKHMDEELK();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material LKHBIPOJGIB();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PDNKKNFHGBP(APKAPDGLGCH GEBIPDLOLCB);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int MJCPMHILMGM(ADLKLKHIHDG APMCJDKNHGO);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OKPFDIMBLPK(GameObject PBAACPJGKNP);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CMKKOHJLJGF(GameObject PBAACPJGKNP, bool PEPOKLECLJN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class HHBIJJPHBHP
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static DGPHPGBEHBI GDIPKBJJCBL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool BDFIIOIKLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7775A20", Offset = "0x7774E20", VA = "0x187775A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7775BC0", Offset = "0x7774FC0", VA = "0x187775BC0")]
	public static void HBKGHONCPGJ(DGPHPGBEHBI JNJOEGKAODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7775B60", Offset = "0x7774F60", VA = "0x187775B60")]
	public static Material ECDJFIOKBPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7774ED0", Offset = "0x77742D0", VA = "0x187774ED0")]
	public static Material KDJKHMDEELK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7775C10", Offset = "0x7775010", VA = "0x187775C10")]
	public static Material LKHBIPOJGIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7775DB0", Offset = "0x77751B0", VA = "0x187775DB0")]
	public static int PDNKKNFHGBP(APKAPDGLGCH GEBIPDLOLCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7775C70", Offset = "0x7775070", VA = "0x187775C70")]
	public static int MJCPMHILMGM(ADLKLKHIHDG APMCJDKNHGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7775CE0", Offset = "0x77750E0", VA = "0x187775CE0")]
	public static void OKPFDIMBLPK(GameObject PBAACPJGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7775A80", Offset = "0x7774E80", VA = "0x187775A80")]
	public static void CMKKOHJLJGF(GameObject PBAACPJGKNP, bool PEPOKLECLJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EEHOOCKKIHH : PCGNDIJDFIF
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NPAKBCDHMAH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EEHOOCKKIHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
		[DebuggerHidden]
		public NPAKBCDHMAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x777DAD0", Offset = "0x777CED0", VA = "0x18777DAD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x777D760", Offset = "0x777CB60", VA = "0x18777D760", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x777D980", Offset = "0x777CD80", VA = "0x18777D980")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x777DA80", Offset = "0x777CE80", VA = "0x18777DA80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x777D9D0", Offset = "0x777CDD0", VA = "0x18777D9D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x777D9D0", Offset = "0x777CDD0", VA = "0x18777D9D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly HPKNLABEANK ENINKKPJFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly MBKAAEPIIKF DIKDFKMAMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private BDKADGIBNPI KMHOGBLICEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private List<IIHBKNKFJCA> JOBGFGCADCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<IIHBKNKFJCA> MACOJBBLOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private GameObject GGGPIEAHILP;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x776E060", Offset = "0x776D460", VA = "0x18776E060")]
	public static EEHOOCKKIHH BKGFGEHPHAF(HPKNLABEANK MPMEGOKIEPF, MBKAAEPIIKF DIKDFKMAMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x776F340", Offset = "0x776E740", VA = "0x18776F340")]
	private EEHOOCKKIHH(HPKNLABEANK MPMEGOKIEPF, MBKAAEPIIKF DIKDFKMAMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x776E400", Offset = "0x776D800", VA = "0x18776E400")]
	public void KMANLEPJEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x776DFE0", Offset = "0x776D3E0", VA = "0x18776DFE0")]
	[IteratorStateMachine(typeof(NPAKBCDHMAH))]
	public IEnumerable<Renderer> AKLAGJPENOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x776E8B0", Offset = "0x776DCB0", VA = "0x18776E8B0", Slot = "4")]
	public void NNCOLLGDHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x776E880", Offset = "0x776DC80", VA = "0x18776E880")]
	private void MEBKAAHNILJ(Vector3 OPCIBHCGCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x776E1B0", Offset = "0x776D5B0", VA = "0x18776E1B0")]
	public void BNOGHBKOPKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IIHBKNKFJCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct FEDCEACBJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public IGMDHOIMGAD LDKCCIILIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public FHDOGMIMPJP FCANNHMFHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int IGMHAKOCMDI;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LBLPCMHMBLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public IIHBKNKFJCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public HOEGHAPJAGH lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<FEDCEACBJAJ> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public JHEIAOJDPDC combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public LBLPCMHMBLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7778110", Offset = "0x7777510", VA = "0x187778110")]
		internal JobHandle LCKJGALHHIK()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7778170", Offset = "0x7777570", VA = "0x187778170")]
		internal void PKGHMIPOOON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7777FA0", Offset = "0x77773A0", VA = "0x187777FA0")]
		internal void JIGACKNLMKJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int[] INICJDGLOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private LAGEJLMMAHI HBONNNKKFHI;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static Matrix4x4 DPDNJBNJGHK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Mesh ADBEBIMNGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int CDMPNIIABON
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8AE510", Offset = "0x8AD910", VA = "0x1808AE510")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8AE520", Offset = "0x8AD920", VA = "0x1808AE520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7776990", Offset = "0x7775D90", VA = "0x187776990")]
	public void NLKAHONADIB(List<FHDOGMIMPJP> BAAMGNECPCC, Matrix4x4[] JDBHFBMPLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7776300", Offset = "0x7775700", VA = "0x187776300")]
	public static List<IIHBKNKFJCA> LIDOGEGODKP(List<GKKGLDMJDNK> POCBIBLGKIC, HOEGHAPJAGH KFELJFNOKBH, Bounds DGIPNPAPPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7775FA0", Offset = "0x77753A0", VA = "0x187775FA0")]
	private JobHandle HJFMPHDNJPP(JHEIAOJDPDC JLOCJFHDBKL, int EFLJOEAENFI, int IHOGEOAGCLG, HOEGHAPJAGH KFELJFNOKBH, List<FEDCEACBJAJ> HDPMMKOPKAL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7775E20", Offset = "0x7775220", VA = "0x187775E20")]
	private void ALABJPPLEKK(List<FEDCEACBJAJ> HDPMMKOPKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7776D00", Offset = "0x7776100", VA = "0x187776D00")]
	private IIHBKNKFJCA(List<FEDCEACBJAJ> HDPMMKOPKAL, int EFLJOEAENFI, int IHOGEOAGCLG, HOEGHAPJAGH KFELJFNOKBH, Bounds DGIPNPAPPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7775F00", Offset = "0x7775300", VA = "0x187775F00", Slot = "4")]
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
		private MaterialPropertyBlock IMOAFHNPNDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IIHBKNKFJCA JIPKNCLPFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private List<FHDOGMIMPJP> FOPPIKLJDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private RenderTexture COMOECAPGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ComputeBuffer EEKPNNOODCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeShader ALPANNEBKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Matrix4x4[] BLFAEHJLHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int JICOOLAJLGN;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MeshRenderer ODCABMIMCCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int FOOKBOBBHKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x777EA00", Offset = "0x777DE00", VA = "0x18777EA00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x777DCF0", Offset = "0x777D0F0", VA = "0x18777DCF0")]
		public static List<SkinnedShapeRenderer> Create(GameObject FINELPFBLOK, List<IIHBKNKFJCA> HIHJMBIFPKA, List<FHDOGMIMPJP> FOPPIKLJDDF, Material LBOPCEJDNFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x777E060", Offset = "0x777D460", VA = "0x18777E060")]
		public void Init(IIHBKNKFJCA JIPKNCLPFGJ, List<FHDOGMIMPJP> FOPPIKLJDDF, Material LBOPCEJDNFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x777E960", Offset = "0x777DD60", VA = "0x18777E960")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x777E8C0", Offset = "0x777DCC0", VA = "0x18777E8C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x777E880", Offset = "0x777DC80", VA = "0x18777E880")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x777DFA0", Offset = "0x777D3A0", VA = "0x18777DFA0")]
		private void FNMAOHGGOKI(ScriptableRenderContext JCPOMHNJOIE, Camera[] IDJMHFJMFLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x777E510", Offset = "0x777D910", VA = "0x18777E510")]
		private void NLKAHONADIB(CommandBuffer ALAHKFHHBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
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

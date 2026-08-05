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
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C27060", Offset = "0x7C26260", VA = "0x187C27060", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ENMHFGINAKK : JFEACIIIPDK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte HJMBFPMILOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] GIECCHPGPON;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ENEJAGNJLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB25E10", Offset = "0xB25010", VA = "0x180B25E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ICDJGBLOFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9335E0", Offset = "0x9327E0", VA = "0x1809335E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x932BE0", Offset = "0x931DE0", VA = "0x180932BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float PKICBODFEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD67E50", Offset = "0xD67050", VA = "0x180D67E50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1028400", Offset = "0x1027600", VA = "0x181028400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CFCNIOEGNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xACCA50", Offset = "0xACBC50", VA = "0x180ACCA50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xACCA60", Offset = "0xACBC60", VA = "0x180ACCA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> EILAGELCMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C226D0", Offset = "0x7C218D0", VA = "0x187C226D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> BGHJAAKLFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C226A0", Offset = "0x7C218A0", VA = "0x187C226A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject KMOBICEOLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D40", Offset = "0x8F3F40", VA = "0x1808F4D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte NCBCPJDKPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C22180", Offset = "0x7C21380", VA = "0x187C22180", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C22760", Offset = "0x7C21960", VA = "0x187C22760")]
	public ENMHFGINAKK(List<FGGHIKDGEJE> GLPIDNFGJLP, List<FGGHIKDGEJE> PMIJGJKAKNI, List<HLDKLCEAPAJ> OKAIFFGINHE, Material HGJFBFIMOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C22320", Offset = "0x7C21520", VA = "0x187C22320")]
	private int CBKLNPJAJPL(List<FGGHIKDGEJE> BCGDIBMJAOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C22540", Offset = "0x7C21740", VA = "0x187C22540")]
	private void KACMJFPFNIH(int EHJGCNCFFLL, bool CICEJGGDGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C221D0", Offset = "0x7C213D0", VA = "0x187C221D0")]
	public void CAAHBMJGLBO(Vector3 CJGDNAEFKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C22440", Offset = "0x7C21640", VA = "0x187C22440", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C22720", Offset = "0x7C21920", VA = "0x187C22720")]
	public void PLMHODONKCL(Transform NAKAOOFFCCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IJJPFFPCLNG : MMOIPDIAPPN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class JLKLKFHOJBD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public IJJPFFPCLNG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xC45340", Offset = "0xC44540", VA = "0x180C45340")]
		[DebuggerHidden]
		public JLKLKFHOJBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C26C60", Offset = "0x7C25E60", VA = "0x187C26C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7C26650", Offset = "0x7C25850", VA = "0x187C26650", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7C26600", Offset = "0x7C25800", VA = "0x187C26600")]
		private void MHLANDJELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C265B0", Offset = "0x7C257B0", VA = "0x187C265B0")]
		private void JELILPGANHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7C26560", Offset = "0x7C25760", VA = "0x187C26560")]
		private void EGGONLDPEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7C26C10", Offset = "0x7C25E10", VA = "0x187C26C10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C26B60", Offset = "0x7C25D60", VA = "0x187C26B60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C26B60", Offset = "0x7C25D60", VA = "0x187C26B60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class FMALMJJDNML : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public IJJPFFPCLNG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC45340", Offset = "0xC44540", VA = "0x180C45340")]
		[DebuggerHidden]
		public FMALMJJDNML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C242C0", Offset = "0x7C234C0", VA = "0x187C242C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E50", Offset = "0x7C23050", VA = "0x187C23E50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E00", Offset = "0x7C23000", VA = "0x187C23E00")]
		private void MHLANDJELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C23DB0", Offset = "0x7C22FB0", VA = "0x187C23DB0")]
		private void JELILPGANHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C24270", Offset = "0x7C23470", VA = "0x187C24270", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C241C0", Offset = "0x7C233C0", VA = "0x187C241C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C241C0", Offset = "0x7C233C0", VA = "0x187C241C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HDHNHBENNJN HENCMBBFEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<KJEAJNIBBLO> GEDAGMPBHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> KGCGNJICDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer JILGKMMMGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool GDLIECGHKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool LCPIPFNBHLO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<JHPAPOCMABL> AAAJOGPMHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GGNFLLCNEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C25720", Offset = "0x7C24920", VA = "0x187C25720", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HLDKLCEAPAJ FOFOGJPGLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C24C30", Offset = "0x7C23E30", VA = "0x187C24C30", Slot = "8")]
		get
		{
			return default(HLDKLCEAPAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> GGBFMCMMPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0C0", Offset = "0x8FA2C0", VA = "0x1808FB0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C259D0", Offset = "0x7C24BD0", VA = "0x187C259D0")]
	private bool HFDJBKDJKEF(KJEAJNIBBLO OIEMAHGGLND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C24C10", Offset = "0x7C23E10", VA = "0x187C24C10")]
	private static bool AAKLAKAMIDK(KJEAJNIBBLO OIEMAHGGLND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C26470", Offset = "0x7C25670", VA = "0x187C26470")]
	public IJJPFFPCLNG(HDHNHBENNJN LFDKFEEPNFP, bool JBJDLKONOJO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C25550", Offset = "0x7C24750", VA = "0x187C25550", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C252B0", Offset = "0x7C244B0", VA = "0x187C252B0")]
	public void CKLHJOINNOK(KJEAJNIBBLO OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C258B0", Offset = "0x7C24AB0", VA = "0x187C258B0")]
	public void GMODDBABBFK(KJEAJNIBBLO OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C25EB0", Offset = "0x7C250B0", VA = "0x187C25EB0", Slot = "4")]
	public void NDIPPIBFJAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C25C60", Offset = "0x7C24E60", VA = "0x187C25C60")]
	public void MEIPIBBEBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C25AA0", Offset = "0x7C24CA0", VA = "0x187C25AA0")]
	private void IJOJNHPOLCH(List<KJEAJNIBBLO> GEDAGMPBHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DCA0", Offset = "0x7C1CEA0", VA = "0x187C1DCA0")]
	private static Material BHCBOOANJNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C259F0", Offset = "0x7C24BF0", VA = "0x187C259F0")]
	private void IJOJNHPOLCH(KJEAJNIBBLO OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C25760", Offset = "0x7C24960", VA = "0x187C25760")]
	private void FPLKPGKGMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C24CF0", Offset = "0x7C23EF0", VA = "0x187C24CF0")]
	public void BPHIGBHCGHI(bool JDEJBCJKPKM, bool DCKOJAIJNOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C263B0", Offset = "0x7C255B0", VA = "0x187C263B0")]
	protected void NLDKFKFLNIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C25830", Offset = "0x7C24A30", VA = "0x187C25830")]
	public void GJOGMDCLMJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C25450", Offset = "0x7C24650", VA = "0x187C25450")]
	[IteratorStateMachine(typeof(JLKLKFHOJBD))]
	public IEnumerable<Renderer> DALPAPCOBMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C254D0", Offset = "0x7C246D0", VA = "0x187C254D0")]
	[IteratorStateMachine(typeof(FMALMJJDNML))]
	public IEnumerable<Renderer> DLKJIHCGCOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class ENFFEBFBMHC : KJEAJNIBBLO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct GGALGHIBKJG : PMEBFNMKDHJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BFAKCFONIOG NNPLONBDKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle DLGFKNLCAHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private LOOFAPDLMCO JJFCLPIBKAB;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7C24470", Offset = "0x7C23670", VA = "0x187C24470")]
		public GGALGHIBKJG(BFAKCFONIOG NNPLONBDKAB, JobHandle DLGFKNLCAHD, LOOFAPDLMCO JJFCLPIBKAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7C243F0", Offset = "0x7C235F0", VA = "0x187C243F0", Slot = "4")]
		public BFAKCFONIOG DDGALHILICL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7C24420", Offset = "0x7C23620", VA = "0x187C24420", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly OPFNBBFLGAH FKGKHHAAEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float IFELNOGJPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 HBLJLMFNJHC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 OBMDHFFCFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7C217E0", Offset = "0x7C209E0", VA = "0x187C217E0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C220D0", Offset = "0x7C212D0", VA = "0x187C220D0")]
	public ENFFEBFBMHC(IJJPFFPCLNG DONMCNODAED, OPFNBBFLGAH LFDKFEEPNFP, bool JBJDLKONOJO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "18")]
	public override bool GMBHDEKNHML(HLDKLCEAPAJ DONMCNODAED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C207A0", Offset = "0x7C1F9A0", VA = "0x187C207A0", Slot = "19")]
	public override int CBKLNPJAJPL(EPFADHMLJII MPDJGCJPOLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C21D40", Offset = "0x7C20F40", VA = "0x187C21D40", Slot = "20")]
	public override int OMLLAEJBBOO(EPFADHMLJII MPDJGCJPOLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C21900", Offset = "0x7C20B00", VA = "0x187C21900", Slot = "21")]
	public override KLNMFPLBPMG HPPJOCKJPEJ()
	{
		return default(KLNMFPLBPMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xAAB170", Offset = "0xAAA370", VA = "0x180AAB170", Slot = "22")]
	public override float HCMEIINKEEL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C21200", Offset = "0x7C20400", VA = "0x187C21200", Slot = "23")]
	public override void HLFGEEMIING(EPFADHMLJII MPDJGCJPOLI, KIPAKEFLEJH DGHGMDFGHDA, int EBHDKCFBPGE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C21130", Offset = "0x7C20330", VA = "0x187C21130", Slot = "24")]
	public override HLDKLCEAPAJ DDCPBFLJHAC()
	{
		return default(HLDKLCEAPAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C21F10", Offset = "0x7C21110", VA = "0x187C21F10", Slot = "26")]
	public override CDDHKLNEGHH PBHDFHCEPDM()
	{
		return default(CDDHKLNEGHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C20970", Offset = "0x7C1FB70", VA = "0x187C20970", Slot = "27")]
	public override PMEBFNMKDHJ CKLICJMBGAB(EPFADHMLJII MPDJGCJPOLI, JobHandle DLGFKNLCAHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface JAILKKNPFKM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IJJPFFPCLNG FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KJEAJNIBBLO FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OLMFFBLGCLN FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class CIMKOADMEBM : ELNPEFEPDJC, IDisposable, JAILKKNPFKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HCGANOEAGGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CIMKOADMEBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7C244D0", Offset = "0x7C236D0", VA = "0x187C244D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7C249F0", Offset = "0x7C23BF0", VA = "0x187C249F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly ONAHJFPGCEL<IMHPOJOIOJD, IJJPFFPCLNG> LJPFOFOHNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly ONAHJFPGCEL<PBANANEDPKJ, KJEAJNIBBLO> GEDAGMPBHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly ONAHJFPGCEL<BCIEDBLKKKE, OLMFFBLGCLN> CDCNHMLPFIE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IJJPFFPCLNG FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F5E0", Offset = "0x7C1E7E0", VA = "0x187C1F5E0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public KJEAJNIBBLO FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F520", Offset = "0x7C1E720", VA = "0x187C1F520", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public OLMFFBLGCLN FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F580", Offset = "0x7C1E780", VA = "0x187C1F580", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DEILIEJMOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xC897D0", Offset = "0xC889D0", VA = "0x180C897D0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xC896C0", Offset = "0xC888C0", VA = "0x180C896C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C202F0", Offset = "0x7C1F4F0", VA = "0x187C202F0")]
	public CIMKOADMEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C1EE80", Offset = "0x7C1E080", VA = "0x187C1EE80", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F290", Offset = "0x7C1E490", VA = "0x187C1F290", Slot = "4")]
	public IMHPOJOIOJD IDILFGPPLEF(HDHNHBENNJN LFDKFEEPNFP)
	{
		return default(IMHPOJOIOJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F2A0", Offset = "0x7C1E4A0", VA = "0x187C1F2A0", Slot = "5")]
	public IMHPOJOIOJD IDILFGPPLEF(HDHNHBENNJN LFDKFEEPNFP, bool JBJDLKONOJO)
	{
		return default(IMHPOJOIOJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FB90", Offset = "0x7C1ED90", VA = "0x187C1FB90", Slot = "6")]
	public void LNJADDCDFDF(IMHPOJOIOJD DONMCNODAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F6B0", Offset = "0x7C1E8B0", VA = "0x187C1F6B0", Slot = "7")]
	public void KDDMFANMNBI(IMHPOJOIOJD DONMCNODAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E9A0", Offset = "0x7C1DBA0", VA = "0x187C1E9A0", Slot = "8")]
	public PBANANEDPKJ CNMOGFDLGMH(IMHPOJOIOJD DONMCNODAED, CHNJCLCIIHF LFDKFEEPNFP)
	{
		return default(PBANANEDPKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E1E0", Offset = "0x7C1D3E0", VA = "0x187C1E1E0", Slot = "9")]
	public PBANANEDPKJ AFFFFFJNNKP(IMHPOJOIOJD DONMCNODAED, OPFNBBFLGAH LFDKFEEPNFP)
	{
		return default(PBANANEDPKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FF30", Offset = "0x7C1F130", VA = "0x187C1FF30", Slot = "11")]
	public void PPOJNAFMKCE(PBANANEDPKJ OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E740", Offset = "0x7C1D940", VA = "0x187C1E740", Slot = "10")]
	public void CMHNFCLKEIP(PBANANEDPKJ OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FEC0", Offset = "0x7C1F0C0", VA = "0x187C1FEC0", Slot = "20")]
	public IEnumerable<Renderer> PIDJDPIJDNG(IMHPOJOIOJD DONMCNODAED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E6C0", Offset = "0x7C1D8C0", VA = "0x187C1E6C0", Slot = "12")]
	public BCIEDBLKKKE CHIKONACMIC(ADAAAHJJBMK LFDKFEEPNFP)
	{
		return default(BCIEDBLKKKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F640", Offset = "0x7C1E840", VA = "0x187C1F640", Slot = "14")]
	public void JNFMLDHODLO(BCIEDBLKKKE AFJALLPMKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F010", Offset = "0x7C1E210", VA = "0x187C1F010", Slot = "16")]
	public Task EMBODPCNIOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FA10", Offset = "0x7C1EC10", VA = "0x187C1FA10", Slot = "17")]
	public Task KDLBMACPGNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FDF0", Offset = "0x7C1EFF0", VA = "0x187C1FDF0", Slot = "18")]
	[AsyncStateMachine(typeof(HCGANOEAGGN))]
	public Task NPMFPDGABNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F200", Offset = "0x7C1E400", VA = "0x187C1F200", Slot = "19")]
	public void HDCBNDMCGGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F1A0", Offset = "0x7C1E3A0", VA = "0x187C1F1A0", Slot = "13")]
	public void GNDAPGAGGMO(BCIEDBLKKKE AFJALLPMKEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class MLANFFHGACD : KJEAJNIBBLO
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct BJIHOJCENEP : PMEBFNMKDHJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private BFAKCFONIOG NNPLONBDKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle DLGFKNLCAHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private KPLKNPGFMNP JJFCLPIBKAB;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E190", Offset = "0x7C1D390", VA = "0x187C1E190")]
		public BJIHOJCENEP(BFAKCFONIOG NNPLONBDKAB, JobHandle DLGFKNLCAHD, KPLKNPGFMNP JJFCLPIBKAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E110", Offset = "0x7C1D310", VA = "0x187C1E110", Slot = "4")]
		public BFAKCFONIOG DDGALHILICL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E140", Offset = "0x7C1D340", VA = "0x187C1E140", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly CHNJCLCIIHF ELDOIBMHPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] OKDILAMMGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 HBLJLMFNJHC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 MOHNNICOPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7C27CA0", Offset = "0x7C26EA0", VA = "0x187C27CA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 OBMDHFFCFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C28A50", Offset = "0x7C27C50", VA = "0x187C28A50", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C29900", Offset = "0x7C28B00", VA = "0x187C29900")]
	public MLANFFHGACD(IJJPFFPCLNG DONMCNODAED, CHNJCLCIIHF LFDKFEEPNFP, bool LHDKJDICPFL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C27AE0", Offset = "0x7C26CE0", VA = "0x187C27AE0", Slot = "18")]
	public override bool GMBHDEKNHML(HLDKLCEAPAJ DONMCNODAED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C291D0", Offset = "0x7C283D0", VA = "0x187C291D0", Slot = "21")]
	public override KLNMFPLBPMG HPPJOCKJPEJ()
	{
		return default(KLNMFPLBPMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C28B70", Offset = "0x7C27D70", VA = "0x187C28B70")]
	private KLNMFPLBPMG HPPJOCKJPEJ(HLDKLCEAPAJ DONMCNODAED)
	{
		return default(KLNMFPLBPMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C29490", Offset = "0x7C28690", VA = "0x187C29490")]
	private PFKMKAKPKKK NFPFIDELHKG([In] UniformTRS IEKCACFBDGK, [In] float3 JADJHKEDFMJ)
	{
		return default(PFKMKAKPKKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C270F0", Offset = "0x7C262F0", VA = "0x187C270F0", Slot = "19")]
	public override int CBKLNPJAJPL(EPFADHMLJII MPDJGCJPOLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C29690", Offset = "0x7C28890", VA = "0x187C29690", Slot = "20")]
	public override int OMLLAEJBBOO(EPFADHMLJII MPDJGCJPOLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7C27BB0", Offset = "0x7C26DB0", VA = "0x187C27BB0", Slot = "22")]
	public override float HCMEIINKEEL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7C29210", Offset = "0x7C28410", VA = "0x187C29210")]
	private int MGHBKNBJLLP(EPFADHMLJII MPDJGCJPOLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7C27ED0", Offset = "0x7C270D0", VA = "0x187C27ED0", Slot = "23")]
	public override void HLFGEEMIING(EPFADHMLJII MPDJGCJPOLI, KIPAKEFLEJH DGHGMDFGHDA, int EBHDKCFBPGE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7C27A10", Offset = "0x7C26C10", VA = "0x187C27A10", Slot = "24")]
	public override HLDKLCEAPAJ DDCPBFLJHAC()
	{
		return default(HLDKLCEAPAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7C29740", Offset = "0x7C28940", VA = "0x187C29740", Slot = "26")]
	public override CDDHKLNEGHH PBHDFHCEPDM()
	{
		return default(CDDHKLNEGHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7C27290", Offset = "0x7C26490", VA = "0x187C27290", Slot = "27")]
	public override PMEBFNMKDHJ CKLICJMBGAB(EPFADHMLJII MPDJGCJPOLI, JobHandle DLGFKNLCAHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PBFCPJPOFJD
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGBLMCACJEL(NAOAHHFOEAM MDOOANEGCAH, Renderer DELKJLDIJIB, int BAENOFCDDFO);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAOMEJBFBIL(Renderer DELKJLDIJIB, CIDHMNMLPOB JFGHHALANHN, Vector3 AOGFPLLALGP, Vector3 AGICILCMAEG, Vector3 LIPEJHCDLPH, float PMMKCKEHAPL, float IEECDIDGDFI, float IJFMNJGJEHN = -1f, [Optional] Color? HCHFCFNLIAI, [Optional] IReadOnlyList<Camera> HHOKBHOLGJJ);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIKJLOBJEML(Renderer DELKJLDIJIB, int BAENOFCDDFO);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NKMCAEFOMOH();

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FKOMIMFNOBG(int KILONIFNMLH, JHEIHPJJONE MDOOANEGCAH, Renderer DELKJLDIJIB, int BAENOFCDDFO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BBOEHLEIDEL : AOFAIHBKPNG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class LABJGEHJNLN : HNMBGJDJBMM<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C27010", Offset = "0x7C26210", VA = "0x187C27010")]
		public LABJGEHJNLN(string LMOANCJLHKC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly PBFCPJPOFJD LIPEFFDAKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly JAILKKNPFKM DAFNIIIPPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer HDNDNNLMPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private LABJGEHJNLN CMGDBPCEIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool GMPCJMICOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer AOJPPHLDHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private LABJGEHJNLN KLDLKBEGKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool KJDJIADPEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer AEJAHPEMBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private LABJGEHJNLN OBMPBKMLMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool HHDKBNOFBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool HAOFCOOGPMB;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8FD3B0", Offset = "0x8FC5B0", VA = "0x1808FD3B0")]
	public BBOEHLEIDEL(PBFCPJPOFJD FJHGHPCGFNP, JAILKKNPFKM DAFNIIIPPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CAF0", Offset = "0x7C1BCF0", VA = "0x187C1CAF0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B130", Offset = "0x7C1A330", VA = "0x187C1B130")]
	private void AJMNLLOHONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C7E0", Offset = "0x7C1B9E0", VA = "0x187C1C7E0", Slot = "4")]
	public void DCLABFHHHCN(IMHPOJOIOJD DONMCNODAED, JHEIHPJJONE EIHFAHFNELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C5C0", Offset = "0x7C1B7C0", VA = "0x187C1C5C0", Slot = "5")]
	public void DCLABFHHHCN(PBANANEDPKJ OIEMAHGGLND, JHEIHPJJONE EIHFAHFNELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D5A0", Offset = "0x7C1C7A0", VA = "0x187C1D5A0", Slot = "6")]
	public void LOPEAMLHKNI(PBANANEDPKJ OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D450", Offset = "0x7C1C650", VA = "0x187C1D450", Slot = "7")]
	public void LCLFMIGIOFE(PBANANEDPKJ OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CCA0", Offset = "0x7C1BEA0", VA = "0x187C1CCA0", Slot = "24")]
	public void HFEHJCBKAIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xEBF6D0", Offset = "0xEBE8D0", VA = "0x180EBF6D0", Slot = "8")]
	public void KNGHAFIOJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CE00", Offset = "0x7C1C000", VA = "0x187C1CE00", Slot = "9")]
	public void HNNODGFIPGI(JHEIHPJJONE EIHFAHFNELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C2F0", Offset = "0x7C1B4F0", VA = "0x187C1C2F0", Slot = "10")]
	public void CBLINJALCDE(IMHPOJOIOJD DONMCNODAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BF90", Offset = "0x7C1B190", VA = "0x187C1BF90", Slot = "11")]
	public void CBLINJALCDE(PBANANEDPKJ OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D700", Offset = "0x7C1C900", VA = "0x187C1D700", Slot = "12")]
	public void MLDEBGIOJAL(PBANANEDPKJ OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D9D0", Offset = "0x7C1CBD0", VA = "0x187C1D9D0", Slot = "13")]
	public void PEEJDHFICOP(PBANANEDPKJ OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CF70", Offset = "0x7C1C170", VA = "0x187C1CF70")]
	private void JJDIMEPHMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xFB5200", Offset = "0xFB4400", VA = "0x180FB5200", Slot = "14")]
	public void LLLOPOFNOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CCE0", Offset = "0x7C1BEE0", VA = "0x187C1CCE0", Slot = "15")]
	public void HLOIDLCMLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B470", Offset = "0x7C1A670", VA = "0x187C1B470", Slot = "16")]
	public void BBICIGKPBLI(IMHPOJOIOJD DONMCNODAED, NAOAHHFOEAM MDOOANEGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D7D0", Offset = "0x7C1C9D0", VA = "0x187C1D7D0", Slot = "17")]
	public void NOEPJLKCJGE(PBANANEDPKJ OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B3A0", Offset = "0x7C1A5A0", VA = "0x187C1B3A0", Slot = "18")]
	public void BBAFNLACGGD(PBANANEDPKJ OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xC24CD0", Offset = "0xC23ED0", VA = "0x180C24CD0", Slot = "19")]
	public void KPMDMMKJHHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D8A0", Offset = "0x7C1CAA0", VA = "0x187C1D8A0", Slot = "20")]
	public void PDECCLNGIPE(NAOAHHFOEAM MDOOANEGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D1E0", Offset = "0x7C1C3E0", VA = "0x187C1D1E0")]
	private void KCNCCLKBIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BBD0", Offset = "0x7C1ADD0", VA = "0x187C1BBD0", Slot = "21")]
	public void BIMDKAAKBLO(IMHPOJOIOJD DONMCNODAED, Vector3 AOGFPLLALGP, Vector3 AGICILCMAEG, Vector3 LIPEJHCDLPH, float PMMKCKEHAPL, float IEECDIDGDFI, IReadOnlyList<Camera> AEEMIEDKFGL, CIDHMNMLPOB JFGHHALANHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B750", Offset = "0x7C1A950", VA = "0x187C1B750", Slot = "22")]
	public void BIMDKAAKBLO(BCIEDBLKKKE AFJALLPMKEA, Vector3 AOGFPLLALGP, Vector3 AGICILCMAEG, Vector3 LIPEJHCDLPH, float PMMKCKEHAPL, float IEECDIDGDFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class KJEAJNIBBLO : HLNIJJBEJBI, JHPAPOCMABL, NNKGPLGHIAD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly IJJPFFPCLNG KMOBICEOLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private int MFEPOJKPPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected Bounds FLEAEEEONOG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds JMIFHGNAJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C26E50", Offset = "0x7C26050", VA = "0x187C26E50", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool LCPIPFNBHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xBFE490", Offset = "0xBFD690", VA = "0x180BFE490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xBFE320", Offset = "0xBFD520", VA = "0x180BFE320")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 OBMDHFFCFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int FLGADCPGBEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA8A350", Offset = "0xA89550", VA = "0x180A8A350", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public EJJJIEFOEML NEHFONPGNCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0C0", Offset = "0x8FA2C0", VA = "0x1808FB0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool MLOPFOLAPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1D13820", Offset = "0x1D12A20", VA = "0x181D13820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	protected KJEAJNIBBLO(IJJPFFPCLNG DONMCNODAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C26E70", Offset = "0x7C26070", VA = "0x187C26E70", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "18")]
	public virtual bool GMBHDEKNHML(HLDKLCEAPAJ DONMCNODAED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C27000", Offset = "0x7C26200", VA = "0x187C27000", Slot = "10")]
	public int PDDDHJNKJKC(int KGKENOEGCDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int CBKLNPJAJPL(EPFADHMLJII MPDJGCJPOLI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int OMLLAEJBBOO(EPFADHMLJII MPDJGCJPOLI);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract KLNMFPLBPMG HPPJOCKJPEJ();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float HCMEIINKEEL();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void HLFGEEMIING(EPFADHMLJII MPDJGCJPOLI, KIPAKEFLEJH DGHGMDFGHDA, int EBHDKCFBPGE = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract HLDKLCEAPAJ DDCPBFLJHAC();

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7C26FD0", Offset = "0x7C261D0", VA = "0x187C26FD0", Slot = "13")]
	public Hash128 LJMEKHKIHKF(int MPDJGCJPOLI)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract CDDHKLNEGHH PBHDFHCEPDM();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract PMEBFNMKDHJ CKLICJMBGAB(EPFADHMLJII MPDJGCJPOLI, JobHandle DLGFKNLCAHD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C26FA0", Offset = "0x7C261A0", VA = "0x187C26FA0", Slot = "12")]
	public PMEBFNMKDHJ JGCBGEFFILJ(int MPDJGCJPOLI)
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
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CF90", Offset = "0x7C2C190", VA = "0x187C2CF90")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MPAKBBOLBGE
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IGDEFBLDANI : IEnumerable<DIIHHALHJJI>, IEnumerable, IEnumerator<DIIHHALHJJI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private DIIHHALHJJI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private DIIHHALHJJI System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xC45340", Offset = "0xC44540", VA = "0x180C45340")]
		[DebuggerHidden]
		public IGDEFBLDANI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C24A50", Offset = "0x7C23C50", VA = "0x187C24A50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C24BC0", Offset = "0x7C23DC0", VA = "0x187C24BC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C24B20", Offset = "0x7C23D20", VA = "0x187C24B20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DIIHHALHJJI> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C24B20", Offset = "0x7C23D20", VA = "0x187C24B20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static DIIHHALHJJI[][] OONFDLJBELI;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static PDIPLFKECGF KKNKBHGAGFJ;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ShapeRendererConfig IPFHCBIGDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A4B0", Offset = "0x7C296B0", VA = "0x187C2A4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ComputeShader ANIEJOMKNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A110", Offset = "0x7C29310", VA = "0x187C2A110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static SkinnedShapeRenderer FELKNGGFFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A740", Offset = "0x7C29940", VA = "0x187C2A740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A690", Offset = "0x7C29890", VA = "0x187C2A690")]
	public static Mesh KNOCEICBCPB(BGAPCNLHHPL AALPHIAJKJH, int MPDJGCJPOLI = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A350", Offset = "0x7C29550", VA = "0x187C2A350")]
	public static int HHLACNICOKA(BGAPCNLHHPL AALPHIAJKJH, int MPDJGCJPOLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A360", Offset = "0x7C29560", VA = "0x187C2A360")]
	public static PDIPLFKECGF IFFCCAHDECN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C299B0", Offset = "0x7C28BB0", VA = "0x187C299B0")]
	[IteratorStateMachine(typeof(IGDEFBLDANI))]
	private static IEnumerable<DIIHHALHJJI> ALJDFKEDFLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C29A10", Offset = "0x7C28C10", VA = "0x187C29A10")]
	public static DIIHHALHJJI FCNAJBFHEMD(BGAPCNLHHPL AALPHIAJKJH, int MPDJGCJPOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A7B0", Offset = "0x7C299B0", VA = "0x187C2A7B0")]
	public static bool MHNCBJCHNAO(this BGAPCNLHHPL AALPHIAJKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A4E0", Offset = "0x7C296E0", VA = "0x187C2A4E0")]
	public static void KMANGDPJHHD(BGAPCNLHHPL AALPHIAJKJH, float3 FAALHNKDNIO, [Out] FJMDKJFOACL JPHLDNEIGMG, [Out] float3 KLIFNCPOBGA, [Out] float KIKJAOKLLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C29CC0", Offset = "0x7C28EC0", VA = "0x187C29CC0")]
	public static void FFCDKOFHENG(Vector3 FAALHNKDNIO, BGAPCNLHHPL AALPHIAJKJH, [Out] Vector3 KLIFNCPOBGA, [Out] float KIKJAOKLLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A7D0", Offset = "0x7C299D0", VA = "0x187C2A7D0")]
	[LOLMJPDMJLG(PGKACFNAKFK.ExitingPlayMode, 0)]
	[PNMOJBOFJBG(0)]
	private static void OBIENNIGCMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A180", Offset = "0x7C29380", VA = "0x187C2A180")]
	[PNMOJBOFJBG(0)]
	[LOLMJPDMJLG(PGKACFNAKFK.ExitingPlayMode, 0)]
	private static void GMPOODPBMHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class NBALCFJLJDH : ELNPEFEPDJC, IDisposable, JAILKKNPFKM
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly ONAHJFPGCEL<IMHPOJOIOJD, IJJPFFPCLNG> LJPFOFOHNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly ONAHJFPGCEL<PBANANEDPKJ, KJEAJNIBBLO> GEDAGMPBHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly ONAHJFPGCEL<BCIEDBLKKKE, OLMFFBLGCLN> CDCNHMLPFIE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IJJPFFPCLNG FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AEA0", Offset = "0x7C2A0A0", VA = "0x187C2AEA0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public KJEAJNIBBLO FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AE40", Offset = "0x7C2A040", VA = "0x187C2AE40", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public OLMFFBLGCLN FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C2ADE0", Offset = "0x7C29FE0", VA = "0x187C2ADE0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DEILIEJMOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xC897D0", Offset = "0xC889D0", VA = "0x180C897D0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xC896C0", Offset = "0xC888C0", VA = "0x180C896C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B320", Offset = "0x7C2A520", VA = "0x187C2B320")]
	public NBALCFJLJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C2ABB0", Offset = "0x7C29DB0", VA = "0x187C2ABB0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AD40", Offset = "0x7C29F40", VA = "0x187C2AD40", Slot = "4")]
	public IMHPOJOIOJD IDILFGPPLEF(HDHNHBENNJN LFDKFEEPNFP)
	{
		return default(IMHPOJOIOJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AD40", Offset = "0x7C29F40", VA = "0x187C2AD40", Slot = "5")]
	public IMHPOJOIOJD IDILFGPPLEF(HDHNHBENNJN LFDKFEEPNFP, bool JBJDLKONOJO)
	{
		return default(IMHPOJOIOJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B090", Offset = "0x7C2A290", VA = "0x187C2B090", Slot = "6")]
	public void LNJADDCDFDF(IMHPOJOIOJD DONMCNODAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AF70", Offset = "0x7C2A170", VA = "0x187C2AF70", Slot = "7")]
	public void KDDMFANMNBI(IMHPOJOIOJD DONMCNODAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AA70", Offset = "0x7C29C70", VA = "0x187C2AA70", Slot = "8")]
	public PBANANEDPKJ CNMOGFDLGMH(IMHPOJOIOJD DONMCNODAED, CHNJCLCIIHF LFDKFEEPNFP)
	{
		return default(PBANANEDPKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A850", Offset = "0x7C29A50", VA = "0x187C2A850", Slot = "9")]
	public PBANANEDPKJ AFFFFFJNNKP(IMHPOJOIOJD DONMCNODAED, OPFNBBFLGAH LFDKFEEPNFP)
	{
		return default(PBANANEDPKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B200", Offset = "0x7C2A400", VA = "0x187C2B200", Slot = "11")]
	public void PPOJNAFMKCE(PBANANEDPKJ OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AA10", Offset = "0x7C29C10", VA = "0x187C2AA10", Slot = "10")]
	public void CMHNFCLKEIP(PBANANEDPKJ OIEMAHGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B190", Offset = "0x7C2A390", VA = "0x187C2B190", Slot = "20")]
	public IEnumerable<Renderer> PIDJDPIJDNG(IMHPOJOIOJD DONMCNODAED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A990", Offset = "0x7C29B90", VA = "0x187C2A990", Slot = "12")]
	public BCIEDBLKKKE CHIKONACMIC(ADAAAHJJBMK LFDKFEEPNFP)
	{
		return default(BCIEDBLKKKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AF00", Offset = "0x7C2A100", VA = "0x187C2AF00", Slot = "14")]
	public void JNFMLDHODLO(BCIEDBLKKKE AFJALLPMKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AC40", Offset = "0x7C29E40", VA = "0x187C2AC40", Slot = "16")]
	public Task EMBODPCNIOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AFF0", Offset = "0x7C2A1F0", VA = "0x187C2AFF0", Slot = "17")]
	public Task KDLBMACPGNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B0F0", Offset = "0x7C2A2F0", VA = "0x187C2B0F0", Slot = "18")]
	public Task NPMFPDGABNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2418B20", Offset = "0x2417D20", VA = "0x182418B20", Slot = "19")]
	public void HDCBNDMCGGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7C2ACE0", Offset = "0x7C29EE0", VA = "0x187C2ACE0", Slot = "13")]
	public void GNDAPGAGGMO(BCIEDBLKKKE AFJALLPMKEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LJEBNMFKCLK
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OMMHOAEPBHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material KMIMOJNMNBA();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material BHCBOOANJNP();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material DFIGAGIFOCM();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DAEMJGIMOPN(HOLOGFIEFDN BODFLPCGHLA);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LDADFAAGOKF(DIABBMOAIAG JFKKLHNAHAM);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GNEJIGEAMFL(GameObject LCACGJDNDHA);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void COGILOKPKBD(GameObject LCACGJDNDHA, bool NNCDAPBOBJJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BDGLINFLOIP
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static LJEBNMFKCLK CMFHMEJHOAJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool OMMHOAEPBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DF80", Offset = "0x7C1D180", VA = "0x187C1DF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E0B0", Offset = "0x7C1D2B0", VA = "0x187C1E0B0")]
	public static void NCKEAFJLPFO(LJEBNMFKCLK OCGKNEJMMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DFE0", Offset = "0x7C1D1E0", VA = "0x187C1DFE0")]
	public static Material KMIMOJNMNBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DCA0", Offset = "0x7C1CEA0", VA = "0x187C1DCA0")]
	public static Material BHCBOOANJNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DE50", Offset = "0x7C1D050", VA = "0x187C1DE50")]
	public static Material DFIGAGIFOCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DDE0", Offset = "0x7C1CFE0", VA = "0x187C1DDE0")]
	public static int DAEMJGIMOPN(HOLOGFIEFDN BODFLPCGHLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E040", Offset = "0x7C1D240", VA = "0x187C1E040")]
	public static int LDADFAAGOKF(DIABBMOAIAG JFKKLHNAHAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DEB0", Offset = "0x7C1D0B0", VA = "0x187C1DEB0")]
	public static void GNEJIGEAMFL(GameObject LCACGJDNDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DD00", Offset = "0x7C1CF00", VA = "0x187C1DD00")]
	public static void COGILOKPKBD(GameObject LCACGJDNDHA, bool NNCDAPBOBJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OLMFFBLGCLN : MMOIPDIAPPN
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NMFGIKIDIPN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public OLMFFBLGCLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xC45340", Offset = "0xC44540", VA = "0x180C45340")]
		[DebuggerHidden]
		public NMFGIKIDIPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BA80", Offset = "0x7C2AC80", VA = "0x187C2BA80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B760", Offset = "0x7C2A960", VA = "0x187C2B760", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B710", Offset = "0x7C2A910", VA = "0x187C2B710")]
		private void MHLANDJELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BA30", Offset = "0x7C2AC30", VA = "0x187C2BA30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B980", Offset = "0x7C2AB80", VA = "0x187C2B980", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B980", Offset = "0x7C2AB80", VA = "0x187C2B980", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly ADAAAHJJBMK GCDDMGCJGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly JAILKKNPFKM DAFNIIIPPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private ENMHFGINAKK EACLNAFGHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<FGGHIKDGEJE> DPNJEINOMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private List<FGGHIKDGEJE> HKCJALAPKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GameObject EPAFOPDMGCM;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7C2BB40", Offset = "0x7C2AD40", VA = "0x187C2BB40")]
	public static OLMFFBLGCLN CMNKGBELFMG(ADAAAHJJBMK LFDKFEEPNFP, JAILKKNPFKM DAFNIIIPPOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7C2CEB0", Offset = "0x7C2C0B0", VA = "0x187C2CEB0")]
	private OLMFFBLGCLN(ADAAAHJJBMK LFDKFEEPNFP, JAILKKNPFKM DAFNIIIPPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C2BF60", Offset = "0x7C2B160", VA = "0x187C2BF60")]
	public void MFBFDNDBONL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7C2BC90", Offset = "0x7C2AE90", VA = "0x187C2BC90")]
	[IteratorStateMachine(typeof(NMFGIKIDIPN))]
	public IEnumerable<Renderer> DALPAPCOBMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2C3F0", Offset = "0x7C2B5F0", VA = "0x187C2C3F0", Slot = "4")]
	public void NDIPPIBFJAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7C2BB10", Offset = "0x7C2AD10", VA = "0x187C2BB10")]
	private void BNFIDFONPJC(Vector3 CJGDNAEFKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7C2BD10", Offset = "0x7C2AF10", VA = "0x187C2BD10")]
	public void MEIPIBBEBLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FGGHIKDGEJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct ICMFMPKNKFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public KIPAKEFLEJH DGCAKIBBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HLDKLCEAPAJ FHCGDALPLOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int EMKGMDDCLPB;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class BCBHIOMHPFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public FGGHIKDGEJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public EPFADHMLJII lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<ICMFMPKNKFK> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public BFAKCFONIOG combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BCBHIOMHPFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DC40", Offset = "0x7C1CE40", VA = "0x187C1DC40")]
		internal JobHandle PPJPMAAMDBO()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DAA0", Offset = "0x7C1CCA0", VA = "0x187C1DAA0")]
		internal void JONDHBOEEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DAD0", Offset = "0x7C1CCD0", VA = "0x187C1DAD0")]
		internal void KLCPMAMKKMI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int[] FFMMPMFHMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private HOMCAHHLHBP BEKDGOJAKLN;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Matrix4x4 OGKGCENKGGM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Mesh BIBONMEPFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int JGGAFOOFKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D30", Offset = "0x8F3F30", VA = "0x1808F4D30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8F54B0", Offset = "0x8F46B0", VA = "0x1808F54B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7C22A80", Offset = "0x7C21C80", VA = "0x187C22A80")]
	public void CGMOFNGFKEM(List<HLDKLCEAPAJ> KIFFAFGHDEG, Matrix4x4[] LFIJJCAHLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7C23160", Offset = "0x7C22360", VA = "0x187C23160")]
	public static List<FGGHIKDGEJE> LHPCDDMHIBB(List<IJJPFFPCLNG> JEOHECPCMDI, EPFADHMLJII MPDJGCJPOLI, Bounds OLDDHKAMBEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7C22DF0", Offset = "0x7C21FF0", VA = "0x187C22DF0")]
	private JobHandle FBACJKDODBG(BFAKCFONIOG EPIKLHNHGHA, int APBMNGIKPKM, int BMEJFKNFGJA, EPFADHMLJII MPDJGCJPOLI, List<ICMFMPKNKFK> FMOFFGDKDOH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7C22C70", Offset = "0x7C21E70", VA = "0x187C22C70")]
	private void DIPDIJFIOBO(List<ICMFMPKNKFK> FMOFFGDKDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7C23990", Offset = "0x7C22B90", VA = "0x187C23990")]
	private FGGHIKDGEJE(List<ICMFMPKNKFK> FMOFFGDKDOH, int APBMNGIKPKM, int BMEJFKNFGJA, EPFADHMLJII MPDJGCJPOLI, Bounds OLDDHKAMBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7C22D50", Offset = "0x7C21F50", VA = "0x187C22D50", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private MaterialPropertyBlock PIGDDIHIIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private FGGHIKDGEJE NNPLONBDKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private List<HLDKLCEAPAJ> OKAIFFGINHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private RenderTexture KKMEMNGPMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeBuffer AAIHHKAKGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ComputeShader IGLKMAHOCJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Matrix4x4[] HLCCHNNHCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int BMCFNAICEAB;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MeshRenderer NNNIGOFPIIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int IGIOGIMMHGI
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7C2DD00", Offset = "0x7C2CF00", VA = "0x187C2DD00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D420", Offset = "0x7C2C620", VA = "0x187C2D420")]
		public static List<SkinnedShapeRenderer> Create(GameObject DONMCNODAED, List<FGGHIKDGEJE> BCGDIBMJAOD, List<HLDKLCEAPAJ> OKAIFFGINHE, Material HGJFBFIMOOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D6D0", Offset = "0x7C2C8D0", VA = "0x187C2D6D0")]
		public void Init(FGGHIKDGEJE NNPLONBDKAB, List<HLDKLCEAPAJ> OKAIFFGINHE, Material HGJFBFIMOOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2DC60", Offset = "0x7C2CE60", VA = "0x187C2DC60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2DBC0", Offset = "0x7C2CDC0", VA = "0x187C2DBC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2DB80", Offset = "0x7C2CD80", VA = "0x187C2DB80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CFF0", Offset = "0x7C2C1F0", VA = "0x187C2CFF0")]
		private void CEDBJEBLEPP(ScriptableRenderContext GCGNIOHLIKK, Camera[] CDHCOFKLGHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D0B0", Offset = "0x7C2C2B0", VA = "0x187C2D0B0")]
		private void CGMOFNGFKEM(CommandBuffer GGLELMAOCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
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

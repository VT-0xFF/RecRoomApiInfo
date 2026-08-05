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
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ShapeRendering;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x887FF20", Offset = "0x887E920", VA = "0x18887FF20", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8887980", Offset = "0x8886380", VA = "0x188887980", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EBHDMCEBIJA : AKKLGEDIGEA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte MMEFPCFJFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] BDNMIJEKPFK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ICNMKAIMKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA58560", Offset = "0xA56F60", VA = "0x180A58560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BBJDGCPPECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB80", Offset = "0xA6D580", VA = "0x180A6EB80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xF69880", Offset = "0xF68280", VA = "0x180F69880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float JJOIIGLOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF20A20", Offset = "0xF1F420", VA = "0x180F20A20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1424210", Offset = "0x1422C10", VA = "0x181424210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float GIPPJGOFHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCE4BB0", Offset = "0xCE35B0", VA = "0x180CE4BB0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCE4BC0", Offset = "0xCE35C0", VA = "0x180CE4BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> AKLBELCFLPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88767E0", Offset = "0x88751E0", VA = "0x1888767E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> OLFNMKGNOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8876AE0", Offset = "0x88754E0", VA = "0x188876AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject PFOPMMBCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA14650", Offset = "0xA13050", VA = "0x180A14650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte NNOCNHAPCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8876830", Offset = "0x8875230", VA = "0x188876830", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8876B10", Offset = "0x8875510", VA = "0x188876B10")]
	public EBHDMCEBIJA(List<IDJHAMENJON> OMMHJMNOHIC, List<IDJHAMENJON> PBGOAAMNNHE, List<KAOEODPJKHN> MLDILJLGELN, Material NJABANIHMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x88769C0", Offset = "0x88753C0", VA = "0x1888769C0")]
	private int PFOICINGDNO(List<IDJHAMENJON> OJOHGKGLJEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8876680", Offset = "0x8875080", VA = "0x188876680")]
	private void BKHKOPHPEAK(int AACEOOKIECP, bool JJAMIIBHPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8876530", Offset = "0x8874F30", VA = "0x188876530")]
	public void AGOMLHNIJNL(Vector3 NGCMBNHLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8876880", Offset = "0x8875280", VA = "0x188876880", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8876980", Offset = "0x8875380", VA = "0x188876980")]
	public void OLJPGFKCEEO(Transform MMGBLIBMNBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IBMMPCOKGKD : JGDJJJJENAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class KDIEOKEGNJO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public IBMMPCOKGKD <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
		[DebuggerHidden]
		public KDIEOKEGNJO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x887FD30", Offset = "0x887E730", VA = "0x18887FD30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x887F6D0", Offset = "0x887E0D0", VA = "0x18887F6D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x887F680", Offset = "0x887E080", VA = "0x18887F680")]
		private void KIPLFAABBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x887FBE0", Offset = "0x887E5E0", VA = "0x18887FBE0")]
		private void NODCBNAELMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x887F630", Offset = "0x887E030", VA = "0x18887F630")]
		private void DGNMECDNGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x887FCE0", Offset = "0x887E6E0", VA = "0x18887FCE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x887FC30", Offset = "0x887E630", VA = "0x18887FC30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x887FC30", Offset = "0x887E630", VA = "0x18887FC30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class IAFKHEDFDGK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public IBMMPCOKGKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
		[DebuggerHidden]
		public IAFKHEDFDGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8877B00", Offset = "0x8876500", VA = "0x188877B00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8877640", Offset = "0x8876040", VA = "0x188877640", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x88775F0", Offset = "0x8875FF0", VA = "0x1888775F0")]
		private void KIPLFAABBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88779B0", Offset = "0x88763B0", VA = "0x1888779B0")]
		private void NODCBNAELMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8877AB0", Offset = "0x88764B0", VA = "0x188877AB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8877A00", Offset = "0x8876400", VA = "0x188877A00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8877A00", Offset = "0x8876400", VA = "0x188877A00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FMGFLKNPHAK NEPADDKILLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<DMEPONLJMAJ> DBDPBKIMPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> JKEHMIDKOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer GJMLEPLKJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool KIFBEOBDEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool BKNMIDFONFE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<GLCEOGMEDLC> LNNJLIGCEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GENNFNANHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x887A5B0", Offset = "0x8878FB0", VA = "0x18887A5B0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public KAOEODPJKHN NCNEPMNEEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x887AF60", Offset = "0x8879960", VA = "0x18887AF60", Slot = "8")]
		get
		{
			return default(KAOEODPJKHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> PENMANOBLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA10D40", Offset = "0xA0F740", VA = "0x180A10D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x887AC50", Offset = "0x8879650", VA = "0x18887AC50")]
	private bool JCKKFCBKGHG(DMEPONLJMAJ EBHEGJDIFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x887A5F0", Offset = "0x8878FF0", VA = "0x18887A5F0")]
	private static bool CEDIBDPPDJA(DMEPONLJMAJ EBHEGJDIFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x887BF80", Offset = "0x887A980", VA = "0x18887BF80")]
	public IBMMPCOKGKD(FMGFLKNPHAK HPGIDELCODH, bool DIPOGCPAMGE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x887A770", Offset = "0x8879170", VA = "0x18887A770", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x887BCC0", Offset = "0x887A6C0", VA = "0x18887BCC0")]
	public void PBDMKLNODMP(DMEPONLJMAJ EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x887A610", Offset = "0x8879010", VA = "0x18887A610")]
	public void DAAFLACHELB(DMEPONLJMAJ EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x887B6F0", Offset = "0x887A0F0", VA = "0x18887B6F0", Slot = "4")]
	public void OEOAKNGGJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x887A9E0", Offset = "0x88793E0", VA = "0x18887A9E0")]
	public void FPILOHDMIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x887AC70", Offset = "0x8879670", VA = "0x18887AC70")]
	private void JGKDAOLMGMG(List<DMEPONLJMAJ> DBDPBKIMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x887B690", Offset = "0x887A090", VA = "0x18887B690")]
	private static Material MGEGDPMBPMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x887AE30", Offset = "0x8879830", VA = "0x18887AE30")]
	private void JGKDAOLMGMG(DMEPONLJMAJ EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x887BBF0", Offset = "0x887A5F0", VA = "0x18887BBF0")]
	private void PAFCFBDGAAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x887B020", Offset = "0x8879A20", VA = "0x18887B020")]
	public void LMBEICFKMFP(bool EFAGKGKBGPD, bool PMGOBJDCBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x887B5D0", Offset = "0x8879FD0", VA = "0x18887B5D0")]
	protected void MEHFDPBDJJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x887A960", Offset = "0x8879360", VA = "0x18887A960")]
	public void EMEKPIGLNBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x887AEE0", Offset = "0x88798E0", VA = "0x18887AEE0")]
	[IteratorStateMachine(typeof(KDIEOKEGNJO))]
	public IEnumerable<Renderer> LDCCEEBDNNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x887BF00", Offset = "0x887A900", VA = "0x18887BF00")]
	[IteratorStateMachine(typeof(IAFKHEDFDGK))]
	public IEnumerable<Renderer> PJNCNMGDIOM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class NMMKKKOIBLC : DMEPONLJMAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct OKEJILBEJPG : CJOCNIBBEIJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OBIKIJDJKFN DLOFNMELGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle IGNDKHDOGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private ILHJDALCNJE IBNDHFHACLN;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8884370", Offset = "0x8882D70", VA = "0x188884370")]
		public OKEJILBEJPG(OBIKIJDJKFN DLOFNMELGLP, JobHandle IGNDKHDOGPP, ILHJDALCNJE IBNDHFHACLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8884340", Offset = "0x8882D40", VA = "0x188884340", Slot = "4")]
		public OBIKIJDJKFN OJMNFFHOAPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x88842F0", Offset = "0x8882CF0", VA = "0x1888842F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly AJFNDLNEHCE KFEGKBIIJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float AFLFHGGBDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 DIFGCCPNDDF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 EMEBEKOEEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8883B20", Offset = "0x8882520", VA = "0x188883B20", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8884240", Offset = "0x8882C40", VA = "0x188884240")]
	public NMMKKKOIBLC(IBMMPCOKGKD ALPBGLGCPNB, AJFNDLNEHCE HPGIDELCODH, bool DIPOGCPAMGE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "18")]
	public override bool COMGDOONCCC(KAOEODPJKHN ALPBGLGCPNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8884070", Offset = "0x8882A70", VA = "0x188884070", Slot = "19")]
	public override int PFOICINGDNO(JFJFDHAJDJF GIFLHFGNGDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8882F10", Offset = "0x8881910", VA = "0x188882F10", Slot = "20")]
	public override int GFGIHMKMIAF(JFJFDHAJDJF GIFLHFGNGDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8883C40", Offset = "0x8882640", VA = "0x188883C40", Slot = "21")]
	public override ABABCOIOEKK OGNKBCMIMHP()
	{
		return default(ABABCOIOEKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xA6EB60", Offset = "0xA6D560", VA = "0x180A6EB60", Slot = "22")]
	public override float CAIFACFAAIJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8882920", Offset = "0x8881320", VA = "0x188882920", Slot = "23")]
	public override void BHFGKCNALAP(JFJFDHAJDJF GIFLHFGNGDL, LFIEOCGBIDH EJDHNICBAOA, int PCPDKODOKEB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x88830E0", Offset = "0x8881AE0", VA = "0x1888830E0", Slot = "24")]
	public override KAOEODPJKHN IGIPFCFHKPG()
	{
		return default(KAOEODPJKHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8883970", Offset = "0x8882370", VA = "0x188883970", Slot = "26")]
	public override IBCOAJMBAFN KABAPHJGIHB()
	{
		return default(IBCOAJMBAFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x88831B0", Offset = "0x8881BB0", VA = "0x1888831B0", Slot = "27")]
	public override CJOCNIBBEIJ IPJFNLGDPOP(JFJFDHAJDJF GIFLHFGNGDL, JobHandle IGNDKHDOGPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface CNPKIJCCPJE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IBMMPCOKGKD OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DMEPONLJMAJ OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IFKLCLLECFG OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class CFGFINPGBNG : JHOAFMOCPOK, IDisposable, CNPKIJCCPJE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OMHJECGKKNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CFGFINPGBNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x88843D0", Offset = "0x8882DD0", VA = "0x1888843D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8884930", Offset = "0x8883330", VA = "0x188884930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly HFOEGHGDEEB<LFLLENECNAF, IBMMPCOKGKD> NBKPPJEFDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HFOEGHGDEEB<OOCANPCELJK, DMEPONLJMAJ> DBDPBKIMPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HFOEGHGDEEB<DNKOMFHFFCL, IFKLCLLECFG> NGJBFMKHMCP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IBMMPCOKGKD OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8873C70", Offset = "0x8872670", VA = "0x188873C70", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DMEPONLJMAJ OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8873CD0", Offset = "0x88726D0", VA = "0x188873CD0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IFKLCLLECFG OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8873C10", Offset = "0x8872610", VA = "0x188873C10", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CAAOAGNEBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB70", Offset = "0xA6D570", VA = "0x180A6EB70", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7D0", Offset = "0xA6D1D0", VA = "0x180A6E7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8875D60", Offset = "0x8874760", VA = "0x188875D60")]
	public CFGFINPGBNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8874A00", Offset = "0x8873400", VA = "0x188874A00", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8874E30", Offset = "0x8873830", VA = "0x188874E30", Slot = "4")]
	public LFLLENECNAF EJPILKBGIJI(FMGFLKNPHAK HPGIDELCODH)
	{
		return default(LFLLENECNAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8874BC0", Offset = "0x88735C0", VA = "0x188874BC0", Slot = "5")]
	public LFLLENECNAF EJPILKBGIJI(FMGFLKNPHAK HPGIDELCODH, bool DIPOGCPAMGE)
	{
		return default(LFLLENECNAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8874740", Offset = "0x8873140", VA = "0x188874740", Slot = "6")]
	public void DMMDOGNECGG(LFLLENECNAF ALPBGLGCPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8875A20", Offset = "0x8874420", VA = "0x188875A20", Slot = "7")]
	public void PFHEDFBHNGC(LFLLENECNAF ALPBGLGCPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x88740D0", Offset = "0x8872AD0", VA = "0x1888740D0", Slot = "8")]
	public OOCANPCELJK CFAMFCAMGPE(LFLLENECNAF ALPBGLGCPNB, AELOEGAHNAG HPGIDELCODH)
	{
		return default(OOCANPCELJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8875180", Offset = "0x8873B80", VA = "0x188875180", Slot = "9")]
	public OOCANPCELJK GILHDFEMJMM(LFLLENECNAF ALPBGLGCPNB, AJFNDLNEHCE HPGIDELCODH)
	{
		return default(OOCANPCELJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8873D30", Offset = "0x8872730", VA = "0x188873D30", Slot = "11")]
	public void BOAHMPJCLCE(OOCANPCELJK EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8874F30", Offset = "0x8873930", VA = "0x188874F30", Slot = "10")]
	public void FECDEOJHEFM(OOCANPCELJK EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8874990", Offset = "0x8873390", VA = "0x188874990", Slot = "20")]
	public IEnumerable<Renderer> DPPHMFGBOHN(LFLLENECNAF ALPBGLGCPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x88757E0", Offset = "0x88741E0", VA = "0x1888757E0", Slot = "12")]
	public DNKOMFHFFCL KIMGJIPFGJL(IBJOONGDNBK HPGIDELCODH)
	{
		return default(DNKOMFHFFCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x88756A0", Offset = "0x88740A0", VA = "0x1888756A0", Slot = "14")]
	public void JEMICJCLABE(DNKOMFHFFCL NEKJLPNDJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8875860", Offset = "0x8874260", VA = "0x188875860", Slot = "16")]
	public Task OGJFPLEDIBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8874590", Offset = "0x8872F90", VA = "0x188874590", Slot = "17")]
	public Task DBDFJFPMIMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8875710", Offset = "0x8874110", VA = "0x188875710", Slot = "18")]
	[AsyncStateMachine(typeof(OMHJECGKKNA))]
	public Task KCPNFEJFKLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8874E40", Offset = "0x8873840", VA = "0x188874E40", Slot = "19")]
	public void ELNPLNNDPEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8875640", Offset = "0x8874040", VA = "0x188875640", Slot = "13")]
	public void GOCCGOFPGHI(DNKOMFHFFCL NEKJLPNDJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class NDDNKGHIFEE : DMEPONLJMAJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct DMDNMFLBIEK : CJOCNIBBEIJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private OBIKIJDJKFN DLOFNMELGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> LBIHHKAKOJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle IGNDKHDOGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private FGANABJEDPE IBNDHFHACLN;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x88762E0", Offset = "0x8874CE0", VA = "0x1888762E0")]
		public DMDNMFLBIEK(OBIKIJDJKFN DLOFNMELGLP, NativeArray<int> LBIHHKAKOJN, JobHandle IGNDKHDOGPP, FGANABJEDPE IBNDHFHACLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8876280", Offset = "0x8874C80", VA = "0x188876280", Slot = "4")]
		public OBIKIJDJKFN OJMNFFHOAPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x88761E0", Offset = "0x8874BE0", VA = "0x1888761E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly AELOEGAHNAG JLKLNDPHPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] FBDDMCBBAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 DIFGCCPNDDF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 GLKKJDLGKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8880F30", Offset = "0x887F930", VA = "0x188880F30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 EMEBEKOEEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8881FB0", Offset = "0x88809B0", VA = "0x188881FB0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8882820", Offset = "0x8881220", VA = "0x188882820")]
	public NDDNKGHIFEE(IBMMPCOKGKD ALPBGLGCPNB, AELOEGAHNAG HPGIDELCODH, bool OJKCDPHFCHN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8881160", Offset = "0x887FB60", VA = "0x188881160", Slot = "18")]
	public override bool COMGDOONCCC(KAOEODPJKHN ALPBGLGCPNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8882730", Offset = "0x8881130", VA = "0x188882730", Slot = "21")]
	public override ABABCOIOEKK OGNKBCMIMHP()
	{
		return default(ABABCOIOEKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x88820D0", Offset = "0x8880AD0", VA = "0x1888820D0")]
	private ABABCOIOEKK OGNKBCMIMHP(KAOEODPJKHN ALPBGLGCPNB)
	{
		return default(ABABCOIOEKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8880D30", Offset = "0x887F730", VA = "0x188880D30")]
	private BMJGOENACJN CHHJIMEKKIK([In] UniformTRS EHEFGMGMKGJ, [In] float3 NJFGCDBKBKO)
	{
		return default(BMJGOENACJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8882770", Offset = "0x8881170", VA = "0x188882770", Slot = "19")]
	public override int PFOICINGDNO(JFJFDHAJDJF GIFLHFGNGDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8881230", Offset = "0x887FC30", VA = "0x188881230", Slot = "20")]
	public override int GFGIHMKMIAF(JFJFDHAJDJF GIFLHFGNGDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8880C40", Offset = "0x887F640", VA = "0x188880C40", Slot = "22")]
	public override float CAIFACFAAIJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8881D30", Offset = "0x8880730", VA = "0x188881D30")]
	private int LLLHNODGLMI(JFJFDHAJDJF GIFLHFGNGDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8880400", Offset = "0x887EE00", VA = "0x188880400", Slot = "23")]
	public override void BHFGKCNALAP(JFJFDHAJDJF GIFLHFGNGDL, LFIEOCGBIDH EJDHNICBAOA, int PCPDKODOKEB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x88812E0", Offset = "0x887FCE0", VA = "0x1888812E0", Slot = "24")]
	public override KAOEODPJKHN IGIPFCFHKPG()
	{
		return default(KAOEODPJKHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8881B80", Offset = "0x8880580", VA = "0x188881B80", Slot = "26")]
	public override IBCOAJMBAFN KABAPHJGIHB()
	{
		return default(IBCOAJMBAFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x88813B0", Offset = "0x887FDB0", VA = "0x1888813B0", Slot = "27")]
	public override CJOCNIBBEIJ IPJFNLGDPOP(JFJFDHAJDJF GIFLHFGNGDL, JobHandle IGNDKHDOGPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NEEDFNMBHLA
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNAEIFENEPH(EJEKANEOHGI HHCAOFMCNLG, Renderer EDDLIJIPFEO, int EEOFLEFGGNH);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICDAJJFLHAJ(Renderer EDDLIJIPFEO, DLBMCHLGFNN HPJMJFCDFBG, Vector3 KBMNGNLKIGM, Vector3 MFLAHHCNGLE, Vector3 JFKFLLJIFEB, float BCDGHNGOJIJ, float AGKCFKEOFLP, float LONDMCDHEJC = -1f, [Optional] Color? JJNDBAIEAAG, [Optional] IReadOnlyList<Camera> FEGAKHLCPOH);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHALLHAGKON(Renderer EDDLIJIPFEO, int EEOFLEFGGNH);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CLLKNNKPENG();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GCIJDMJNPCL(int CHBGCBHIIMD, LBAACCFPEFG HHCAOFMCNLG, Renderer EDDLIJIPFEO, int EEOFLEFGGNH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IBGKHLGKOPI : KCOGCHBFLDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class NFDFBAHNOCD : KFPBHFOFPBO<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x88828D0", Offset = "0x88812D0", VA = "0x1888828D0")]
		public NFDFBAHNOCD(string GBCFHNGPBLM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NEEDFNMBHLA MHCOBCFGNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CNPKIJCCPJE OGOEGIHHMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer IHHIKEGNIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private NFDFBAHNOCD EEPCKHBLIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool LCMICEGIKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer ABDFNDAFBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private NFDFBAHNOCD EIPMAGHLNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool GBEGLOBPDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer DEMBGJFAKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private NFDFBAHNOCD CBDPNDMFMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool NHIPMLCBEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool KJMPONALMPD;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA143A0", Offset = "0xA12DA0", VA = "0x180A143A0")]
	public IBGKHLGKOPI(NEEDFNMBHLA IPFPKOEJOJM, CNPKIJCCPJE OGOEGIHHMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x88787A0", Offset = "0x88771A0", VA = "0x1888787A0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8878EA0", Offset = "0x88778A0", VA = "0x188878EA0")]
	private void KAJLJPFJGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8877C30", Offset = "0x8876630", VA = "0x188877C30", Slot = "4")]
	public void DAAOMHGJHAK(LFLLENECNAF ALPBGLGCPNB, LBAACCFPEFG LKIOAPBFPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8877F40", Offset = "0x8876940", VA = "0x188877F40", Slot = "5")]
	public void DAAOMHGJHAK(OOCANPCELJK EBHEGJDIFIE, LBAACCFPEFG LKIOAPBFPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8879CE0", Offset = "0x88786E0", VA = "0x188879CE0", Slot = "6")]
	public void NOKHANKGKKP(OOCANPCELJK EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8879E40", Offset = "0x8878840", VA = "0x188879E40", Slot = "7")]
	public void PFEDKGPLKLO(OOCANPCELJK EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8878CC0", Offset = "0x88776C0", VA = "0x188878CC0", Slot = "24")]
	public void HABDEJBPCAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1126170", Offset = "0x1124B70", VA = "0x181126170", Slot = "8")]
	public void OKMBNCLNBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8878A80", Offset = "0x8877480", VA = "0x188878A80", Slot = "9")]
	public void EPODPJADIIN(LBAACCFPEFG LKIOAPBFPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x88784C0", Offset = "0x8876EC0", VA = "0x1888784C0", Slot = "10")]
	public void DGIOOHAPIIE(LFLLENECNAF ALPBGLGCPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8878160", Offset = "0x8876B60", VA = "0x188878160", Slot = "11")]
	public void DGIOOHAPIIE(OOCANPCELJK EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8878BF0", Offset = "0x88775F0", VA = "0x188878BF0", Slot = "12")]
	public void FAOAOJCMAPL(OOCANPCELJK EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x887A4E0", Offset = "0x8878EE0", VA = "0x18887A4E0", Slot = "13")]
	public void PPLNABCOFEK(OOCANPCELJK EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8879110", Offset = "0x8877B10", VA = "0x188879110")]
	private void LKOJMMKFBCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1453D80", Offset = "0x1452780", VA = "0x181453D80", Slot = "14")]
	public void AJHCOGGJGCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8879BC0", Offset = "0x88785C0", VA = "0x188879BC0", Slot = "15")]
	public void NIHAPIKLNBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8879F90", Offset = "0x8878990", VA = "0x188879F90", Slot = "16")]
	public void PHPJBPPLLDD(LFLLENECNAF ALPBGLGCPNB, EJEKANEOHGI HHCAOFMCNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8878DD0", Offset = "0x88777D0", VA = "0x188878DD0", Slot = "17")]
	public void HMNCFDAGMCH(OOCANPCELJK EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8878D00", Offset = "0x8877700", VA = "0x188878D00", Slot = "18")]
	public void HBHECLAAPNC(OOCANPCELJK EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xD25CD0", Offset = "0xD246D0", VA = "0x180D25CD0", Slot = "19")]
	public void ELKMGPGENIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8878950", Offset = "0x8877350", VA = "0x188878950", Slot = "20")]
	public void EBFHKNPAFCE(EJEKANEOHGI HHCAOFMCNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x887A270", Offset = "0x8878C70", VA = "0x18887A270")]
	private void POBABIGLMND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8879800", Offset = "0x8878200", VA = "0x188879800", Slot = "21")]
	public void NFDIBADABAM(LFLLENECNAF ALPBGLGCPNB, Vector3 KBMNGNLKIGM, Vector3 MFLAHHCNGLE, Vector3 JFKFLLJIFEB, float BCDGHNGOJIJ, float AGKCFKEOFLP, IReadOnlyList<Camera> JENGAHABIPB, DLBMCHLGFNN HPJMJFCDFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8879380", Offset = "0x8877D80", VA = "0x188879380", Slot = "22")]
	public void NFDIBADABAM(DNKOMFHFFCL NEKJLPNDJKJ, Vector3 KBMNGNLKIGM, Vector3 MFLAHHCNGLE, Vector3 JFKFLLJIFEB, float BCDGHNGOJIJ, float AGKCFKEOFLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class DMEPONLJMAJ : KBFDCHCJJPN, GLCEOGMEDLC, LMECPCGFLBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly IBMMPCOKGKD PFOPMMBCMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int CJHJAEHHOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds EFFPIKDEDDF;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds EPENBGJDEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x88763A0", Offset = "0x8874DA0", VA = "0x1888763A0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool BKNMIDFONFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xE06CF0", Offset = "0xE056F0", VA = "0x180E06CF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xE07250", Offset = "0xE05C50", VA = "0x180E07250")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 EMEBEKOEEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MIMFMLDMFMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA62010", Offset = "0xA60A10", VA = "0x180A62010", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public FBDGNCMLOPA EFFFFOCJMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA10D40", Offset = "0xA0F740", VA = "0x180A10D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool KDKPLJKNMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xF53120", Offset = "0xF51B20", VA = "0x180F53120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	protected DMEPONLJMAJ(IBMMPCOKGKD ALPBGLGCPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x88763C0", Offset = "0x8874DC0", VA = "0x1888763C0", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "18")]
	public virtual bool COMGDOONCCC(KAOEODPJKHN ALPBGLGCPNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8876520", Offset = "0x8874F20", VA = "0x188876520", Slot = "10")]
	public int GDJACHJHFCK(int CHOBMAICDPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int PFOICINGDNO(JFJFDHAJDJF GIFLHFGNGDL);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int GFGIHMKMIAF(JFJFDHAJDJF GIFLHFGNGDL);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract ABABCOIOEKK OGNKBCMIMHP();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float CAIFACFAAIJ();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void BHFGKCNALAP(JFJFDHAJDJF GIFLHFGNGDL, LFIEOCGBIDH EJDHNICBAOA, int PCPDKODOKEB = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract KAOEODPJKHN IGIPFCFHKPG();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8876340", Offset = "0x8874D40", VA = "0x188876340", Slot = "13")]
	public Hash128 ADDNLGDBAPC(int GIFLHFGNGDL)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract IBCOAJMBAFN KABAPHJGIHB();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract CJOCNIBBEIJ IPJFNLGDPOP(JFJFDHAJDJF GIFLHFGNGDL, JobHandle IGNDKHDOGPP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8876370", Offset = "0x8874D70", VA = "0x188876370", Slot = "12")]
	public CJOCNIBBEIJ CAEHDCEIGIB(int GIFLHFGNGDL)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ShapeRendererConfig : SingletonScriptableObject<ShapeRendererConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8886490", Offset = "0x8884E90", VA = "0x188886490")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PNPHFHDFPBG
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HEJADPDGNLP : IEnumerable<MKHOMJCMJMM>, IEnumerable, IEnumerator<MKHOMJCMJMM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private MKHOMJCMJMM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private MKHOMJCMJMM System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
		[DebuggerHidden]
		public HEJADPDGNLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8877230", Offset = "0x8875C30", VA = "0x188877230", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x88773A0", Offset = "0x8875DA0", VA = "0x1888773A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8877300", Offset = "0x8875D00", VA = "0x188877300", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MKHOMJCMJMM> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8877300", Offset = "0x8875D00", VA = "0x188877300", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static MKHOMJCMJMM[][] GBFIPPJPJOJ;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static CLFODPPGGPD HOAIDGPPGBK;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig EBBAADDPMMC;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader CEELLJKPKPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8886180", Offset = "0x8884B80", VA = "0x188886180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer DCMFBLOLJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8885EC0", Offset = "0x88848C0", VA = "0x188885EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x88857F0", Offset = "0x88841F0", VA = "0x1888857F0")]
	[HHPMDADMJLL]
	internal static void DBILOAODCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8885F20", Offset = "0x8884920", VA = "0x188885F20")]
	public static Mesh JNPPDKNGCFH(CMGHNAKJDFM FNGDOLGHKPO, int GIFLHFGNGDL = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x88858F0", Offset = "0x88842F0", VA = "0x1888858F0")]
	public static int EPCHMOKDBMM(CMGHNAKJDFM FNGDOLGHKPO, int GIFLHFGNGDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8885CC0", Offset = "0x88846C0", VA = "0x188885CC0")]
	public static CLFODPPGGPD HBBDKEKLGID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8885790", Offset = "0x8884190", VA = "0x188885790")]
	[IteratorStateMachine(typeof(HEJADPDGNLP))]
	private static IEnumerable<MKHOMJCMJMM> APLJCFLCAPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8884990", Offset = "0x8883390", VA = "0x188884990")]
	public static MKHOMJCMJMM AHPENNEPKKD(CMGHNAKJDFM FNGDOLGHKPO, int GIFLHFGNGDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x88858D0", Offset = "0x88842D0", VA = "0x1888858D0")]
	public static bool EJPCNEHLPCN(this CMGHNAKJDFM FNGDOLGHKPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8885FC0", Offset = "0x88849C0", VA = "0x188885FC0")]
	public static void KFEDNCIIPBP(CMGHNAKJDFM FNGDOLGHKPO, float3 AGKGEHKKPOG, [Out] ACHHALDOFOD IIAEHNHFBAC, [Out] float3 GOEICEDAIIK, [Out] float KEHJOKDEKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8885900", Offset = "0x8884300", VA = "0x188885900")]
	public static void GLLCCJHMPHC(Vector3 AGKGEHKKPOG, CMGHNAKJDFM FNGDOLGHKPO, [Out] Vector3 GOEICEDAIIK, [Out] float KEHJOKDEKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8886170", Offset = "0x8884B70", VA = "0x188886170")]
	[DLAFCMGADCM(0)]
	[GPJJBKJGJGP(KJANOBAIENP.ExitingPlayMode, 0)]
	private static void LCLJEGNOGML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x88861E0", Offset = "0x8884BE0", VA = "0x1888861E0")]
	[DLAFCMGADCM(0)]
	[GPJJBKJGJGP(KJANOBAIENP.ExitingPlayMode, 0)]
	private static void NLJNMJPBHLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class KBMEDIDCELF : JHOAFMOCPOK, IDisposable, CNPKIJCCPJE
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly HFOEGHGDEEB<LFLLENECNAF, IBMMPCOKGKD> NBKPPJEFDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HFOEGHGDEEB<OOCANPCELJK, DMEPONLJMAJ> DBDPBKIMPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly HFOEGHGDEEB<DNKOMFHFFCL, IFKLCLLECFG> NGJBFMKHMCP;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IBMMPCOKGKD OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x887E870", Offset = "0x887D270", VA = "0x18887E870", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public DMEPONLJMAJ OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x887E810", Offset = "0x887D210", VA = "0x18887E810", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IFKLCLLECFG OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x887E7B0", Offset = "0x887D1B0", VA = "0x18887E7B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CAAOAGNEBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB70", Offset = "0xA6D570", VA = "0x180A6EB70", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7D0", Offset = "0xA6D1D0", VA = "0x180A6E7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x887F270", Offset = "0x887DC70", VA = "0x18887F270")]
	public KBMEDIDCELF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x887EC10", Offset = "0x887D610", VA = "0x18887EC10", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x887ECA0", Offset = "0x887D6A0", VA = "0x18887ECA0", Slot = "4")]
	public LFLLENECNAF EJPILKBGIJI(FMGFLKNPHAK HPGIDELCODH)
	{
		return default(LFLLENECNAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x887ECA0", Offset = "0x887D6A0", VA = "0x18887ECA0", Slot = "5")]
	public LFLLENECNAF EJPILKBGIJI(FMGFLKNPHAK HPGIDELCODH, bool DIPOGCPAMGE)
	{
		return default(LFLLENECNAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x887EB40", Offset = "0x887D540", VA = "0x18887EB40", Slot = "6")]
	public void DMMDOGNECGG(LFLLENECNAF ALPBGLGCPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x887F170", Offset = "0x887DB70", VA = "0x18887F170", Slot = "7")]
	public void PFHEDFBHNGC(LFLLENECNAF ALPBGLGCPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x887E960", Offset = "0x887D360", VA = "0x18887E960", Slot = "8")]
	public OOCANPCELJK CFAMFCAMGPE(LFLLENECNAF ALPBGLGCPNB, AELOEGAHNAG HPGIDELCODH)
	{
		return default(OOCANPCELJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x887EDA0", Offset = "0x887D7A0", VA = "0x18887EDA0", Slot = "9")]
	public OOCANPCELJK GILHDFEMJMM(LFLLENECNAF ALPBGLGCPNB, AJFNDLNEHCE HPGIDELCODH)
	{
		return default(OOCANPCELJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x887E8D0", Offset = "0x887D2D0", VA = "0x18887E8D0", Slot = "11")]
	public void BOAHMPJCLCE(OOCANPCELJK EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x887ED40", Offset = "0x887D740", VA = "0x18887ED40", Slot = "10")]
	public void FECDEOJHEFM(OOCANPCELJK EBHEGJDIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x887EBA0", Offset = "0x887D5A0", VA = "0x18887EBA0", Slot = "20")]
	public IEnumerable<Renderer> DPPHMFGBOHN(LFLLENECNAF ALPBGLGCPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x887F050", Offset = "0x887DA50", VA = "0x18887F050", Slot = "12")]
	public DNKOMFHFFCL KIMGJIPFGJL(IBJOONGDNBK HPGIDELCODH)
	{
		return default(DNKOMFHFFCL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x887EF40", Offset = "0x887D940", VA = "0x18887EF40", Slot = "14")]
	public void JEMICJCLABE(DNKOMFHFFCL NEKJLPNDJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x887F0D0", Offset = "0x887DAD0", VA = "0x18887F0D0", Slot = "16")]
	public Task OGJFPLEDIBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x887EAA0", Offset = "0x887D4A0", VA = "0x18887EAA0", Slot = "17")]
	public Task DBDFJFPMIMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x887EFB0", Offset = "0x887D9B0", VA = "0x18887EFB0", Slot = "18")]
	public Task KCPNFEJFKLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x27C4C40", Offset = "0x27C3640", VA = "0x1827C4C40", Slot = "19")]
	public void ELNPLNNDPEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x887EEE0", Offset = "0x887D8E0", VA = "0x18887EEE0", Slot = "13")]
	public void GOCCGOFPGHI(DNKOMFHFFCL NEKJLPNDJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FFHPIBHHIHO
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool PDLJNDGLFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material CAGICJFHPFD();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material MGEGDPMBPMF();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material GHNFLOBABMB();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PMIJACPGGEJ(AOFPBDKJHJG PMELCIJHALK);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NJMGBJEAPPF(OCLKLGODOEL OGKDLOKMIIJ);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DEMCFHMGBIE(GameObject OJDHMKOBKLD);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CDBJPOKMPLD(GameObject OJDHMKOBKLD, bool JACDDIIGPEO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MEEBLIGAGKG
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static FFHPIBHHIHO LALBBHEFJAE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool PDLJNDGLFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x88802C0", Offset = "0x887ECC0", VA = "0x1888802C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x887FFF0", Offset = "0x887E9F0", VA = "0x18887FFF0")]
	public static void BJBMDAGLCAJ(FFHPIBHHIHO OCHEGBKHIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8880040", Offset = "0x887EA40", VA = "0x188880040")]
	public static Material CAGICJFHPFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x887B690", Offset = "0x887A090", VA = "0x18887B690")]
	public static Material MGEGDPMBPMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8880260", Offset = "0x887EC60", VA = "0x188880260")]
	public static Material GHNFLOBABMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8880390", Offset = "0x887ED90", VA = "0x188880390")]
	public static int PMIJACPGGEJ(AOFPBDKJHJG PMELCIJHALK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8880320", Offset = "0x887ED20", VA = "0x188880320")]
	public static int NJMGBJEAPPF(OCLKLGODOEL OGKDLOKMIIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8880180", Offset = "0x887EB80", VA = "0x188880180")]
	public static void DEMCFHMGBIE(GameObject OJDHMKOBKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x88800A0", Offset = "0x887EAA0", VA = "0x1888800A0")]
	public static void CDBJPOKMPLD(GameObject OJDHMKOBKLD, bool JACDDIIGPEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class IFKLCLLECFG : JGDJJJJENAJ
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class GDEDKDJHKOM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IFKLCLLECFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
		[DebuggerHidden]
		public GDEDKDJHKOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x88771A0", Offset = "0x8875BA0", VA = "0x1888771A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8876E80", Offset = "0x8875880", VA = "0x188876E80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8876E30", Offset = "0x8875830", VA = "0x188876E30")]
		private void KIPLFAABBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8877150", Offset = "0x8875B50", VA = "0x188877150", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x88770A0", Offset = "0x8875AA0", VA = "0x1888770A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x88770A0", Offset = "0x8875AA0", VA = "0x1888770A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IBJOONGDNBK AFHKEOMDLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CNPKIJCCPJE OGOEGIHHMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private EBHDMCEBIJA GDPEJDPNBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<IDJHAMENJON> CNDBIIHOFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<IDJHAMENJON> GLIPPEJHNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject FGFAOANCFHE;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x887D5B0", Offset = "0x887BFB0", VA = "0x18887D5B0")]
	public static IFKLCLLECFG GDPIPDNLCBN(IBJOONGDNBK HPGIDELCODH, CNPKIJCCPJE OGOEGIHHMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x887E6D0", Offset = "0x887D0D0", VA = "0x18887E6D0")]
	private IFKLCLLECFG(IBJOONGDNBK HPGIDELCODH, CNPKIJCCPJE OGOEGIHHMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x887D730", Offset = "0x887C130", VA = "0x18887D730")]
	public void IIPIKJHBJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x887DBB0", Offset = "0x887C5B0", VA = "0x18887DBB0")]
	[IteratorStateMachine(typeof(GDEDKDJHKOM))]
	public IEnumerable<Renderer> LDCCEEBDNNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x887DC30", Offset = "0x887C630", VA = "0x18887DC30", Slot = "4")]
	public void OEOAKNGGJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x887D700", Offset = "0x887C100", VA = "0x18887D700")]
	private void ICKDDOCMKFF(Vector3 NGCMBNHLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x887D360", Offset = "0x887BD60", VA = "0x18887D360")]
	public void FPILOHDMIEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IDJHAMENJON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct IGCAGNJHJOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public LFIEOCGBIDH CAMJICFMFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public KAOEODPJKHN BNGNIEKAANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int KAHNLLANKBF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HMJFACECNLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public IDJHAMENJON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public JFJFDHAJDJF lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<IGCAGNJHJOD> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public OBIKIJDJKFN combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HMJFACECNLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8877560", Offset = "0x8875F60", VA = "0x188877560")]
		internal JobHandle HKNPEBJEBAB()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x88775C0", Offset = "0x8875FC0", VA = "0x1888775C0")]
		internal void OKHOIGIFEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x88773F0", Offset = "0x8875DF0", VA = "0x1888773F0")]
		internal void BPAKDLDALLB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] EOHKLAPIBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NGALAELGKAE PABBMLDMHHB;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 DPFCDGGMFJL;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh IGPMIJHMMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int JILDAHLAEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA16630", Offset = "0xA15030", VA = "0x180A16630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x887C870", Offset = "0x887B270", VA = "0x18887C870")]
	public void KHMFFFHFLPG(List<KAOEODPJKHN> JPLGOKNPJCO, Matrix4x4[] ADKCDPFKJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x887C1E0", Offset = "0x887ABE0", VA = "0x18887C1E0")]
	public static List<IDJHAMENJON> JEBOFNEMEAN(List<IBMMPCOKGKD> HKBGKHAINJB, JFJFDHAJDJF GIFLHFGNGDL, Bounds LBIMIFOEEKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x887CA50", Offset = "0x887B450", VA = "0x18887CA50")]
	private JobHandle OOAPCLOLKDL(OBIKIJDJKFN NEEMDFONCHL, int MPCFCLNCMDJ, int HMFDBDGGHKA, JFJFDHAJDJF GIFLHFGNGDL, List<IGCAGNJHJOD> LCDJADJCENH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x887C070", Offset = "0x887AA70", VA = "0x18887C070")]
	private void DKFMILEEBIH(List<IGCAGNJHJOD> LCDJADJCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x887CF40", Offset = "0x887B940", VA = "0x18887CF40")]
	private IDJHAMENJON(List<IGCAGNJHJOD> LCDJADJCENH, int MPCFCLNCMDJ, int HMFDBDGGHKA, JFJFDHAJDJF GIFLHFGNGDL, Bounds LBIMIFOEEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x887C150", Offset = "0x887AB50", VA = "0x18887C150", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private MaterialPropertyBlock OCKKPAOFAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IDJHAMENJON DLOFNMELGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<KAOEODPJKHN> MLDILJLGELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture JDCNDNPEFDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer AIIJLLKPDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader HNAAEBBKCIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] LKOKEBIDIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int INGFJFPOHPE;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer IJKDPLLBENO
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int OLBIAEIDBFL
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8887220", Offset = "0x8885C20", VA = "0x188887220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x88865B0", Offset = "0x8884FB0", VA = "0x1888865B0")]
		public static List<SkinnedShapeRenderer> Create(GameObject ALPBGLGCPNB, List<IDJHAMENJON> OJOHGKGLJEH, List<KAOEODPJKHN> MLDILJLGELN, Material NJABANIHMHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x88868A0", Offset = "0x88852A0", VA = "0x1888868A0")]
		public void Init(IDJHAMENJON DLOFNMELGLP, List<KAOEODPJKHN> MLDILJLGELN, Material NJABANIHMHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8887180", Offset = "0x8885B80", VA = "0x188887180")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x88870E0", Offset = "0x8885AE0", VA = "0x1888870E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x88870A0", Offset = "0x8885AA0", VA = "0x1888870A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x88864F0", Offset = "0x8884EF0", VA = "0x1888864F0")]
		private void CLJAICOIFGN(ScriptableRenderContext GJIMIGJJJKI, Camera[] KBJFNOCPKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8886D30", Offset = "0x8885730", VA = "0x188886D30")]
		private void KHMFFFHFLPG(CommandBuffer FEALIBPFKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
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

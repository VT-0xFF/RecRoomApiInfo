using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class CWHGVYTHLWE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
	public CWHGVYTHLWE()
	{
	}
}
namespace RecRoom.Foundation.ComponentSystems
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class ULMJBZOQSNN : JXWQQCMEZCX
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x97A0F90", Offset = "0x97A0390", VA = "0x1897A0F90", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract ComponentSystemBase DXAUSQHCNQE();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x97A0ED0", Offset = "0x97A02D0", VA = "0x1897A0ED0")]
		protected JXWQQCMEZCX Group(params ComponentSystemBase[] systems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x97A0F40", Offset = "0x97A0340", VA = "0x1897A0F40")]
		protected JXWQQCMEZCX Group(string name, params ComponentSystemBase[] systems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x40636D0", Offset = "0x4062AD0", VA = "0x1840636D0")]
		protected JXWQQCMEZCX Group<T>(params ComponentSystemBase[] systems) where T : JXWQQCMEZCX, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4063830", Offset = "0x4062C30", VA = "0x184063830")]
		protected b ZHATEKQMIBA<b>() where b : ComponentSystemBase, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x40637D0", Offset = "0x4062BD0", VA = "0x1840637D0")]
		protected c LAPJRJZNBOF<c>() where c : ComponentSystemBase, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x97A0D00", Offset = "0x97A0100", VA = "0x1897A0D00")]
		[Preserve]
		protected ULMJBZOQSNN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TZIXKHBQVPV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface OOVQSJIJMRX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class JXWQQCMEZCX : CFZFCFULLJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x97A0D60", Offset = "0x97A0160", VA = "0x1897A0D60", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x97A0D00", Offset = "0x97A0100", VA = "0x1897A0D00")]
		[Preserve]
		public JXWQQCMEZCX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class CFZFCFULLJN : ComponentSystemGroup, OOVQSJIJMRX
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x97A0D00", Offset = "0x97A0100", VA = "0x1897A0D00")]
		[Preserve]
		protected CFZFCFULLJN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[SourceGenerate]
	[DebuggerTypeProxy(typeof(HWURJAPSGBL))]
	public abstract class AAXVZXDZDIV : SystemBase, OOVQSJIJMRX
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public struct System
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct Managed
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct Unmanaged
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct Group : IEnumerable<System>, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x97A0D10", Offset = "0x97A0110", VA = "0x1897A0D10", Slot = "4")]
			public IEnumerator<System> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x97A0D50", Offset = "0x97A0150", VA = "0x1897A0D50", Slot = "5")]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		internal ComponentSystemBase[] ZWKYPJYUJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal UnsafeList<SystemHandle> MCKXPYOFAVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal UnsafeList<Unity.Entities.UpdateIndex> VKFIONVCYOQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool WNWLALCZIRA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD995E0", Offset = "0xD989E0", VA = "0x180D995E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xDC5250", Offset = "0xDC4650", VA = "0x180DC5250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ComponentSystemGroup RSMFOCGSZZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF4020", VA = "0x180CF4C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x97A0B70", Offset = "0x979FF70", VA = "0x1897A0B70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x97A0A30", Offset = "0x979FE30", VA = "0x1897A0A30", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x97A0A60", Offset = "0x979FE60", VA = "0x1897A0A60", Slot = "9")]
		[Preserve]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x97A0AD0", Offset = "0x979FED0", VA = "0x1897A0AD0", Slot = "13")]
		[Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "6")]
		[Preserve]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "7")]
		[Preserve]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x97A0C70", Offset = "0x97A0070", VA = "0x1897A0C70")]
		private void VUEGJQMDJRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x97A0540", Offset = "0x979F940", VA = "0x1897A0540")]
		protected void DVWYYBMLPTQ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x97A06A0", Offset = "0x979FAA0", VA = "0x1897A06A0", Slot = "14")]
		protected virtual void DXAUSQHCNQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x97A0C20", Offset = "0x97A0020", VA = "0x1897A0C20", Slot = "15")]
		protected virtual void VSAQYTUYUST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x335FA30", Offset = "0x335EE30", VA = "0x18335FA30")]
		protected a JNUYMTVMPRU<a>(int a, int b, a c) where a : ComponentSystemBase
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x335F910", Offset = "0x335ED10", VA = "0x18335F910")]
		protected b IRYQQOZZYXC<b>(int a, int b) where b : ComponentSystemBase
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x335FC30", Offset = "0x335F030", VA = "0x18335FC30")]
		protected void WZEXSSOQDEJ<T>(int a, int b) where T : struct, ISystem
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		protected void HUUMXTZICWO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		protected void WIKPAQTJZRU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x335F720", Offset = "0x335EB20", VA = "0x18335F720")]
		public bool HUFFLHZRCWQ<c>(int a, c b) where c : ComponentSystemBase
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x97A06F0", Offset = "0x979FAF0", VA = "0x1897A06F0")]
		public bool FZBWTBNEKCN(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2E51A70", Offset = "0x2E50E70", VA = "0x182E51A70")]
		[Preserve]
		protected AAXVZXDZDIV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal sealed class HWURJAPSGBL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct FinalVersionData<T> : IDisposable where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private VersionData<T> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public VersionData<T> PLMDUCLOBCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400")]
			get
			{
				return default(VersionData<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x62AA650", Offset = "0x62A9A50", VA = "0x1862AA650")]
		public FinalVersionData(VersionData<T> version, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x62A88B0", Offset = "0x62A7CB0", VA = "0x1862A88B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct FinalVersionInfo<T> where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private VersionInfo<T> version;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62AB300", Offset = "0x62AA700", VA = "0x1862AB300")]
		public FinalVersionInfo(VersionInfo<T> version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x62AA880", Offset = "0x62A9C80", VA = "0x1862AA880")]
		public FinalVersionData<T> RDYCCXNEPAZ()
		{
			return default(FinalVersionData<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct IntermediateVersionData<T> : IDisposable where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private VersionData<T> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public VersionData<T> PLMDUCLOBCS
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400")]
			get
			{
				return default(VersionData<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62AA650", Offset = "0x62A9A50", VA = "0x1862AA650")]
		public IntermediateVersionData(VersionData<T> version, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x65B8A60", Offset = "0x65B7E60", VA = "0x1865B8A60")]
		public void PAEFCWMGLXB(VersionInfo<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x65B7950", Offset = "0x65B6D50", VA = "0x1865B7950", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct IntermediateVersionInfo<T> where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private VersionInfo<T> version;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x62AB300", Offset = "0x62AA700", VA = "0x1862AB300")]
		public IntermediateVersionInfo(VersionInfo<T> version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x65BB0E0", Offset = "0x65BA4E0", VA = "0x1865BB0E0")]
		public IntermediateVersionData<T> QPEJKGKIBAW()
		{
			return default(IntermediateVersionData<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	public abstract class TJTWKIEXQDT : SystemBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EntityCommandBufferSystem NWEYNQBTRFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private NativeList<EntityQuery> YGPVQFCHGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private bool KSQTNFGOFGR;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public EntityCommandBufferSystem ZUMNNSSOJDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected bool OMTUQXOFEHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x291BE50", Offset = "0x291B250", VA = "0x18291BE50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xCF4C10", Offset = "0xCF4010", VA = "0x180CF4C10")]
		public void MNYNUFPVKUV(EntityCommandBufferSystem a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x97A0D90", Offset = "0x97A0190", VA = "0x1897A0D90", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x97A0E70", Offset = "0x97A0270", VA = "0x1897A0E70", Slot = "13")]
		[Preserve]
		protected sealed override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x97A0E20", Offset = "0x97A0220", VA = "0x1897A0E20", Slot = "9")]
		[Preserve]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void AWASSIZYNLH();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D240", Offset = "0x3F1C640", VA = "0x183F1D240")]
		protected EntityQuery YFRXXKUCLNI<T>() where T : struct, IComponentData
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C670", Offset = "0x3F1BA70", VA = "0x183F1C670")]
		protected IntermediateVersionInfo<T> CIQXLPYKKZH<T>() where T : struct, IComponentData
		{
			return default(IntermediateVersionInfo<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3F1CE60", Offset = "0x3F1C260", VA = "0x183F1CE60")]
		protected FinalVersionInfo<T> MPDLFCFBFVE<T>() where T : struct, IComponentData
		{
			return default(FinalVersionInfo<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2E51A70", Offset = "0x2E50E70", VA = "0x182E51A70")]
		[Preserve]
		protected TJTWKIEXQDT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct VersionData<T> where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NativeList<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NativeList<T> data;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int JEDXTOZKJHI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8388410", Offset = "0x8387810", VA = "0x188388410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public (Entity entity, T value) this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x838A920", Offset = "0x8389D20", VA = "0x18838A920")]
			get
			{
				return default((Entity, T));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8386CA0", Offset = "0x83860A0", VA = "0x188386CA0")]
		public void Add(Entity entity, T value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct VersionInfo<T> where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Unity.Collections.ReadOnly]
		public EntityQueryInJob query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Unity.Collections.ReadOnly]
		public EntityTypeHandle entityTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Unity.Collections.ReadOnly]
		public ComponentTypeHandle<T> componentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[WriteOnly]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AllocatorManager.AllocatorHandle allocator;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x838C480", Offset = "0x838B880", VA = "0x18838C480")]
		public VersionData<T> RDYCCXNEPAZ()
		{
			return default(VersionData<T>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal class GUIFNYXQCIX
{
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

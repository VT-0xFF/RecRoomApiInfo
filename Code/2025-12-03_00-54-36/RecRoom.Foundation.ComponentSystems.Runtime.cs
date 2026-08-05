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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class OPFYJNMMZGZ
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
	[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
	public OPFYJNMMZGZ()
	{
	}
}
namespace RecRoom.Foundation.ComponentSystems
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class WFEIAZQXPEU : XWDQKFBQLHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81CF240", Offset = "0x81CDE40", VA = "0x1881CF240", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract ComponentSystemBase AYREDPEPCWL();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81CF180", Offset = "0x81CDD80", VA = "0x1881CF180")]
		protected XWDQKFBQLHO Group(params ComponentSystemBase[] systems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81CF1F0", Offset = "0x81CDDF0", VA = "0x1881CF1F0")]
		protected XWDQKFBQLHO Group(string name, params ComponentSystemBase[] systems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3BDD810", Offset = "0x3BDC410", VA = "0x183BDD810")]
		protected XWDQKFBQLHO Group<T>(params ComponentSystemBase[] systems) where T : XWDQKFBQLHO, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3BDD970", Offset = "0x3BDC570", VA = "0x183BDD970")]
		protected b JFNJRTUSIMV<b>() where b : ComponentSystemBase, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3BDD910", Offset = "0x3BDC510", VA = "0x183BDD910")]
		protected c JCMFUFYFKBS<c>() where c : ComponentSystemBase, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81CE820", Offset = "0x81CD420", VA = "0x1881CE820")]
		[Preserve]
		protected WFEIAZQXPEU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HALZLQGIIWI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface URWOBMBJYHG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class XWDQKFBQLHO : BUFQOKJCPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81CF2A0", Offset = "0x81CDEA0", VA = "0x1881CF2A0", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81CE820", Offset = "0x81CD420", VA = "0x1881CE820")]
		[Preserve]
		public XWDQKFBQLHO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class BUFQOKJCPPA : ComponentSystemGroup, URWOBMBJYHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81CE820", Offset = "0x81CD420", VA = "0x1881CE820")]
		[Preserve]
		protected BUFQOKJCPPA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[SourceGenerate]
	[DebuggerTypeProxy(typeof(KXTQLFZAGJY))]
	public abstract class GSWVQJMBBTO : SystemBase, URWOBMBJYHG
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
			[Cpp2IlInjected.Address(RVA = "0x81CEFF0", Offset = "0x81CDBF0", VA = "0x1881CEFF0", Slot = "4")]
			public IEnumerator<System> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x81CF030", Offset = "0x81CDC30", VA = "0x1881CF030", Slot = "5")]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		internal ComponentSystemBase[] TDLYFDUILPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal UnsafeList<SystemHandle> EPBWKEPPZYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal UnsafeList<Unity.Entities.UpdateIndex> THLVXDXGWFP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NFMVRBWGILD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB0E630", Offset = "0xB0D230", VA = "0x180B0E630")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB0E680", Offset = "0xB0D280", VA = "0x180B0E680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ComponentSystemGroup HOTTRVHGDFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5A0", Offset = "0xA991A0", VA = "0x180A9A5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x81CEC00", Offset = "0x81CD800", VA = "0x1881CEC00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81CE880", Offset = "0x81CD480", VA = "0x1881CE880", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81CE8B0", Offset = "0x81CD4B0", VA = "0x1881CE8B0", Slot = "9")]
		[Preserve]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x81CE920", Offset = "0x81CD520", VA = "0x1881CE920", Slot = "13")]
		[Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "6")]
		[Preserve]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "7")]
		[Preserve]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81CE9C0", Offset = "0x81CD5C0", VA = "0x1881CE9C0")]
		private void PMFVQOADUIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81CEA50", Offset = "0x81CD650", VA = "0x1881CEA50")]
		protected void QKBOXNSGCSV(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81CE830", Offset = "0x81CD430", VA = "0x1881CE830", Slot = "14")]
		protected virtual void AYREDPEPCWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81CEBB0", Offset = "0x81CD7B0", VA = "0x1881CEBB0", Slot = "15")]
		protected virtual void TSRFYSWMSFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x36A4CE0", Offset = "0x36A38E0", VA = "0x1836A4CE0")]
		protected a HYLHZHCBPYX<a>(int a, int b, a c) where a : ComponentSystemBase
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x36A51D0", Offset = "0x36A3DD0", VA = "0x1836A51D0")]
		protected b QMBMBQLDUHX<b>(int a, int b) where b : ComponentSystemBase
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x36A4EF0", Offset = "0x36A3AF0", VA = "0x1836A4EF0")]
		protected void NFRWQUFGFPS<T>(int a, int b) where T : struct, ISystem
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		protected void VSKSTWZJPRN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		protected void QWZIOIORUTB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x36A4FE0", Offset = "0x36A3BE0", VA = "0x1836A4FE0")]
		public bool PVVSXLWQEDV<c>(int a, c b) where c : ComponentSystemBase
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81CECB0", Offset = "0x81CD8B0", VA = "0x1881CECB0")]
		public bool WCSWZDIRTWW(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B805A0", Offset = "0x2B7F1A0", VA = "0x182B805A0")]
		[Preserve]
		protected GSWVQJMBBTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal sealed class KXTQLFZAGJY
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
		public VersionData<T> TCEUBRWQOOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xFC1670", Offset = "0xFC0270", VA = "0x180FC1670")]
			get
			{
				return default(VersionData<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4CB60E0", Offset = "0x4CB4CE0", VA = "0x184CB60E0")]
		public FinalVersionData(VersionData<T> version, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4CB4340", Offset = "0x4CB2F40", VA = "0x184CB4340", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CB6D90", Offset = "0x4CB5990", VA = "0x184CB6D90")]
		public FinalVersionInfo(VersionInfo<T> version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4CB6B80", Offset = "0x4CB5780", VA = "0x184CB6B80")]
		public FinalVersionData<T> TNKFREWCKCY()
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
		public VersionData<T> TCEUBRWQOOV
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xFC1670", Offset = "0xFC0270", VA = "0x180FC1670")]
			get
			{
				return default(VersionData<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4CB60E0", Offset = "0x4CB4CE0", VA = "0x184CB60E0")]
		public IntermediateVersionData(VersionData<T> version, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5005E60", Offset = "0x5004A60", VA = "0x185005E60")]
		public void IMJDZZQJYDE(VersionInfo<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5004060", Offset = "0x5002C60", VA = "0x185004060", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CB6D90", Offset = "0x4CB5990", VA = "0x184CB6D90")]
		public IntermediateVersionInfo(VersionInfo<T> version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5007F80", Offset = "0x5006B80", VA = "0x185007F80")]
		public IntermediateVersionData<T> OHWAAFQBGWL()
		{
			return default(IntermediateVersionData<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	public abstract class TPZTJXNAZII : SystemBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EntityCommandBufferSystem NWUBZIPXICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private NativeList<EntityQuery> OFENYZVWLOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private bool GECUOUJILNC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public EntityCommandBufferSystem BTLHODXHMWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected bool XIYOMFQFIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2583CF0", Offset = "0x25828F0", VA = "0x182583CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA98600", Offset = "0xA97200", VA = "0x180A98600")]
		public void PQJKHESKDYC(EntityCommandBufferSystem a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81CF040", Offset = "0x81CDC40", VA = "0x1881CF040", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x81CF120", Offset = "0x81CDD20", VA = "0x1881CF120", Slot = "13")]
		[Preserve]
		protected sealed override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81CF0D0", Offset = "0x81CDCD0", VA = "0x1881CF0D0", Slot = "9")]
		[Preserve]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void GVWZGIWJEFQ();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3A83730", Offset = "0x3A82330", VA = "0x183A83730")]
		protected EntityQuery UATCNAMKHEH<T>() where T : struct, IComponentData
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3A839B0", Offset = "0x3A825B0", VA = "0x183A839B0")]
		protected IntermediateVersionInfo<T> ZIXBGYHPIEM<T>() where T : struct, IComponentData
		{
			return default(IntermediateVersionInfo<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3A83210", Offset = "0x3A81E10", VA = "0x183A83210")]
		protected FinalVersionInfo<T> NDFCVKWROJT<T>() where T : struct, IComponentData
		{
			return default(FinalVersionInfo<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B805A0", Offset = "0x2B7F1A0", VA = "0x182B805A0")]
		[Preserve]
		protected TPZTJXNAZII()
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
		public int EYPZHMQDKRN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6492ED0", Offset = "0x6491AD0", VA = "0x186492ED0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public (Entity entity, T value) this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6495CF0", Offset = "0x64948F0", VA = "0x186495CF0")]
			get
			{
				return default((Entity, T));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6492070", Offset = "0x6490C70", VA = "0x186492070")]
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
		[Cpp2IlInjected.Address(RVA = "0x6498400", Offset = "0x6497000", VA = "0x186498400")]
		public VersionData<T> TNKFREWCKCY()
		{
			return default(VersionData<T>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal class TZQXNETAEXV
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

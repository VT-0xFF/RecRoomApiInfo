using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.ComponentSystems;
using RecRoom.NoEngine.JetBrains.Annotations;
using RecRoom.ObjectModel.Entities;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x99FBFA0", Offset = "0x99FADA0", VA = "0x1899FBFA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class IXBFVIJSSFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
	public IXBFVIJSSFJ()
	{
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99FBDE0", Offset = "0x99FABE0", VA = "0x1899FBDE0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface MFRPOPSGDIC : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TokenHandle TokenHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface WJLQMEPYKKG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool GJNSMKDNLZH(Entity a, object b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PMJCXILVFGW(Entity a, object b, [Out] bool c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ZGBJFNBZHQB(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class OTJFJWHNZBD<a, b> : NWEPDRXKTHL<b>, IDisposable where a : struct, MFRPOPSGDIC
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class OGPLXWFMHVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private List<(object token, b value)> FEFPYLNNFVX;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int PUCTPTIOQGU
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x282F4B0", Offset = "0x282E2B0", VA = "0x18282F4B0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7295740", Offset = "0x7294540", VA = "0x187295740")]
			public bool USFABPBMLOS([Out] b a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7295280", Offset = "0x7294080", VA = "0x187295280")]
			public void Add(object token, b value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7295410", Offset = "0x7294210", VA = "0x187295410")]
			public bool Remove(object token)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x72956A0", Offset = "0x72944A0", VA = "0x1872956A0")]
			public int UHIGQEZJBOK(object a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7295980", Offset = "0x7294780", VA = "0x187295980")]
			public OGPLXWFMHVY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Stack<OGPLXWFMHVY> ZMLOPUMKAUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ManagedObjectPool<TokenHandle, OGPLXWFMHVY> PICUONNGKUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private EntityManager OYSMTDKGMGB;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72AC010", Offset = "0x72AAE10", VA = "0x1872AC010")]
		public OTJFJWHNZBD(EntityManager a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72AB270", Offset = "0x72AA070", VA = "0x1872AB270", Slot = "4")]
		public void GJNSMKDNLZH(Entity a, object b, b c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x72AB8E0", Offset = "0x72AA6E0", VA = "0x1872AB8E0", Slot = "5")]
		public bool PMJCXILVFGW(Entity a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x72ABF10", Offset = "0x72AAD10", VA = "0x1872ABF10", Slot = "6")]
		public bool USFABPBMLOS(Entity a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x72AB0C0", Offset = "0x72A9EC0", VA = "0x1872AB0C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72AB630", Offset = "0x72AA430", VA = "0x1872AB630")]
		private void KYAGFSTSXLY(OGPLXWFMHVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72AAE70", Offset = "0x72A9C70", VA = "0x1872AAE70")]
		private bool AUNPFFPEXDO(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72ABD30", Offset = "0x72AAB30", VA = "0x1872ABD30")]
		private void TGKEZDIBBZG(Entity a, TokenHandle b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72AADF0", Offset = "0x72A9BF0", VA = "0x1872AADF0")]
		private bool AFYNZKRWYRQ(TokenHandle a, [Out] OGPLXWFMHVY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72AB1E0", Offset = "0x72A9FE0", VA = "0x1872AB1E0")]
		private OGPLXWFMHVY EACIVXIBFKG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface NWEPDRXKTHL<a> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GJNSMKDNLZH(Entity a, object b, a c);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PMJCXILVFGW(Entity a, object b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool USFABPBMLOS(Entity a, [Out] a b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct TokenHandle : FNJCRVJCPDM, IEquatable<TokenHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly TokenHandle Invalid;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[CreateProperty]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xF430D0", Offset = "0xF41ED0", VA = "0x180F430D0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[CreateProperty]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x30B62E0", Offset = "0x30B50E0", VA = "0x1830B62E0", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x30B62F0", Offset = "0x30B50F0", VA = "0x1830B62F0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99FC520", Offset = "0x99FB320", VA = "0x1899FC520", Slot = "8")]
		public bool Equals(TokenHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99FC570", Offset = "0x99FB370", VA = "0x1899FC570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class RSDNBUXGYXG<a> : WJLQMEPYKKG, IDisposable where a : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Dictionary<Entity, TokenHandle> AOEHKCVIJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly Stack<HashSet<object>> ZMLOPUMKAUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private ManagedObjectPool<TokenHandle, HashSet<object>> PICUONNGKUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EntityManager OYSMTDKGMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private EntityCommandBufferSystem YSZXCFNSDIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool DZPJVTCESGG;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x764DF20", Offset = "0x764CD20", VA = "0x18764DF20")]
		public RSDNBUXGYXG(EntityManager a, EntityCommandBufferSystem b, Log c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x764B2E0", Offset = "0x764A0E0", VA = "0x18764B2E0", Slot = "4")]
		public bool GJNSMKDNLZH(Entity a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x764C760", Offset = "0x764B560", VA = "0x18764C760", Slot = "5")]
		public bool PMJCXILVFGW(Entity a, object b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x764DDC0", Offset = "0x764CBC0", VA = "0x18764DDC0", Slot = "6")]
		public bool ZGBJFNBZHQB(Entity a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x764DBB0", Offset = "0x764C9B0", VA = "0x18764DBB0", Slot = "8")]
		public bool ZGBJFNBZHQB(TokenHandle a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x764A860", Offset = "0x7649660", VA = "0x18764A860", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x764BD10", Offset = "0x764AB10", VA = "0x18764BD10")]
		private void KYAGFSTSXLY(HashSet<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x764A680", Offset = "0x7649480", VA = "0x18764A680")]
		private bool AUNPFFPEXDO(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x764D790", Offset = "0x764C590", VA = "0x18764D790")]
		private bool ZEHBNQDHJEM(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x764CD20", Offset = "0x764BB20", VA = "0x18764CD20")]
		private void TKNTNKYPGJZ(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x764ADA0", Offset = "0x7649BA0", VA = "0x18764ADA0")]
		private void ESRVRQTMPNE(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x764D1A0", Offset = "0x764BFA0", VA = "0x18764D1A0")]
		private void XEBGVBNCZIT(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x764CA60", Offset = "0x764B860", VA = "0x18764CA60")]
		private void TGKEZDIBBZG(Entity a, TokenHandle b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x764D080", Offset = "0x764BE80", VA = "0x18764D080")]
		private bool WHZMRQDXIJH(TokenHandle a, [Out] HashSet<object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x764A920", Offset = "0x7649720", VA = "0x18764A920")]
		private HashSet<object> EACIVXIBFKG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class LTHBHWHTXLJ
	{
	}
}
namespace RecRoom.ObjectModel.Mappers
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct Float3GetX : ERGRAZDVCJY<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x56A2FB0", Offset = "0x56A1DB0", VA = "0x1856A2FB0")]
		public float UCQNZBAJEOR([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x56A2FB0", Offset = "0x56A1DB0", VA = "0x1856A2FB0", Slot = "4")]
		private float TKZGFTQOBWP([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct Float3GetY : ERGRAZDVCJY<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99FBE00", Offset = "0x99FAC00", VA = "0x1899FBE00")]
		public float UCQNZBAJEOR([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99FBE00", Offset = "0x99FAC00", VA = "0x1899FBE00", Slot = "4")]
		private float TKZGFTQOBWP([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct Float3GetZ : ERGRAZDVCJY<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99FBE10", Offset = "0x99FAC10", VA = "0x1899FBE10")]
		public float UCQNZBAJEOR([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99FBE10", Offset = "0x99FAC10", VA = "0x1899FBE10", Slot = "4")]
		private float TKZGFTQOBWP([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct Int3GetX : ERGRAZDVCJY<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1024BB0", Offset = "0x10239B0", VA = "0x181024BB0")]
		public int UCQNZBAJEOR([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1024BB0", Offset = "0x10239B0", VA = "0x181024BB0", Slot = "4")]
		private int IBITRWNSCJC([In] int3 value)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct Int3GetY : ERGRAZDVCJY<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x14073C0", Offset = "0x14061C0", VA = "0x1814073C0")]
		public int UCQNZBAJEOR([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x14073C0", Offset = "0x14061C0", VA = "0x1814073C0", Slot = "4")]
		private int IBITRWNSCJC([In] int3 value)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Int3GetZ : ERGRAZDVCJY<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xFD4740", Offset = "0xFD3540", VA = "0x180FD4740")]
		public int UCQNZBAJEOR([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xFD4740", Offset = "0xFD3540", VA = "0x180FD4740", Slot = "4")]
		private int IBITRWNSCJC([In] int3 value)
		{
			return default(int);
		}
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class RegisterComponentSystem : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2E4DD50", Offset = "0x2E4CB50", VA = "0x182E4DD50")]
		public RegisterComponentSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public abstract class VUMUZMXBNAB : SystemBase, KPXIJZMTPQO
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x99FC900", Offset = "0x99FB700", VA = "0x1899FC900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x40C2F20", Offset = "0x40C1D20", VA = "0x1840C2F20")]
		public void AVKKZINIPUZ<a>() where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x40C3040", Offset = "0x40C1E40", VA = "0x1840C3040")]
		public void HWLSUMDKSPO<b>() where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x40C30D0", Offset = "0x40C1ED0", VA = "0x1840C30D0")]
		public JobHandle JPXTRTLAEHU<c>() where c : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x99FC840", Offset = "0x99FB640", VA = "0x1899FC840")]
		public JobHandle JPXTRTLAEHU(ReadOnlySpan<TypeIndex> a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x40C3730", Offset = "0x40C2530", VA = "0x1840C3730")]
		public JobHandle RRBFVYCSTHV<d>() where d : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x99FC960", Offset = "0x99FB760", VA = "0x1899FC960")]
		public JobHandle RRBFVYCSTHV(ReadOnlySpan<TypeIndex> a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x40C3B10", Offset = "0x40C2910", VA = "0x1840C3B10")]
		public void WKWEBLMOEXX<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x40C3A50", Offset = "0x40C2850", VA = "0x1840C3A50")]
		public JobHandle WKWEBLMOEXX<f>(JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x99FCB40", Offset = "0x99FB940", VA = "0x1899FCB40")]
		public JobHandle WKWEBLMOEXX(ReadOnlySpan<TypeIndex> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x40C32B0", Offset = "0x40C20B0", VA = "0x1840C32B0")]
		public void MQVPTDXWULY<g>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x40C31F0", Offset = "0x40C1FF0", VA = "0x1840C31F0")]
		public JobHandle MQVPTDXWULY<h>(JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99FC890", Offset = "0x99FB690", VA = "0x1899FC890")]
		public JobHandle MQVPTDXWULY(Span<TypeIndex> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x40C39C0", Offset = "0x40C27C0", VA = "0x1840C39C0")]
		public ComponentDataFromEntity UBLVEUWTDPI<i>(bool a = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99FC9B0", Offset = "0x99FB7B0", VA = "0x1899FC9B0")]
		public ComponentDataFromEntity UBLVEUWTDPI(int a, bool b = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x40C2E40", Offset = "0x40C1C40", VA = "0x1840C2E40")]
		public SharedComponentIndexFromEntity<j> ADVQMZYWZUY<j>() where j : ISharedComponentData
		{
			return default(SharedComponentIndexFromEntity<j>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x99FCAE0", Offset = "0x99FB8E0", VA = "0x1899FCAE0")]
		[GenerateTestsForBurstCompatibility]
		public ComponentTypeHandle VYEOTEABQYI(ComponentType a)
		{
			return default(ComponentTypeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99FC930", Offset = "0x99FB730", VA = "0x1899FC930")]
		public EntityExistenceLookupByEntity OPVAEJQHDQI()
		{
			return default(EntityExistenceLookupByEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99FCAD0", Offset = "0x99FB8D0", VA = "0x1899FCAD0", Slot = "10")]
		public sealed override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x40C3870", Offset = "0x40C2670", VA = "0x1840C3870")]
		public bool RYUOODFKPUS<k>()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "7")]
		[Preserve]
		protected sealed override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2E4DD50", Offset = "0x2E4CB50", VA = "0x182E4DD50")]
		[Preserve]
		protected VUMUZMXBNAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class ADZRPKYGKXA : VUMUZMXBNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x99FBB20", Offset = "0x99FA920", VA = "0x1899FBB20", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2E4DD50", Offset = "0x2E4CB50", VA = "0x182E4DD50")]
		[Preserve]
		protected ADZRPKYGKXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class OQWUKPSBXEX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class TAESPWZHLYI : EntityCommandBufferSystem, KPXIJZMTPQO
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Log ALDXGIVBEKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD5F4B0", Offset = "0xD5E2B0", VA = "0x180D5F4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x99FC4F0", Offset = "0x99FB2F0", VA = "0x1899FC4F0")]
		public TAESPWZHLYI(Log a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface ERGRAZDVCJY<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b UCQNZBAJEOR([In] a value);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface ZTTICTHCPHG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool GXFNJLDHJXA(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[BurstCompile]
	internal struct AddComponentECB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ComponentTypeSet componentTypes;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x99FBB50", Offset = "0x99FA950", VA = "0x1899FBB50", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[BurstCompile]
	internal struct DestroyEntityECB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x99FBD40", Offset = "0x99FAB40", VA = "0x1899FBD40", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[BurstCompile]
	internal struct RemoveComponentECB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public ComponentType componentType;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x99FC470", Offset = "0x99FB270", VA = "0x1899FC470", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[BurstCompile]
	internal struct SetComponentECB<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x78E1340", Offset = "0x78E0140", VA = "0x1878E1340", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal struct SetSharedComponentArrayECB<T> : IJob where T : struct, ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x78E25E0", Offset = "0x78E13E0", VA = "0x1878E25E0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal struct SetSharedComponentECB<T> : IJob where T : struct, ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Unity.Collections.ReadOnly]
		public T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x78E2790", Offset = "0x78E1590", VA = "0x1878E2790", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[BurstCompile]
	internal struct MapArrayJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, ERGRAZDVCJY<TFrom, TTo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Unity.Collections.ReadOnly]
		public NativeArray<TFrom> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[WriteOnly]
		public NativeArray<TTo> dstDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public TMap action;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F33A90", Offset = "0x6F32890", VA = "0x186F33A90", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[BurstCompile]
	internal struct MapEntityToComponentDataArrayJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Unity.Collections.ReadOnly]
		public ComponentDataFromEntity srcDataFromEntity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[WriteOnly]
		public NativeArray<byte> dstDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int typeSize;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x99FBEA0", Offset = "0x99FACA0", VA = "0x1899FBEA0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[BurstCompile]
	internal struct MapEntityToComponentDataListJob<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Unity.Collections.ReadOnly]
		public ComponentLookup<T> dstDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[WriteOnly]
		public NativeList<T> dstDataList;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6F33E60", Offset = "0x6F32C60", VA = "0x186F33E60", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[BurstCompile]
	internal struct MapListJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, ERGRAZDVCJY<TFrom, TTo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Unity.Collections.ReadOnly]
		public NativeArray<TFrom> srcDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[WriteOnly]
		public NativeList<TTo> dstDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public TMap action;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6F41270", Offset = "0x6F40070", VA = "0x186F41270", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[BurstCompile]
	internal struct ReduceAllHaveComponentJob<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Unity.Collections.ReadOnly]
		public ComponentLookup<T> componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NativeArray<bool> dstResult;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x78359B0", Offset = "0x78347B0", VA = "0x1878359B0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct ReduceAnyHasComponentJob<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Unity.Collections.ReadOnly]
		public ComponentLookup<T> componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeArray<bool> dstResult;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7835B30", Offset = "0x7834930", VA = "0x187835B30", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal struct ReduceDistinctJob<T> : IJob where T : struct, IEquatable<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeList<T> dstDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeParallelHashSet<T> set;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7835E20", Offset = "0x7834C20", VA = "0x187835E20", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[BurstCompile]
	internal struct ReduceDistinctSelectJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : ERGRAZDVCJY<TFrom, TTo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Unity.Collections.ReadOnly]
		public NativeArray<TFrom> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeList<TFrom> dstDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeParallelHashSet<TTo> set;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public TMap action;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7835EE0", Offset = "0x7834CE0", VA = "0x187835EE0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	internal struct ReduceEntitiesPredicateJob<T, TPredicate> : IJob where T : struct where TPredicate : struct, ZTTICTHCPHG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntityArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeList<Entity> dstEntityList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TPredicate action;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x78363A0", Offset = "0x78351A0", VA = "0x1878363A0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[BurstCompile]
	internal struct ReducePredicateJob<T, TPredicate> : IJob where T : struct where TPredicate : struct, ZTTICTHCPHG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeList<T> dstDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TPredicate action;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7836C80", Offset = "0x7835A80", VA = "0x187836C80", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	internal struct ReduceWithComponentJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Unity.Collections.ReadOnly]
		public ComponentDataFromEntity componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NativeList<Entity> dstEntities;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x99FC340", Offset = "0x99FB140", VA = "0x1899FC340", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[BurstCompile]
	internal struct ReduceWithoutComponentJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Unity.Collections.ReadOnly]
		public ComponentDataFromEntity componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeList<Entity> dstEntities;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x99FC3D0", Offset = "0x99FB1D0", VA = "0x1899FC3D0", Slot = "4")]
		[IgnoreWarning(1371)]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class HOUTAGGOFIL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class NZXXORLTCGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3D4C190", Offset = "0x3D4AF90", VA = "0x183D4C190")]
		public static bool HYYSHERDWDE<T>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JERGEIEJTNW
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class ITOQTWBEUPV<a> where a : struct
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ITOQTWBEUPV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class ZAGAZIDTYHU<a> where a : struct
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ZAGAZIDTYHU()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly List<Func<JobHandle, JobHandle>> ZJHFIAVAWAV;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x99FBE20", Offset = "0x99FAC20", VA = "0x1899FBE20")]
		public JERGEIEJTNW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class IMNINOZHKLI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class JTLSFPSLBAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public struct Array<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x2000038")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000052")]
				internal Array<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			internal NativeArray<TFrom> src;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct List<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200003A")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000055")]
				internal List<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal NativeList<TFrom> src;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ArrayAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200003C")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				internal ArrayAsync<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal NativeArrayAsync<TFrom> src;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public struct ListAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200003E")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				internal ListAsync<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal NativeListAsync<TFrom> src;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class MTCTSQDGEZT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class NRYLHXLBPWD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3D48140", Offset = "0x3D46F40", VA = "0x183D48140")]
		public static NativeList<T> UBSWWLTPTRT<T>(this NativeArray<T> a, Allocator b = Allocator.TempJob) where T : struct, IEquatable<T>
		{
			return default(NativeList<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class EQTNOCZJQJL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class ZLIOQEOZSMV
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4120540", Offset = "0x411F340", VA = "0x184120540")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x411FBF0", Offset = "0x411E9F0", VA = "0x18411FBF0")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArrayAsync<Entity> entities, NativeArrayAsync<T> data, [Optional] JobHandle dependsOn) where T : struct, IComponentData
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x411FE00", Offset = "0x411EC00", VA = "0x18411FE00")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x99FCBB0", Offset = "0x99FB9B0", VA = "0x1899FCBB0")]
		[MustUseReturnValue]
		public static JobHandle AddComponent(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, ComponentTypeSet componentTypes, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99FCD10", Offset = "0x99FBB10", VA = "0x1899FCD10")]
		[MustUseReturnValue]
		public static JobHandle AddComponent(this EntityCommandBufferSystem ecbs, EntityCommandBuffer ecb, NativeArray<Entity> entities, ComponentTypeSet componentTypes, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class YZLTXUFGRVK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class VIQMHTEVXPI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x99FC5C0", Offset = "0x99FB3C0", VA = "0x1899FC5C0")]
		[MustUseReturnValue]
		public static JobHandle DKGBTQWYRNA(this EntityCommandBufferSystem a, NativeList<Entity> b, [Optional] JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99FC740", Offset = "0x99FB540", VA = "0x1899FC740")]
		[MustUseReturnValue]
		public static JobHandle DKGBTQWYRNA(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class CPALIJLDCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x37E7F20", Offset = "0x37E6D20", VA = "0x1837E7F20")]
		public static void AEGYCFUEIBG<a>(this EntityCommandBufferSystem a, EntityQuery b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x37E8160", Offset = "0x37E6F60", VA = "0x1837E8160")]
		[MustUseReturnValue]
		public static JobHandle BSNNBQKQCNK<e>(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b, [Optional] JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99FBBD0", Offset = "0x99FA9D0", VA = "0x1899FBBD0")]
		[MustUseReturnValue]
		public static JobHandle BSNNBQKQCNK(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b, ComponentType c, [Optional] JobHandle d)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class TPMVUELUXWG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3F586E0", Offset = "0x3F574E0", VA = "0x183F586E0")]
		[MustUseReturnValue]
		public static JobHandle AFRXDAYFBBE<T>(this EntityCommandBufferSystem a, NativeArray<Entity> b, NativeArray<T> c, JobHandle d) where T : struct, IComponentData
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class JQDAENFBKVN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class JLLYNYBNMQE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class QVDGYNCQNJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C6D0", Offset = "0x3E2B4D0", VA = "0x183E2C6D0")]
		public static NativeArray<a> LBYTRXIGLZZ<a>(this NativeList<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where a : struct, IComponentData
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C870", Offset = "0x3E2B670", VA = "0x183E2C870")]
		public static NativeArray<b> LBYTRXIGLZZ<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where b : struct, IComponentData
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99FC180", Offset = "0x99FAF80", VA = "0x1899FC180")]
		public static NativeArray<Entity> AJEMNVZIMOI(this NativeArray<Entity> a, EntityManager b, ComponentType c, Allocator d = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3E2D210", Offset = "0x3E2C010", VA = "0x183E2D210")]
		public static NativeArray<T> QEWQDGNXAKM<T>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class VKNWSYPBIEL
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct Array<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200004C")]
			public struct SKey<TTo> where TTo : struct
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public Array<TFrom> src;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public NativeArray<TFrom> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct ArrayAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200004E")]
			public struct SKey<TTo> where TTo : struct
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000061")]
				public ArrayAsync<TFrom> src;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public NativeArrayAsync<TFrom> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct ListAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			public struct SKey<TTo> where TTo : struct
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public ListAsync<TFrom> src;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public NativeListAsync<TFrom> srcDataArray;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class IJEQCIIQXPN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class XITYPVBZGFB
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct RemapEntitiesAction : ERGRAZDVCJY<Entity, Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[Unity.Collections.ReadOnly]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x99FC460", Offset = "0x99FB260", VA = "0x1899FC460")]
			[GenerateTestsForBurstCompatibility]
			public Entity UCQNZBAJEOR([In] Entity value)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x99FC460", Offset = "0x99FB260", VA = "0x1899FC460", Slot = "4")]
			private Entity PMQOZOJPPRI([In] Entity value)
			{
				return default(Entity);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class USABPJPPSEY
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private struct Comparer<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5281C90", Offset = "0x5280A90", VA = "0x185281C90", Slot = "4")]
			public int Compare((TKey, TValue) x, (TKey, TValue) y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x408EAC0", Offset = "0x408D8C0", VA = "0x18408EAC0")]
		public static void Sort<TKey, TValue>(NativeList<TKey> keys, NativeList<TValue> values) where TKey : struct, IComparable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x408E8E0", Offset = "0x408D6E0", VA = "0x18408E8E0")]
		public static void Sort<TKey, TValue>(NativeArray<TKey> keys, NativeArray<TValue> values) where TKey : struct, IComparable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x40901B0", Offset = "0x408EFB0", VA = "0x1840901B0")]
		public static void Sort<TKey, TValue, U>(NativeArray<TKey> keys, NativeArray<TValue> values, U comparer) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class DFRVIQXSRHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct Array<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public NativeArray<Entity> srcEntityArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public NativeArray<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct List<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public NativeList<Entity> srcEntityArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public NativeArray<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct ArrayAsync<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public NativeArrayAsync<Entity> srcEntityArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public NativeArrayAsync<T> srcDataArray;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class LTNMRPYCWUE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class EXVRAJTSVMS
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public struct Array<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public NativeArray<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct List<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public NativeList<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct ArrayAsync<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public NativeArrayAsync<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct ListAsync<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public NativeListAsync<T> srcDataArray;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class LCIOMOBCWHO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class AGZJAXZOKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3360D30", Offset = "0x335FB30", VA = "0x183360D30")]
		public static NativeList<Entity> DNIVYWAYAGM<a>(this NativeList<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3360A10", Offset = "0x335F810", VA = "0x183360A10")]
		public static NativeList<Entity> DNIVYWAYAGM<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public static class USZICZPOBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x40903D0", Offset = "0x408F1D0", VA = "0x1840903D0")]
		public static NativeList<Entity> YFNLWSUGRUG<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class VNUDDADTQID
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public readonly struct EnumerateHelper<TSrc> where TSrc : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private readonly NativeArray<TSrc> array;
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public readonly struct SelectTypeEnumerateHelper<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private readonly NativeArray<TSrc> array;
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public readonly struct SelectedTypeEnumerateHelper<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, ERGRAZDVCJY<TSrc, TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private readonly NativeArray<TSrc> array;
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public struct SelectedTypeEnumerator<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, ERGRAZDVCJY<TSrc, TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private readonly NativeArray<TSrc> array;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TSelector selector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int index;
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		public struct GroupedSelectedTypeEnumerator<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, ERGRAZDVCJY<TSrc, TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private SelectedTypeEnumerator<TSrc, TValue, TSelector> enumerator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private TValue startValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private int startIndex;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public static class BDUDTOWUACE
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public struct GroupedEnumerator<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly NativeArray<T> array;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int startIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int currIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private T startValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private T currValue;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public RecRoom.Foundation.Collections.Range QYYBBOBNLRF
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x64373B0", Offset = "0x64361B0", VA = "0x1864373B0")]
				get
				{
					return default(RecRoom.Foundation.Collections.Range);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public T HMWQVKRBZHF
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public (T, RecRoom.Foundation.Collections.Range) NAVKGUMYYKS
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6437F90", Offset = "0x6436D90", VA = "0x186437F90")]
				get
				{
					return default((T, RecRoom.Foundation.Collections.Range));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6438720", Offset = "0x6437520", VA = "0x186438720")]
			public GroupedEnumerator(NativeArray<T> array)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x52EF500", Offset = "0x52EE300", VA = "0x1852EF500")]
			public GroupedEnumerator<T> GetEnumerator()
			{
				return default(GroupedEnumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6437780", Offset = "0x6436580", VA = "0x186437780")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x37CEA80", Offset = "0x37CD880", VA = "0x1837CEA80")]
			public GroupedWithComparerEnumerator<T, a> JTDVZLJAEXC<a>([Optional] a a) where a : struct, IEqualityComparer<T>
			{
				return default(GroupedWithComparerEnumerator<T, a>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public struct GroupedWithComparerEnumerator<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private readonly NativeArray<T> array;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int startIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private int currIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private T startValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private T currValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TComparer comparer;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public RecRoom.Foundation.Collections.Range QYYBBOBNLRF
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x64373B0", Offset = "0x64361B0", VA = "0x1864373B0")]
				get
				{
					return default(RecRoom.Foundation.Collections.Range);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public T HMWQVKRBZHF
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public (T value, RecRoom.Foundation.Collections.Range range) NAVKGUMYYKS
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x6438FE0", Offset = "0x6437DE0", VA = "0x186438FE0")]
				get
				{
					return default((T, RecRoom.Foundation.Collections.Range));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6439730", Offset = "0x6438530", VA = "0x186439730")]
			public GroupedWithComparerEnumerator(NativeArray<T> array, TComparer comparer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x53035A0", Offset = "0x53023A0", VA = "0x1853035A0")]
			public GroupedWithComparerEnumerator<T, TComparer> GetEnumerator()
			{
				return default(GroupedWithComparerEnumerator<T, TComparer>);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6438E90", Offset = "0x6437C90", VA = "0x186438E90")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3718360", Offset = "0x3717160", VA = "0x183718360")]
		public static GroupedEnumerator<T> Group<T>(this NativeArray<T> array) where T : struct
		{
			return default(GroupedEnumerator<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct ProtobufMessageListDeserializer<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class HINBDYGDJYC : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private (int index, Protobuf element) OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public ProtobufMessageListDeserializer<Protobuf> XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private int GQKQQFHGMTL;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private (int, Protobuf) UIXESFAZUWZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x64719E0", Offset = "0x64707E0", VA = "0x1864719E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default((int, Protobuf));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x6471A90", Offset = "0x6470890", VA = "0x186471A90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x5106460", Offset = "0x5105260", VA = "0x185106460")]
			[DebuggerHidden]
			public HINBDYGDJYC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6471B40", Offset = "0x6470940", VA = "0x186471B40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly Action<Protobuf> resetToDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly CodedInputStream inputStream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Protobuf element;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x759E410", Offset = "0x759D210", VA = "0x18759E410")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x759E1C0", Offset = "0x759CFC0", VA = "0x18759E1C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x759E260", Offset = "0x759D060", VA = "0x18759E260", Slot = "4")]
		[IteratorStateMachine(typeof(ProtobufMessageListDeserializer<>.HINBDYGDJYC))]
		public IEnumerator<(int, Protobuf)> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x759E3C0", Offset = "0x759D1C0", VA = "0x18759E3C0", Slot = "5")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct ProtobufMessageListSerializer<Protobuf> : IDisposable where Protobuf : IMessage, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly byte[] buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly Protobuf element;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CodedOutputStream outputStream;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x759E450", Offset = "0x759D250", VA = "0x18759E450", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct ProtobufRawListDeserializer : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CodedInputStream inputStream;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x99FC020", Offset = "0x99FAE20", VA = "0x1899FC020", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct ProtobufRawListSerializer : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly byte[] buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CodedOutputStream outputStream;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x99FC060", Offset = "0x99FAE60", VA = "0x1899FC060", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class XCCRJNBABUA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public static class MJDMWPVQCFD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[Flags]
	public enum RRWorldFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		Live = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Editor = 3,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		Main = 5,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		Simulation = 9,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Conversion = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Staging = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		Shadow = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		Loading = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		Saving = 0x100
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class LNSYGJNQXHY
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal class VCNRBYZICJA
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__560288337
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x99FCE90", Offset = "0x99FBC90", VA = "0x1899FCE90")]
	public static void HARHJNMTRDT()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x99FCE80", Offset = "0x99FBC80", VA = "0x1899FCE80")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
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

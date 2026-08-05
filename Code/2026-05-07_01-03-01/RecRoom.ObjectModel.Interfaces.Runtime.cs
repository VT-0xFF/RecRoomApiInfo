using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Components;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Foundation.Attributes;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.Mathematics;
using RecRoom.Foundation.Service;
using RecRoom.Foundation.Transforms;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel.Interop;
using RecRoom.ObjectModel.Serialization;
using RecRoom.ObjectModel.Systems;
using RecRoom.ObjectModel.Transmission;
using RecRoom.RendererV1;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class TMRYTQGXOHE
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
	[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
	public TMRYTQGXOHE()
	{
	}
}
namespace _LogRegistration.RecRoom_ObjectModel_Interfaces_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9A05D60", Offset = "0x9A04760", VA = "0x189A05D60", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class IHZTUXBIRMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9A05260", Offset = "0x9A03C60", VA = "0x189A05260")]
		public static void BULITDGEWUQ(this Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9A053F0", Offset = "0x9A03DF0", VA = "0x189A053F0")]
		public static void BULITDGEWUQ(this Rigidbody a, Vector3 b, Quaternion c, Vector3 d)
		{
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NativeObjectLocalIdArray : IReadOnlyList<ObjectLocalId>, IEnumerable<ObjectLocalId>, IEnumerable, IReadOnlyCollection<ObjectLocalId>, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public struct Enumerator : IEnumerator<ObjectLocalId>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly HGLSGDPNMGD objects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private NativeArray<LocalId>.Enumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public ObjectLocalId Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x9A048F0", Offset = "0x9A032F0", VA = "0x189A048F0", Slot = "4")]
				get
				{
					return default(ObjectLocalId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x9A04700", Offset = "0x9A03100", VA = "0x189A04700", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6612B70", Offset = "0x6611570", VA = "0x186612B70")]
			public Enumerator(HGLSGDPNMGD objects, NativeArray<LocalId>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9A04560", Offset = "0x9A02F60", VA = "0x189A04560", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9A04670", Offset = "0x9A03070", VA = "0x189A04670", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9A047E0", Offset = "0x9A031E0", VA = "0x189A047E0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly ObjectServiceHandle handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private NativeArray<LocalId> localIds;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ObjectLocalId this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9A06C50", Offset = "0x9A05650", VA = "0x189A06C50", Slot = "4")]
			get
			{
				return default(ObjectLocalId);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9A06CD0", Offset = "0x9A056D0", VA = "0x189A06CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int ZIWVAAJKAJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xCD0110", Offset = "0xCCEB10", VA = "0x180CD0110", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HGLSGDPNMGD TKUBPHMBRZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9A06150", Offset = "0x9A04B50", VA = "0x189A06150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FUKZCZVBGQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCD0110", Offset = "0xCCEB10", VA = "0x180CD0110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool INJIJBUVEXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9A06830", Offset = "0x9A05230", VA = "0x189A06830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NativeArray<LocalId> AAVPLZEQPST
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2D84750", Offset = "0x2D83150", VA = "0x182D84750")]
			get
			{
				return default(NativeArray<LocalId>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		internal NativeArray<Entity> BJLABQRYPPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9A067D0", Offset = "0x9A051D0", VA = "0x189A067D0")]
			get
			{
				return default(NativeArray<Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A06A70", Offset = "0x9A05470", VA = "0x189A06A70")]
		public NativeObjectLocalIdArray(int capacity, HGLSGDPNMGD objects, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A06B20", Offset = "0x9A05520", VA = "0x189A06B20")]
		public NativeObjectLocalIdArray(ObjectServiceHandle handle, NativeArray<LocalId> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A06A00", Offset = "0x9A05400", VA = "0x189A06A00")]
		public NativeObjectLocalIdArray(ObjectServiceHandle handle, NativeArray<Entity> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A06970", Offset = "0x9A05370", VA = "0x189A06970")]
		internal NativeObjectLocalIdArray(HGLSGDPNMGD objects, NativeArray<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9A06B30", Offset = "0x9A05530", VA = "0x189A06B30")]
		internal NativeObjectLocalIdArray(HGLSGDPNMGD objects, NativeArray<LocalId> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9A06BA0", Offset = "0x9A055A0", VA = "0x189A06BA0")]
		public NativeObjectLocalIdArray(HGLSGDPNMGD objects, int length, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9A068C0", Offset = "0x9A052C0", VA = "0x189A068C0")]
		public NativeObjectLocalIdArray(NativeObjectLocalIdArray existing, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A06240", Offset = "0x9A04C40", VA = "0x189A06240")]
		public void CopyTo(List<ObjectLocalId> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9A06870", Offset = "0x9A05270", VA = "0x189A06870")]
		public void TEEJQIGRNPY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9A061A0", Offset = "0x9A04BA0", VA = "0x189A061A0")]
		public NativeObjectLocalIdArray Clone(Allocator allocator)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9A066A0", Offset = "0x9A050A0", VA = "0x189A066A0")]
		public Span<ObjectLocalId> MOTFCMYGAMU()
		{
			return default(Span<ObjectLocalId>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A060B0", Offset = "0x9A04AB0", VA = "0x189A060B0")]
		public NativeObjectLocalIdArray BQYGRSHMZKL(int a, int b)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9A065A0", Offset = "0x9A04FA0", VA = "0x189A065A0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A065E0", Offset = "0x9A04FE0", VA = "0x189A065E0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A06530", Offset = "0x9A04F30", VA = "0x189A06530", Slot = "6")]
		private IEnumerator<ObjectLocalId> DMXHVQQMCYO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A064C0", Offset = "0x9A04EC0", VA = "0x189A064C0", Slot = "7")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class NIRQEDIUQVW
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D7D0", Offset = "0x3D1C1D0", VA = "0x183D1D7D0")]
		public static RentedArray<a> SRFQUJGDYCI<a>(this NativeObjectLocalIdArray a) where a : UnityEngine.Component
		{
			return default(RentedArray<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct NativeObjectLocalIdList : IList<ObjectLocalId>, ICollection<ObjectLocalId>, IEnumerable<ObjectLocalId>, IEnumerable, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public struct Enumerator : IEnumerator<ObjectLocalId>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private readonly HGLSGDPNMGD objects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private NativeArray<LocalId>.Enumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public ObjectLocalId Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x9A04820", Offset = "0x9A03220", VA = "0x189A04820", Slot = "4")]
				get
				{
					return default(ObjectLocalId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x9A04750", Offset = "0x9A03150", VA = "0x189A04750", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6612B70", Offset = "0x6611570", VA = "0x186612B70")]
			public Enumerator(HGLSGDPNMGD objects, NativeArray<LocalId>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9A045A0", Offset = "0x9A02FA0", VA = "0x189A045A0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9A045E0", Offset = "0x9A02FE0", VA = "0x189A045E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9A047A0", Offset = "0x9A031A0", VA = "0x189A047A0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly HGLSGDPNMGD objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private NativeList<LocalId> localIds;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ObjectLocalId this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9A077A0", Offset = "0x9A061A0", VA = "0x189A077A0", Slot = "4")]
			get
			{
				return default(ObjectLocalId);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9A078B0", Offset = "0x9A062B0", VA = "0x189A078B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9A07640", Offset = "0x9A06040", VA = "0x189A07640", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int FUKZCZVBGQY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9A07640", Offset = "0x9A06040", VA = "0x189A07640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NativeList<LocalId> AAVPLZEQPST
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xF22E20", Offset = "0xF21820", VA = "0x180F22E20")]
			get
			{
				return default(NativeList<LocalId>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9A07720", Offset = "0x9A06120", VA = "0x189A07720")]
		public NativeObjectLocalIdList(HGLSGDPNMGD objects, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9A07690", Offset = "0x9A06090", VA = "0x189A07690")]
		public NativeObjectLocalIdList(HGLSGDPNMGD objects, int length, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9A07430", Offset = "0x9A05E30", VA = "0x189A07430")]
		public NativeObjectLocalIdArray PZYOYNURIVP()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9A06DB0", Offset = "0x9A057B0", VA = "0x189A06DB0", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9A06DF0", Offset = "0x9A057F0", VA = "0x189A06DF0", Slot = "13")]
		public bool Contains(ObjectLocalId item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A06E70", Offset = "0x9A05870", VA = "0x189A06E70", Slot = "14")]
		public void CopyTo(ObjectLocalId[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9A06D30", Offset = "0x9A05730", VA = "0x189A06D30", Slot = "11")]
		public void Add(ObjectLocalId item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9A07360", Offset = "0x9A05D60", VA = "0x189A07360", Slot = "7")]
		public void Insert(int index, ObjectLocalId item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9A07580", Offset = "0x9A05F80", VA = "0x189A07580", Slot = "15")]
		public bool Remove(ObjectLocalId item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9A072E0", Offset = "0x9A05CE0", VA = "0x189A072E0", Slot = "6")]
		public int IndexOf(ObjectLocalId item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9A07530", Offset = "0x9A05F30", VA = "0x189A07530", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9A07210", Offset = "0x9A05C10", VA = "0x189A07210", Slot = "18")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A07250", Offset = "0x9A05C50", VA = "0x189A07250")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9A07130", Offset = "0x9A05B30", VA = "0x189A07130", Slot = "16")]
		private IEnumerator<ObjectLocalId> DMXHVQQMCYO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9A07050", Offset = "0x9A05A50", VA = "0x189A07050", Slot = "17")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface GESQGHHUKIG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ObjectLocalId DRPWYUNMYYR(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface TVUFDBDMYCZ : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.Application)]
	public interface NJEOPPRLVYV : NADQIZIJSIH, BIHWTDLPPPA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		IIPQBMUUUNB LYGCBOYGQJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		ObjectServiceHandle SCXLHVWCOSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ServiceLifetime(Lifetime.Application)]
	public interface BIHWTDLPPPA
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool DPQVXPCEHFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.Application)]
	public interface DJFBMLCIMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZDHULBJDKAN(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface GHSMJXKLDRI
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool MXEZOZRBKLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool IQNYYPYJUVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool BUFZQQXKCXE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool OJWVZPFPXUV
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool MITJVKZHUVU
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void EnableDisableObjectModel(bool enabled);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool ZNXQRERELJX(ByteString a);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BeginLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void EndLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void OZNIVPMCZTI();
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface MRGKOGFFBPH
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		GZOGVDISCYD LYGCBOYGQJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		AZDNNIWKKDD KFMDAERZIXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		KKTAWPVNWXM WWCETNPUBUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		NJEOPPRLVYV RJCARECONVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		HBUUTDQRDAM JJJUQLHOMJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		GHSMJXKLDRI KGKPGVENOBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		HELIEAOPKLU UBBQVOXSBGU
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		LVZGTYFWXRW NXAOCGKASML
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		VISHFKXSWVQ ACRPIKQILZB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		VPZOBIBRUKV ELOFUECFTHN
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		MNUBFSAMNAX AKQGVZANJQE
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		JSXKOMWKSKB SQLPEIRZCEE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		HGLSGDPNMGD TKUBPHMBRZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		FYAYARYRYXJ EHPVCQPVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		OFBOIOQEYYF MMOVINSORQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		SEEJQVFMKNL SGIMRLSWDMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		SKLFILYOTQI ARUMFGRBOGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		XSCAJHIXDHH PSCFBRRFZFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		WPADDSJKNYW QDHXSUBOZYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		KDJXJUYDJJS LACTBXQAHCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		ZGPWBPTXIHW KPLUTDFFVTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		CSZIKKFPQMN QBOCNNJRBYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		WKIRUWJGXVY BLJHTLWTLKC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		WBWASEGVKFM VCXOYQWYRSY
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		WXWCHJUHGCZ ICHUJIYNFAO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		XHVENZHSDKN TDELPAUBAWV
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		JFATBHNVEZY HDYHKPVLHBX
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		JBWPPFUIGUI YITEZGREQRP
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		MJXOFICRIZK JVJHBRLVQIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		KSRPNGZZEHB MXWLVMRCPAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ECPMBIYFXPM PWKQJNTUNKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		VRTQSTAVQZS IBPQMDVZAXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		JYNIUEISHHI THJESWWOTZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		YHMFXWNXIXZ XMNRQCCQUZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		FPZNZAZPOHQ DTQORLVLTGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		UVNSJINMWHV MEZONDNBGEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		HELMVNLONSC KIWHECGOLLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "36")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		KLGCXGVNECR EOSFPGPCORM
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		ZIKDCTRMNFK TTGBZKCLFAP
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(Slot = "38")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		FXLUUMPLGOH LMZRRPRAPGM
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[DebuggerTypeProxy(typeof(XFQUERSLFNR))]
	[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
	public readonly struct ObjectLocalId : IComparable<ObjectLocalId>, IEquatable<ObjectLocalId>
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly ObjectLocalId Invalid;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int ObjectHandleBits = 8;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const int ObjectHandleOffset = 24;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const int ObjectHandleMask = -16777216;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const int VersionMask = 16777215;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly LocalId localId;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public HGLSGDPNMGD TKUBPHMBRZK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9A08100", Offset = "0x9A06B00", VA = "0x189A08100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public NJEOPPRLVYV RJCARECONVK
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9A080A0", Offset = "0x9A06AA0", VA = "0x189A080A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public LocalId DHVTMYVFLYO
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9A08420", Offset = "0x9A06E20", VA = "0x189A08420")]
			get
			{
				return default(LocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		internal ObjectServiceHandle SCXLHVWCOSO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9A08460", Offset = "0x9A06E60", VA = "0x189A08460")]
			get
			{
				return default(ObjectServiceHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool UBSLHYICGPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9A086E0", Offset = "0x9A070E0", VA = "0x189A086E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool IVTPAISIGKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9A08800", Offset = "0x9A07200", VA = "0x189A08800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9A088E0", Offset = "0x9A072E0", VA = "0x189A088E0")]
		public ObjectLocalId(HGLSGDPNMGD objectSystem, LocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9A08850", Offset = "0x9A07250", VA = "0x189A08850")]
		public ObjectLocalId(ObjectServiceHandle handle, LocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
		public RRObject SHZCNJTRKLV()
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9A089A0", Offset = "0x9A073A0", VA = "0x189A089A0")]
		public static implicit operator LocalId(ObjectLocalId objId)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9A089E0", Offset = "0x9A073E0", VA = "0x189A089E0")]
		public static implicit operator Entity(ObjectLocalId objId)
		{
			return default(Entity);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9A08490", Offset = "0x9A06E90", VA = "0x189A08490")]
		public static bool OTUOIXXRZSY(ObjectLocalId a, ObjectLocalId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9A08470", Offset = "0x9A06E70", VA = "0x189A08470")]
		public static bool JSGIPYLAFHN(ObjectLocalId a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9A085B0", Offset = "0x9A06FB0", VA = "0x189A085B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9A08260", Offset = "0x9A06C60", VA = "0x189A08260", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9A08160", Offset = "0x9A06B60", VA = "0x189A08160", Slot = "4")]
		public int CompareTo(ObjectLocalId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "5")]
		public bool Equals(ObjectLocalId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class WAJTXVEQWQZ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9A1D4D0", Offset = "0x9A1BED0", VA = "0x189A1D4D0")]
		public static ObjectNetworkId OWIUIPDZJLB(this ObjectLocalId a)
		{
			return default(ObjectNetworkId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class XFQUERSLFNR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct ObjectServiceHandle : IEquatable<ObjectServiceHandle>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal readonly byte handle;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static byte[] handles;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static HGLSGDPNMGD defaultObjectService;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static NJEOPPRLVYV defaultObjectModel;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static HGLSGDPNMGD[] objectServices;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static NJEOPPRLVYV[] objectModels;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static Stack<byte> freeHandles;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public NJEOPPRLVYV RJCARECONVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9A08A30", Offset = "0x9A07430", VA = "0x189A08A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public HGLSGDPNMGD VOUEFLNMSYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9A095E0", Offset = "0x9A07FE0", VA = "0x189A095E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9A098F0", Offset = "0x9A082F0", VA = "0x189A098F0")]
		static ObjectServiceHandle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x271E9F0", Offset = "0x271D3F0", VA = "0x18271E9F0")]
		internal ObjectServiceHandle(byte value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x888C340", Offset = "0x888AD40", VA = "0x18888C340", Slot = "4")]
		public bool Equals(ObjectServiceHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9A08B10", Offset = "0x9A07510", VA = "0x189A08B10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x10A8E10", Offset = "0x10A7810", VA = "0x1810A8E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9A096E0", Offset = "0x9A080E0", VA = "0x189A096E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9A08BB0", Offset = "0x9A075B0", VA = "0x189A08BB0")]
		private static HGLSGDPNMGD FLULDJHKLOC(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9A09270", Offset = "0x9A07C70", VA = "0x189A09270")]
		private static NJEOPPRLVYV KRXZDEOCZTS(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9A09790", Offset = "0x9A08190", VA = "0x189A09790")]
		private static object YNGJOBZPBBI(byte a, object[] b, object c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9A08A20", Offset = "0x9A07420", VA = "0x189A08A20")]
		private static int AHETNTWHPFW(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9A096C0", Offset = "0x9A080C0", VA = "0x189A096C0")]
		private static int RVCCSJXTUVC(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9A08FE0", Offset = "0x9A079E0", VA = "0x189A08FE0")]
		private static (int, int) HMVMJECTGAS(byte a)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9A096D0", Offset = "0x9A080D0", VA = "0x189A096D0")]
		private static byte TNUHQHJKEPV(int a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A09320", Offset = "0x9A07D20", VA = "0x189A09320")]
		internal static ObjectServiceHandle QCIVJGOFOSZ(NJEOPPRLVYV a, HGLSGDPNMGD b)
		{
			return default(ObjectServiceHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9A09060", Offset = "0x9A07A60", VA = "0x189A09060")]
		internal static void JLFJVASZUFA(ObjectServiceHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9A08C60", Offset = "0x9A07660", VA = "0x189A08C60")]
		private static void FOEUYULIUDI(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum LoadType
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		SubGraph,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		SceneMainInitial,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		SceneMainJoining,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		SceneAdditive
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface WXCLJFLLUBV
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool WSKLVYELOXL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool YQZIMQLLXPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool GQCIXCIWJFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		bool FEOCBRGXHTK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool KUKPDDDNBNT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface YEGTLVEODZA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YIWKHOLBVXN(NSXTVRYRMOK a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool UGWVCHOKIKO(NSXTVRYRMOK a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PIKPWLXUUUL(ZHCAINHBIGG a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface CTLLZSJOIVD : NSXTVRYRMOK, WXCLJFLLUBV
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		int MYLJASPCLPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PNVUVRUKKHH(QGTVAOQWSXY a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface NSXTVRYRMOK : WXCLJFLLUBV
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public enum PhysicsMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			Environment = 0,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			Decoration = 1,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			Physical_Sticky = 2,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			Physical = 4
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool OIBRTMINBEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool VLHOYBTCOZY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool JJOADJERTFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface QGTVAOQWSXY
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool HXCOTOULEVL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		PrimitiveShapeType ZKCHRVVXIRP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		ZQPAARDMLME KWJHMOIBSWR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		float3 IWJEEIVKPOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		quaternion TYYYGKBREIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		float3 ZGYOETDZTFY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		RenderableMaterial DMNWOMXIVEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		RenderableColor SEPYTNPFUCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		float ODHAPYRQBCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		float3 ZVPEPEOEMXO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		float QKOZPLDHNVO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		ShapeConfigFlags ADXQLHXVAYV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface FLWDFDMXJCO
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		float3 OYWTYXOICNS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		float3 AQJHARNXCDR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		quaternion XVHCUHLEFFP(float3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface ZQPAARDMLME
	{
		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool LNMHYIDAHAY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool DOLIPISVUYT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		bool IPPOTLWSTJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		float JMWLPTNOLUF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		int UKTPAZGOJCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		int VMRQLFAKLND
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JHVVLYKJRKG(FLWDFDMXJCO a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public class OROKAFUFDSE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public OROKAFUFDSE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[ServiceLifetime(Lifetime.Application)]
	public interface LPPCGMZZECV
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		Guid JHSVSRNCVBZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task DQTWSSNNZNX(Guid a, Guid b, Guid c);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task URBLWLFLJIG(Guid a, Guid[] b, Guid c);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid YGXIJFISZFT(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task FFQWIOMZKJL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool DBFSVVFYINO(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool YYUGUIJAJRW(MFRBGNAGTXA a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void EKAPJDPMTFD(Guid a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void HESKNRYJSNC(Guid a, ObjectNetworkId b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void YTSKOUHKNTM(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void XVBJIUJFGEY(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[ServiceLifetime(Lifetime.Application)]
	public interface BKJOHHCXOLU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[ServiceLifetime(Lifetime.Application)]
	public interface CXETFXJCRSG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "0")]
		void NWBEEMPNCEP(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[ServiceLifetime(Lifetime.Application)]
	public interface AZDNNIWKKDD
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		CXETFXJCRSG SYMXMKNPQOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		UKHFKFTFVVH TEOMFWVCYPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		YVRTAJTDBFG LKDZCKBYFRC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		HROEFISIMSW UAHNRDRSJAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		UBEZRPBXLGK FABPBPCRAAS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		QBLJMYOCWMV TXFUASWUOIT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		BJMJJVEMZTV FJLDWUQHATP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		SBSJBPMIKZW GQOYNKSUQZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[ServiceLifetime(Lifetime.Application)]
	public interface UKHFKFTFVVH
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		string GVVOEDEMFGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[ServiceLifetime(Lifetime.Application)]
	public interface UIOWDEGTHPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FDKIMJMKUGC(Action a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SGSTVRJODYD(string a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int DLJDDQLZGLD(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool LRPFNZLSRTJ([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool RQYKHHNFQVU([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool AVOFRXWSZOC([Out] int a);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JENXDKPIIPX([Out] bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YVRTAJTDBFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "0")]
		void DRVJXRGBNHX(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[ServiceLifetime(Lifetime.Application)]
	public interface HROEFISIMSW
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		protected static readonly Guid JIPJSBAGIUV;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		static readonly Guid TNEJFNBXWFS;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		static readonly Guid IXPFEIBFKMY;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		static readonly Guid DIMABYNTAKI;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		bool IJXRZNLTIHS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		bool GHNVWZCTZQN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		bool QYSPSSLPMAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "2")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		bool TJPOVTUAHLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9A04DF0", Offset = "0x9A037F0", VA = "0x189A04DF0", Slot = "4")]
		string[] OWKNLAWNDDA(SerializedDataWrapper a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JGOCCQPCVKY();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8C33C50", Offset = "0x8C32650", VA = "0x188C33C50", Slot = "6")]
		Guid GOMWSSKJXDD(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int KJRLGTTEYLT(SerializedDataWrapper a);

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void EKAWSLCAAKZ(SerializedDataWrapper a, NativeArray<ViewDescriptor> b, NativeList<UniformTRS> c);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int VSRVLUDRGOH(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool MGEFWZKNMEI(string a, [Out] Guid b);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		string LIIWQPQUOMJ(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool CIIIUDDXOYK(RRObjectPrefabData a, [Out] LocalId b);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		RentedArray<byte[]> OCHYFMFQAAX(NativeArray<ViewDescriptor> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void YDJNNRKOGKA(byte[] a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		GameObject RWMEENUXJSC(string a);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void JZUIXTTTWNJ(Transform a, RRObjectPrefabData b, RMAVRNNVPKV c);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool OPYEADHTRUE(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] Exception c);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void KNZNYXNHBNY(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] NativeArray<LocalId> c, [Out] NativeArray<LocalId> d, [Out] NativeArray<AuthoredLocalPoseData> e, Allocator f);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "19")]
		void MUXXQZJJPHT(SerializedDataWrapper a, NativeArray<int> b, YYDWYZOTBEZ<GameObject> c, RentedArray<GameObject> d, LoadType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void FRNPQDXOWUH();

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "21")]
		void JQXSQSWAQFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "22")]
		void CZELXXXVEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "23")]
		bool VIPXCQGHANY(SerializedDataWrapper a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "24")]
		YEGTLVEODZA KPSASIDIPVY(SerializedDataWrapper a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "25")]
		void RZQHMOHHGSA(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "26")]
		bool KXMWZCFUMTG(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9A04E90", Offset = "0x9A03890", VA = "0x189A04E90")]
		static HROEFISIMSW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[ServiceLifetime(Lifetime.Application)]
	public interface UAXTIMVFDIQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		long KBVBNVMCRPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		long QLEKHBWZKTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "1")]
			get
			{
				return default(long);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface UBEZRPBXLGK
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		bool QCMQRXBGJQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		int XFHCHEJAQJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		int DFGAAQKITZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		int HCVIRNYRRGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		bool AGNZDQFDTOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		int OBLYGFALMNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "23")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "6")]
		void EMDWFAAPBVT(LWWFNSLLQUY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "7")]
		void VKXYQICNCUZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "8")]
		bool RHPXPUDKHBL(PlayerId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "9")]
		void UMZYUASZGCH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "10")]
		void KNKZRUAUNKU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void ATQICNWWUGP(Action<object> a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void EEVTELPAQOU(Action<object> a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "13")]
		void RLKVQUUDKYO(NativeArray<ViewId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "14")]
		void KGUMWAHNODE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "15")]
		void GMCYFMHCBIU(OutOfBandMessageType a, ReadOnlySpan<byte> b, PlayerId c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "16")]
		void GMCYFMHCBIU(OutOfBandMessageType a, ReadOnlySpan<byte> b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "17")]
		void GMCYFMHCBIU(OutOfBandMessageType a, ReadOnlySpan<byte> b, ReadOnlySpan<byte> c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "18")]
		void XGWGOPUMIOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "19")]
		void FFFHCAALSJS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "20")]
		void EILEOOKJHOJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "21")]
		void KKGHTGTTZUE(Dictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "22")]
		void BJQBWTNIMIT(NativeList<ObjectNetworkId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "24")]
		void WIBTKLZHRVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "25")]
		void FKRUBDBENNS(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "26")]
		void WWMLLCIZSYQ(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "27")]
		void URXDBQZOSHP(PlayerId a, object b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "28")]
		void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "29")]
		void DHUQQJOKETV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class BUTDCUMXZEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9A033B0", Offset = "0x9A01DB0", VA = "0x189A033B0")]
		public static NetworkPauseScope WAXOCECRSOM(this UBEZRPBXLGK a, object b)
		{
			return default(NetworkPauseScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct NetworkPauseScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private UBEZRPBXLGK dependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private object token;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9A079B0", Offset = "0x9A063B0", VA = "0x189A079B0")]
		public NetworkPauseScope(UBEZRPBXLGK dependencies, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9A07960", Offset = "0x9A06360", VA = "0x189A07960", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BYINXUJIZQB
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public delegate void ApplyNetworkTransform(ViewId viewId, NetworkTransformSyncData syncData, int sender);

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "0")]
		void Pause(ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "1")]
		void KVDKANNXYEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "2")]
		void AQALSNVAOTY(LSHBYQPFVGF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[ServiceLifetime(Lifetime.Application)]
	public interface QMWVGSDNNJW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface IWPHASWNVFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YDYALEYUFLS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[ServiceLifetime(Lifetime.Application)]
	public interface QBLJMYOCWMV
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct LoadScreenScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private QBLJMYOCWMV notifications;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x9A05C50", Offset = "0x9A04650", VA = "0x189A05C50")]
			public LoadScreenScope(QBLJMYOCWMV notifications, string title, string subtitle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x9A05B90", Offset = "0x9A04590", VA = "0x189A05B90", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public struct FadeScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private QBLJMYOCWMV notifications;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Task task;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x9A049C0", Offset = "0x9A033C0", VA = "0x189A049C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "0")]
		void EODGKZATSIV(string a, float b = 5f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "1")]
		void CLYBFMSRCOR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OJHITTAMWLA(bool a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "3")]
		void NUOZJRWRTEN(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class PAUXUAQUJZN
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9A09900", Offset = "0x9A08300", VA = "0x189A09900")]
		public static QBLJMYOCWMV.LoadScreenScope ISIYHFPFEWU(this QBLJMYOCWMV a, string b, string c)
		{
			return default(QBLJMYOCWMV.LoadScreenScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WMYKEAXLCUN
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BFIUVTYUKNN(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FXSVXSPDTQU(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TransferOwnership(GameObject gameObject, int playerId);

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool RLQXCMXVIXD(int a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object NKDSRBNEFZJ(ObjectLocalId a, GameObject b, Action<ObjectLocalId, int> c);

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FAIHIVENEZM(GameObject a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface MPBRLDAFKAA
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		EOVRJDZRSHF KTSBAVABKPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WVRHQELONBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool WLGQOEZUMUT(NetworkCreatorId a, RolePermission b);

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LDXGOQVXLDD(PlayerId a, AccountRoleTypeNetworked b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[ServiceLifetime(Lifetime.Application)]
	public interface LNUHSLYLTNM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XQIXCNAGDPI(object a, NativeList<byte> b);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object Deserialize(NativeArray<byte> data);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[ServiceLifetime(Lifetime.Application)]
	public interface OZFDJSAJKUJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		bool DKPTJCPBOTQ
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Delegate AWPGPCBOAJM(MSJSHKZSHXI a, Action<MSJSHKZSHXI> b);

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MTRIZCNRNED(MSJSHKZSHXI a, Delegate b);

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Delegate GXFUROZDSIX(MSJSHKZSHXI a, Action<MSJSHKZSHXI> b);

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PZHVWLYVKML(MSJSHKZSHXI a, Delegate b);

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool UPULZZDYYNO(MSJSHKZSHXI a);

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "6")]
		MSJSHKZSHXI FMXWDLROQEW(GameObject a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface HYUDKEUUZXJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		int EFPXCEYTUKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		int MJQNOBUAIGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		bool XLEDPRFSZDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		bool PFBDFEBJCNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ObjectLocalId HVCNKBPRUAD(int a);

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GWAANTEXKNB(GameObject a, JobHandle b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface EOVRJDZRSHF
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool GEHNDKWNHSD(AccountRoleTypeNetworked a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface BJMJJVEMZTV
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		bool MXEZOZRBKLS
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[ServiceLifetime(Lifetime.Application)]
	public interface EEIFNMSBFQJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		NCPTMOREMZE UVRMMDWNODT
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		SWNDSGXUJHW OYUENVUPCFN
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		bool XJETVEKFUDX
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OBPCYWSYLRB(Transform a);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DCZSKCOGCKD(Transform a, SelectionEffectType b);

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZBCAOENBIJN(Transform a, OutlineEffectType b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[ServiceLifetime(Lifetime.Application)]
	public interface SBSJBPMIKZW
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action ZDCFAXTZSWU;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[ServiceLifetime(Lifetime.Application)]
	public interface THBSXCKWQOU
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FRDVHUHKMMW();
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[ServiceLifetime(Lifetime.Application)]
	public interface KPWCSJGRLON
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BUPYINVOJSX(GameObject a, ObjectPolicyUserConfigurableFlags b, CircuitsTransformBehavior c);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TEWGJHVAVXY(ObjectLocalId a, bool b, float3 c, quaternion d);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool OFXNLHHSGVZ(NativeObjectLocalIdArray a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TLYUDMTDUHL(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SXYRLMYFFFT(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HKEOLMKYQOG(NativeObjectLocalIdArray a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void USPMYDOXVGH(SerializedDataWrapper a, ReadOnlySpan<Guid> b, ReadOnlySpan<int> c, RentedArray<GameObject> d);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void PGDHKFPDNIN(EKVACRJICQQ a);

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void UCDEPCXMSUS(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void EWTAZXHAEVF(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void AXSFSZIBZOT(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct NativeArrayPinnedMemory : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly NativeArray<byte> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly GCHandle handle;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9A06000", Offset = "0x9A04A00", VA = "0x189A06000")]
		public NativeArrayPinnedMemory(ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9A05FD0", Offset = "0x9A049D0", VA = "0x189A05FD0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum SerializedAssetVersion
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		V0PreObjectModel = 0,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		V1ObjectModelHierarchy = 1,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		V2ObjectModelHierarchy = 2,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		V3Entities050 = 3,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		V4Entities050Compressed = 4,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		V5BumpObjectModelVersionMay2024 = 5,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		V6Entities100 = 6,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		OldestCompatibleVersion = 3,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		LatestVersion = 6
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct SerializedDataWrapper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public ByteString serializedOMData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public object persistenceViewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public object connectableGraphData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IEnumerable<string> legacyTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public bool isLatestDeprecatedVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public HUJCMRRZRDC.EditReadyPreference? loadEditReadyPreference;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9A1D090", Offset = "0x9A1BA90", VA = "0x189A1D090")]
		public SerializedDataWrapper(ByteString serializedOMData, [Optional] object persistenceViewData, [Optional] object connectableGraphData, [Optional] IEnumerable<string> legacyTags, bool isLatestDeprecatedVersion = true, [Optional] HUJCMRRZRDC.EditReadyPreference? loadEditReadyPreference)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct SerializedObjectModelData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public object objectModelData;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct ViewDescriptor
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[Flags]
		public enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			IsInvalid = 1,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			IsStudioPrefab = 2,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			IsBetaOnly = 4,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			IsDevOnly = 8,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			IsR1Only = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			IsR1Upgrade = 0x20,
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			IsAllowedDevOnly = 0x40
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public RRObjectPrefabData prefabData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public Guid persistenceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Guid costumeKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid objectBoardGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Guid circuitParentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Flags flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Color32 colorOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int spawnableToolType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public GameTeam teamOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int entityIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int transformIndex;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Guid PILKNZNKASL
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x6930F80", Offset = "0x692F980", VA = "0x186930F80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool LIMMCILJILH
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9A1D490", Offset = "0x9A1BE90", VA = "0x189A1D490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool HKVUPZXAIEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9A1D4B0", Offset = "0x9A1BEB0", VA = "0x189A1D4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public bool TTUZNEDUUPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x9A1D4C0", Offset = "0x9A1BEC0", VA = "0x189A1D4C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool DEUFJWOBTTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9A1D4A0", Offset = "0x9A1BEA0", VA = "0x189A1D4A0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public readonly struct HistoryAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal readonly HistoryMarker start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		internal readonly HistoryMarker end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal readonly uint sequenceId;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9A04FB0", Offset = "0x9A039B0", VA = "0x189A04FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public readonly struct UndoAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		internal readonly HistoryAction action;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9A1CC80", Offset = "0x9A1B680", VA = "0x189A1CC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct RedoAction
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal readonly HistoryAction action;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9A1CC80", Offset = "0x9A1B680", VA = "0x189A1CC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public readonly struct GotoMarker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		internal readonly uint sequenceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		internal readonly bool isAtStart;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9A04BC0", Offset = "0x9A035C0", VA = "0x189A04BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct HistoryMarker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		internal int offset;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9A05200", Offset = "0x9A03C00", VA = "0x189A05200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface FWSSABKIMWK
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		FAATJHKFRIL NQUYRTUWWJO
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public interface MFRBGNAGTXA
	{
		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public interface PUPTIMBFTTC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class UHNFGYPAZYM
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x407D2D0", Offset = "0x407BCD0", VA = "0x18407D2D0")]
		public static RRObject SHZCNJTRKLV<a>(this a a) where a : MFRBGNAGTXA
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9A1D2F0", Offset = "0x9A1BCF0", VA = "0x189A1D2F0")]
		public static MonoBehaviour LDOQSCVYYLQ(this MFRBGNAGTXA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9A1D230", Offset = "0x9A1BC30", VA = "0x189A1D230")]
		public static GameObject GameObject(this MFRBGNAGTXA localId)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface TYCGBKIHXGP : MFRBGNAGTXA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(ObjectLocalId objectId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface BVAQGUDMNAD : MFRBGNAGTXA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface ALVUFJXDTSX
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate void ParentsChangedCallback(ObjectIdBulkPropertyChangeData changeData);

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event ParentsChangedCallback PUQYDQIHWTV;
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface TBGALQKOHQP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public interface QQLSGEOIHHM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public interface YVDKQKBSXKR
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Transform GetTransform();

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Collider GetCollider();

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MoveToObject(ObjectLocalId newObject);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NotifyIsUniform(bool isUniform);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DestroyCollider();

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CGASNRSNJHY(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface OZMZQLMOPJA
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnRootRBEXChanged(KMOQKJRUHKT newRootWithUnityRigidbody);
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface KMOQKJRUHKT
	{
		[Cpp2IlInjected.Token(Token = "0x17000090")]
		GameObject VZLOKPUPAPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		Transform MOIDUDMLUHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		ZQMLMNOMZOF UJDDIIPQTTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		bool YFCLYFNLWNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SetImplementation(ZQMLMNOMZOF impl);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "5")]
		RigidbodyExData GetData();
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class LZNWBEAYZQR
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9A05810", Offset = "0x9A04210", VA = "0x189A05810")]
		public static void HYKDISPAMVS(this KMOQKJRUHKT a, RMAVRNNVPKV b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public interface ZQMLMNOMZOF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000094")]
		ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		Rigidbody KHYJRPPXAYM
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		KMOQKJRUHKT HZDAJVCTQRI
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		GameObject ICUGWAERVKN
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		Transform QSGLKOZVOYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		ZQMLMNOMZOF JRPWOYBYXDS
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "24")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		ZQMLMNOMZOF LJEDQXPUPWM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		int XAOOVQUVFEV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		bool QXSCYEDOSSQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		bool UPULZZDYYNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		bool OOZXOXOZHXA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		ZOVUKJMZZZX AOKCYJWQPTE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "32")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		VHPXXKFPOWQ NKQIKWRUTWB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(Slot = "34")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		float IDSRIGGLLPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(Slot = "36")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		Vector3 JIKKNTHRKPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "38")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		Vector3 SRVMSSDTLQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		Vector3 RRMSKUFHRKD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(Slot = "42")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		Vector3 YDFIVHFCMMV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(Slot = "43")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(Slot = "44")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		bool VRZBNSGLLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "45")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		bool RUWVMCCDWAE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "46")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		bool LNWEFXCQRWN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(Slot = "47")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		bool UGGLONJZEKR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(Slot = "48")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		Vector3 XHKDYATUGUB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(Slot = "49")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		Vector3 YWLBZGMWSJV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(Slot = "50")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		Vector3 RTSRSJGUZUD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(Slot = "51")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(Slot = "52")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		Vector3 JUKRVYKYXIY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "53")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		float FKZAPSBNKFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "54")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		float LIJZLPMOYEX
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(Slot = "55")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(Slot = "56")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		Vector3 OHPFTSWFABZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(Slot = "57")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		Quaternion KTUEOSYXGBL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(Slot = "58")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		float UTUKDVVIXFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(Slot = "61")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		float YNPJGOPKEOI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(Slot = "62")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "63")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		bool XBTGJQDHCAX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "64")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "65")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		TransformTrackRate EVUDKCJGMVV
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "66")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "67")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		bool AFOBOGMJGQR
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(Slot = "68")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		Transform UNYDUFSWWET
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(Slot = "69")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		Vector3 KTLLGOTLHUX
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(Slot = "70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(Slot = "71")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		float BHARUBFJFYR
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(Slot = "72")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(Slot = "73")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		float YRCLGCUIWQC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(Slot = "74")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(Slot = "75")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		Quaternion GRORAHEHWTI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "76")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "77")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		Vector3 OYWTYXOICNS
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(Slot = "78")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(Slot = "79")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		Quaternion SILHDFYWFMV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(Slot = "80")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(Slot = "81")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		RigidbodyConstraints QAVYICNEWFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(Slot = "82")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(Slot = "83")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		bool TEABYKKZBIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(Slot = "84")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(Slot = "85")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		CollisionDetectionMode CUQKHVLOPTW
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(Slot = "86")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(Slot = "87")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		bool JFIXCPFMHIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(Slot = "88")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event RbexAction JSHYSEORPJS;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event RbexAction NCOVUYOXOIW;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event RbexAction TJCGOVKNSRN;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event RbexAction PMOPKNNGYQC;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event RbexAction GZAUIERVCUH;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RbexAction YVFIPOZKCPI;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event RbexAction EZKQRLZNXRX;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexParentChangeAction HFBDPZFCSXK;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<UpdateLOD, UpdateLOD> IJJTPQCCHKE;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		ZQMLMNOMZOF AOZKAPIMUAG(int a);

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void BQHFSGTYFXJ((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "89")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "90")]
		void OnEnable();

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "91")]
		void OnDisable();

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "92")]
		void OnDestroy();

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "93")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "94")]
		void SetParent(ZQMLMNOMZOF value, bool isPhysicallyDetachedOnly = false);

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "95")]
		void NIGRQYCUFCF(object a);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "96")]
		void MAVVFILWOVS(object a);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "97")]
		Vector3 SMGJFHJSFJZ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "98")]
		Vector3 ZVJHSEUXEDP(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "99")]
		void RYCXBTSDDBQ();

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "100")]
		void IPEHKIECNGX();

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "101")]
		void ZHKANFLSSCG();

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "102")]
		void XYWNSMXCFWW(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "103")]
		void SFBTBVIHMQD(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "104")]
		void BOHURHYOJVQ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "105")]
		void BWVSFQYSBMQ(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "106")]
		void CMRSIBZELEJ(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "107")]
		void PDOVLGASFHY(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "108")]
		Vector3 LVCGTJTZAHV(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "109")]
		Vector3 BEECOPKQTIR(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "110")]
		void PELUKPZRVUW();

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "111")]
		void OLRDBCKXNEU(ZQMLMNOMZOF a, object b);

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "112")]
		void YFMAXEPRRUN(object a);

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "113")]
		void IDSDGUINODT();

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "114")]
		void KZPXHKZDQGW();

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "115")]
		void OCOWWDWRTCP();

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "116")]
		bool IOVKONZTROR();

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "117")]
		void JUTDFRJASKN();

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "118")]
		void PAHPFVUNPZK(object a);

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "119")]
		void BAFTEKBKLSZ(object a);

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "120")]
		void OGOSDAOGOQJ(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "121")]
		void TPUYHIGAYKH(Vector3 a, Quaternion b);

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "122")]
		void ZCEGLEGOTAT(Vector3 a, Quaternion b);

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "123")]
		bool TWYJUBLVPDQ(float a);

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "124")]
		void JNAJBSJDBEX(object a);

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "125")]
		void ZWYGEBYOBDC(object a);

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "126")]
		void DXKCMOTVTOD(object a);

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "127")]
		void SJBKOBVMAWG(object a);

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "128")]
		void GKJMLDQMPPI(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "129")]
		void XUZKGSGBWEU(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "130")]
		void XZHSZBOKJON(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "131")]
		void LOALQDTSCIF(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "132")]
		bool NGVDFSMQMKU(Vector3 a, [Out] RaycastHit b, float c);

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "133")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public interface VHPXXKFPOWQ
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class KXYSMYQEDYH : VHPXXKFPOWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public KXYSMYQEDYH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "0")]
		void NOZBHZMJTWR(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "1")]
		void WUFWHKWRPOM(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "2")]
		void OIOJZHDUJBW(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "3")]
		void QSZJDUKEWFR(Vector3 a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public interface ZOVUKJMZZZX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Vector3 AWRBJHDCQWZ();

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Vector3 WYEALHDXNIU();

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool OCDRMXCHSYX(float a, float b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void RbexAction(KMOQKJRUHKT thisRigidbodyEx);
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum RbexCallbackType
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		ChildAdded,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		ChildRemoved,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		ParentChanged,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		HierarchyMassUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		SleepChanged,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		DistanceBandChanged,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		IsKinematicChanged,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Discontinuity,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Destroyed,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		COUNT
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum RbexImpulseType
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Additive,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Override,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Reflective,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		FullOverride
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public delegate void RbexParentChangeAction(KMOQKJRUHKT thisRigidbodyEx, bool isPhysicallyDetachedOnly = false);
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public enum RbexRotationType
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Additive,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Override,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Reflective
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct RigidbodyExData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public object photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Vector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Vector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public RbexInterpolationMode physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public bool hasPrecomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public bool hasCustomCenterOfMass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public readonly struct RRObject : IEquatable<RRObject>
	{
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly RRObject Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public GameObject VZLOKPUPAPP
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B2F0", Offset = "0x9A19CF0", VA = "0x189A1B2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public ObjectNetworkId WBHQPBNDYHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B810", Offset = "0x9A1A210", VA = "0x189A1B810")]
			get
			{
				return default(ObjectNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public ObjectType QSTVXBBPGZB
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x9A1BA00", Offset = "0x9A1A400", VA = "0x189A1BA00")]
			get
			{
				return default(ObjectType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public RRObjectPrefabData HYDICODXRCG
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B1B0", Offset = "0x9A19BB0", VA = "0x189A1B1B0")]
			get
			{
				return default(RRObjectPrefabData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool VMOOEVHCNQN
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B2D0", Offset = "0x9A19CD0", VA = "0x189A1B2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public bool JYZZMUXTMBR
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B150", Offset = "0x9A19B50", VA = "0x189A1B150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool HXCOTOULEVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B0F0", Offset = "0x9A19AF0", VA = "0x189A1B0F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public bool FMDFHVBJDAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x9A1AAE0", Offset = "0x9A194E0", VA = "0x189A1AAE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public bool VMCMRYOJORH
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x9A1BAA0", Offset = "0x9A1A4A0", VA = "0x189A1BAA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public bool FLLVLJRNFVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B9D0", Offset = "0x9A1A3D0", VA = "0x189A1B9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public bool GWCHOKYDIEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x9A1A9A0", Offset = "0x9A193A0", VA = "0x189A1A9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public bool QUBGYENFVWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B070", Offset = "0x9A19A70", VA = "0x189A1B070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public bool ZLWRGZPPNPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x9A1BAC0", Offset = "0x9A1A4C0", VA = "0x189A1BAC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public bool BSQYWEKNHWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B510", Offset = "0x9A19F10", VA = "0x189A1B510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public bool BEDOWZGVKMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B5E0", Offset = "0x9A19FE0", VA = "0x189A1B5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public bool MRCQXUQYVPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B0B0", Offset = "0x9A19AB0", VA = "0x189A1B0B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public bool LUCUDSCSPKB
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B5A0", Offset = "0x9A19FA0", VA = "0x189A1B5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public bool NUEUOBLQZGO
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x9A1AA10", Offset = "0x9A19410", VA = "0x189A1AA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public bool UJXCKEZCBRW
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B110", Offset = "0x9A19B10", VA = "0x189A1B110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public bool COJIEEGXMOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B950", Offset = "0x9A1A350", VA = "0x189A1B950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool GPFLCEZZKVS
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B170", Offset = "0x9A19B70", VA = "0x189A1B170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public RRObjectCircuitBoard MXULMGACHRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectCircuitBoard);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public RRObjectIdentity JAMFGMSEUFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectIdentity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public RRObjectPhysics EHPVCQPVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectPhysics);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public RRObjectPlayerInteraction UGOPITZRURF
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectPlayerInteraction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public RRObjectPolicy HEWKGXASNDM
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectPolicy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public RRObjectReferenceGroup NSWJSLZYXTW
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectReferenceGroup);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public RRObjectRenderEffects CKXXLYUOQKG
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectRenderEffects);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public RRObjectReplicatedObject SNBQMLJNCRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectReplicatedObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public RRObjectReplicator LGRZSLXQKEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectReplicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public RRObjectScope MMOVINSORQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectScope);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public RRObjectToolCleanup OUJGNPCBNMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectToolCleanup);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public RRObjectUserTags IUTVASMPEUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectUserTags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public RRObjectAIMetadata WNDZYICSFRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectAIMetadata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public RRObjectDeformable FROGVZRFZFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectDeformable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public RRObjectObjectInteractionFilter KXDUXFIBYZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectObjectInteractionFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool UUFQBJTBDNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x9A1AC40", Offset = "0x9A19640", VA = "0x189A1AC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool QMJUQLWVFHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x9A1AA50", Offset = "0x9A19450", VA = "0x189A1AA50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public bool SYAFJFHJEKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x9A1ADD0", Offset = "0x9A197D0", VA = "0x189A1ADD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool UBSLHYICGPG
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B7D0", Offset = "0x9A1A1D0", VA = "0x189A1B7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool LQDNYGUOHAU
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B620", Offset = "0x9A1A020", VA = "0x189A1B620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool CAOMNXGPLNH
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B990", Offset = "0x9A1A390", VA = "0x189A1B990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public bool EDEEALNMWIA
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x9A1B4D0", Offset = "0x9A19ED0", VA = "0x189A1B4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public RRObjectTransform QSGLKOZVOYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public RRObjectHierarchy ELOFUECFTHN
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		private HGLSGDPNMGD TKUBPHMBRZK
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x9A08100", Offset = "0x9A06B00", VA = "0x189A08100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0")]
		public static implicit operator RRObject(ObjectLocalId objectId)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AFA0", Offset = "0x9A199A0", VA = "0x189A1AFA0")]
		public RRObjectContainer FUZMHXJOOID()
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A9E0", Offset = "0x9A193E0", VA = "0x189A1A9E0")]
		public RRObjectShape ARRLQFXFZGB()
		{
			return default(RRObjectShape);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9A1B550", Offset = "0x9A19F50", VA = "0x189A1B550")]
		public RRObjectConnectable STFLOEQIVLM()
		{
			return default(RRObjectConnectable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x9A1B7E0", Offset = "0x9A1A1E0", VA = "0x189A1B7E0")]
		public RRObjectPlayer UMIZTVBUBCR()
		{
			return default(RRObjectPlayer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9A1B020", Offset = "0x9A19A20", VA = "0x189A1B020")]
		public RRObjectPlayerInteractionFilter GMMGOTDEURM()
		{
			return default(RRObjectPlayerInteractionFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AA90", Offset = "0x9A19490", VA = "0x189A1AA90")]
		public RRObjectStudioObject CXWYXKNYBKZ()
		{
			return default(RRObjectStudioObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x9A1B8B0", Offset = "0x9A1A2B0", VA = "0x189A1B8B0")]
		public RRObjectElementSnapPoint UZSLEEZYCRU()
		{
			return default(RRObjectElementSnapPoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x9A1B480", Offset = "0x9A19E80", VA = "0x189A1B480")]
		public RRObjectElement RNMGPZQKPEY()
		{
			return default(RRObjectElement);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x9A1B900", Offset = "0x9A1A300", VA = "0x189A1B900")]
		public RRObjectTerrain VFLHTIXEIXP()
		{
			return default(RRObjectTerrain);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AEA0", Offset = "0x9A198A0", VA = "0x189A1AEA0")]
		public void FQMGIJEMBRA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AB00", Offset = "0x9A19500", VA = "0x189A1AB00")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AD30", Offset = "0x9A19730", VA = "0x189A1AD30")]
		public void EMBYHOZIGEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9A1ABA0", Offset = "0x9A195A0", VA = "0x189A1ABA0")]
		public bool ECFZKFWTVIA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9A1B660", Offset = "0x9A1A060", VA = "0x189A1B660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C260", Offset = "0x9A0AC60", VA = "0x189A0C260")]
		public static implicit operator bool(RRObject value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0")]
		public static implicit operator ObjectLocalId(RRObject value)
		{
			return default(ObjectLocalId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D550", Offset = "0x9A0BF50", VA = "0x189A0D550")]
		public static bool OTUOIXXRZSY(RRObject a, RRObject b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9A08470", Offset = "0x9A06E70", VA = "0x189A08470")]
		public static bool JSGIPYLAFHN(RRObject a, RRObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AE10", Offset = "0x9A19810", VA = "0x189A1AE10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObject other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct RRObjectAIMetadata : IEquatable<RRObjectAIMetadata>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		private YHMFXWNXIXZ PBTAYDSJRYN
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x9A0AA60", Offset = "0x9A09460", VA = "0x189A0AA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A5D0", Offset = "0x9A08FD0", VA = "0x189A0A5D0")]
		public void JGBVCZVAKSV(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A960", Offset = "0x9A09360", VA = "0x189A0A960")]
		public bool RIGCKBLQIAQ([Out] uint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A4D0", Offset = "0x9A08ED0", VA = "0x189A0A4D0")]
		public bool HRSTMQMXQAK([Out] uint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A350", Offset = "0x9A08D50", VA = "0x189A0A350")]
		public void CRULZHCSYWA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A850", Offset = "0x9A09250", VA = "0x189A0A850")]
		[CanBeNull]
		public string MWOVDCDXCQQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A6D0", Offset = "0x9A090D0", VA = "0x189A0A6D0")]
		public bool JKOGTIEPBDN([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAE0", Offset = "0x9A094E0", VA = "0x189A0AAE0")]
		public void WNDMUMTGRQA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectAIMetadata(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A440", Offset = "0x9A08E40", VA = "0x189A0A440", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectAIMetadata other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public readonly struct RRObjectCircuitBoard : IEquatable<RRObjectCircuitBoard>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		private HELIEAOPKLU JQIKIYYBFPF
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x9A0AB80", Offset = "0x9A09580", VA = "0x189A0AB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		private YHMFXWNXIXZ XMNRQCCQUZA
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B470", Offset = "0x9A09E70", VA = "0x189A0B470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public bool AYEJJKXMKGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x9A0AD90", Offset = "0x9A09790", VA = "0x189A0AD90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public bool PUVIJSQGRYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B000", Offset = "0x9A09A00", VA = "0x189A0B000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		public bool PYFDQAXARQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x9A0AF40", Offset = "0x9A09940", VA = "0x189A0AF40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public Guid QCLMZCPQTFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x9A0AD10", Offset = "0x9A09710", VA = "0x189A0AD10")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public Guid XJZDRDVDUVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B4D0", Offset = "0x9A09ED0", VA = "0x189A0B4D0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		public Guid VQJKILBVHEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B040", Offset = "0x9A09A40", VA = "0x189A0B040")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		public RRObjectHierarchy ELOFUECFTHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B550", Offset = "0x9A09F50", VA = "0x189A0B550")]
		public bool YCNBAHFIKEW([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AC70", Offset = "0x9A09670", VA = "0x189A0AC70")]
		public bool HFDTCASQRZU([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AE20", Offset = "0x9A09820", VA = "0x189A0AE20")]
		public void NDMYDMJILTL(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B370", Offset = "0x9A09D70", VA = "0x189A0B370")]
		public void VPEOXUPQIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B250", Offset = "0x9A09C50", VA = "0x189A0B250")]
		public Guid UVDROOLSAMC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectCircuitBoard(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0ABE0", Offset = "0x9A095E0", VA = "0x189A0ABE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectCircuitBoard other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public readonly struct RRObjectConnectable : IEquatable<RRObjectConnectable>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		private VISHFKXSWVQ PIRWRWJCFYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B7C0", Offset = "0x9A0A1C0", VA = "0x189A0B7C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public RigidTransform HZPNAHHKOPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BD00", Offset = "0x9A0A700", VA = "0x189A0BD00")]
			get
			{
				return default(RigidTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public Vector3 IMZVFLVIPYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BBB0", Offset = "0x9A0A5B0", VA = "0x189A0BBB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public Quaternion DKLACADHDED
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C080", Offset = "0x9A0AA80", VA = "0x189A0C080")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public float VQQEAERWNCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BA80", Offset = "0x9A0A480", VA = "0x189A0BA80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public RRObject IGPCRLQALNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BE30", Offset = "0x9A0A830", VA = "0x189A0BE30")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B5F0", Offset = "0x9A09FF0", VA = "0x189A0B5F0")]
		public NativeObjectLocalIdArray DVEMSNXODWV(Allocator a)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C1C0", Offset = "0x9A0ABC0", VA = "0x189A0C1C0")]
		public bool ZPBQJWGOKAO(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B820", Offset = "0x9A0A220", VA = "0x189A0B820")]
		public void LNEBNDBARWM(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B970", Offset = "0x9A0A370", VA = "0x189A0B970")]
		public void MBXKBQLQBUH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0BEC0", Offset = "0x9A0A8C0", VA = "0x189A0BEC0")]
		public void VXGIJPCPYYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectConnectable(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C260", Offset = "0x9A0AC60", VA = "0x189A0C260")]
		public static implicit operator bool(RRObjectConnectable value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0")]
		public static implicit operator ObjectLocalId(RRObjectConnectable value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B730", Offset = "0x9A0A130", VA = "0x189A0B730", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectConnectable other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public readonly struct RRObjectContainer : IEquatable<RRObjectContainer>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly RRObjectContainer Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		private VPZOBIBRUKV ZMAXZTUXDYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C9B0", Offset = "0x9A0B3B0", VA = "0x189A0C9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
		public Span<RRObject> JDMGHFSWVRF
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C300", Offset = "0x9A0AD00", VA = "0x189A0C300")]
			get
			{
				return default(Span<RRObject>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public string KPIDBUYRLLN
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C490", Offset = "0x9A0AE90", VA = "0x189A0C490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C280", Offset = "0x9A0AC80", VA = "0x189A0C280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		public RRObjectTransform QSGLKOZVOYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		public RRObjectHierarchy ELOFUECFTHN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C510", Offset = "0x9A0AF10", VA = "0x189A0C510")]
		public void VSNTZMLJBHW(RRObjectContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectContainer(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C260", Offset = "0x9A0AC60", VA = "0x189A0C260")]
		public static implicit operator bool(RRObjectContainer value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C400", Offset = "0x9A0AE00", VA = "0x189A0C400", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectContainer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0")]
		public static implicit operator RRObject(RRObjectContainer self)
		{
			return default(RRObject);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct RRObjectCreationParameters : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Dictionary<int, object> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private XDVRHPNXVJM wrapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool isReadOnly;

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		public RRObject Object
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			[CompilerGenerated]
			readonly get
			{
				return default(RRObject);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public CreationInstantiationKey this[CreationInstantiationKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CD30", Offset = "0x9A0B730", VA = "0x189A0CD30")]
			readonly set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CC60", Offset = "0x9A0B660", VA = "0x189A0CC60")]
		internal RRObjectCreationParameters(RRObject obj, bool isReadOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CA10", Offset = "0x9A0B410", VA = "0x189A0CA10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0EF0", Offset = "0x3ECF8F0", VA = "0x183ED0EF0")]
		public void QMLTHEMQRBT<a>(CreationInstantiationKey a, a b, [Optional] a c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CB40", Offset = "0x9A0B540", VA = "0x189A0CB40")]
		public void Remove(CreationInstantiationKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xF22E20", Offset = "0xF21820", VA = "0x180F22E20")]
		public Dictionary<int, object> YPNYEETNIWU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CBF0", Offset = "0x9A0B5F0", VA = "0x189A0CBF0")]
		private readonly void YWZVXBQNAPW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class JPBZOADJWYX
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x9A05750", Offset = "0x9A04150", VA = "0x189A05750")]
		public static RRObjectCreationParameters YEQPMMZURPE(this RRObject a)
		{
			return default(RRObjectCreationParameters);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct RRObjectDeformable : IEquatable<RRObjectDeformable>
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly RRObjectDeformable Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		private bool BEDOWZGVKMF
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CFE0", Offset = "0x9A0B9E0", VA = "0x189A0CFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		public Vector3 KLVTJWHZWYK
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D1B0", Offset = "0x9A0BBB0", VA = "0x189A0D1B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CF80", Offset = "0x9A0B980", VA = "0x189A0CF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CF00", Offset = "0x9A0B900", VA = "0x189A0CF00")]
		public Vector3 MPSHCSXFQBU()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CE80", Offset = "0x9A0B880", VA = "0x189A0CE80")]
		public void KUZEJQLZMHU([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D130", Offset = "0x9A0BB30", VA = "0x189A0D130")]
		public void UGRLVYPUYWM([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D080", Offset = "0x9A0BA80", VA = "0x189A0D080")]
		public bool UENJEQUUNBP([In] Vector3 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectDeformable(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CDF0", Offset = "0x9A0B7F0", VA = "0x189A0CDF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectDeformable other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D020", Offset = "0x9A0BA20", VA = "0x189A0D020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct RRObjectDesync : IEquatable<RRObjectDesync>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D2E0", Offset = "0x9A0BCE0", VA = "0x189A0D2E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectDesync other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct RRObjectElement : IEquatable<RRObjectElement>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		private HELMVNLONSC KIWHECGOLLD
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x9A0DB70", Offset = "0x9A0C570", VA = "0x189A0DB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		public bool MWSOTJZMKCA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x9A0DC70", Offset = "0x9A0C670", VA = "0x189A0DC70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public bool IGJSVIOVPUG
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x9A0DA40", Offset = "0x9A0C440", VA = "0x189A0DA40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		public ElementGroupStatusData NXSAJHYRVTR
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D880", Offset = "0x9A0C280", VA = "0x189A0D880")]
			get
			{
				return default(ElementGroupStatusData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public bool PFUIBJVGLPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x9A0E000", Offset = "0x9A0CA00", VA = "0x189A0E000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		public bool DZLUAISKVIS
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D760", Offset = "0x9A0C160", VA = "0x189A0D760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public bool JYACPFGBEMC
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D9B0", Offset = "0x9A0C3B0", VA = "0x189A0D9B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DF60", Offset = "0x9A0C960", VA = "0x189A0DF60")]
		public bool WUGCVTSSEYJ(RRObjectElement a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DBD0", Offset = "0x9A0C5D0", VA = "0x189A0DBD0")]
		public bool QRBWRGSSNQW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DEC0", Offset = "0x9A0C8C0", VA = "0x189A0DEC0")]
		public bool VGCPJTIKGIP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DDA0", Offset = "0x9A0C7A0", VA = "0x189A0DDA0")]
		public ReadOnlySpan<ObjectLocalId> UTUDXRBLKRU()
		{
			return default(ReadOnlySpan<ObjectLocalId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectElement(ObjectLocalId localId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D550", Offset = "0x9A0BF50", VA = "0x189A0D550")]
		public static bool OTUOIXXRZSY(RRObjectElement a, RRObjectElement b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x9A08470", Offset = "0x9A06E70", VA = "0x189A08470")]
		public static bool JSGIPYLAFHN(RRObjectElement a, RRObjectElement b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D7F0", Offset = "0x9A0C1F0", VA = "0x189A0D7F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectElement other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public readonly struct RRObjectElementSnapPoint : IEquatable<RRObjectElementSnapPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly RRObjectElementSnapPoint Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		private HELMVNLONSC BVOZXUGXNCX
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D560", Offset = "0x9A0BF60", VA = "0x189A0D560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public bool XAPTDOLRFUC
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D5C0", Offset = "0x9A0BFC0", VA = "0x189A0D5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public RRObjectTransform QSGLKOZVOYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D6C0", Offset = "0x9A0C0C0", VA = "0x189A0D6C0")]
		public bool WUGCVTSSEYJ(RRObjectElementSnapPoint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D620", Offset = "0x9A0C020", VA = "0x189A0D620")]
		public bool UUXSJPHPMXB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D400", Offset = "0x9A0BE00", VA = "0x189A0D400")]
		public bool IKAMBEDSCWF([Out] RRObjectElementSnapPoint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D4E0", Offset = "0x9A0BEE0", VA = "0x189A0D4E0")]
		public void MUILLMWPCOK(ElementSnapPointRuntimeFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectElementSnapPoint(ObjectLocalId localId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D550", Offset = "0x9A0BF50", VA = "0x189A0D550")]
		public static bool OTUOIXXRZSY(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x9A08470", Offset = "0x9A06E70", VA = "0x189A08470")]
		public static bool JSGIPYLAFHN(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D370", Offset = "0x9A0BD70", VA = "0x189A0D370", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectElementSnapPoint other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public readonly struct RRObjectHierarchy : IEquatable<RRObjectHierarchy>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		private VPZOBIBRUKV ZMAXZTUXDYG
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x9A0E9F0", Offset = "0x9A0D3F0", VA = "0x189A0E9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		public ObjectLocalId XYVYJSDQQMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x9A0E960", Offset = "0x9A0D360", VA = "0x189A0E960")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		public RRObject JRPWOYBYXDS
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x9A0E040", Offset = "0x9A0CA40", VA = "0x189A0E040")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		public RRObject LJEDQXPUPWM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x9A0E730", Offset = "0x9A0D130", VA = "0x189A0E730")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E500", Offset = "0x9A0CF00", VA = "0x189A0E500")]
		public Span<RRObject> QAVZNJLDWHJ()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E300", Offset = "0x9A0CD00", VA = "0x189A0E300")]
		public Span<RRObject> MZGCIZMSKPW()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E200", Offset = "0x9A0CC00", VA = "0x189A0E200")]
		public Span<RRObject> GRGFBDMQBJL()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E400", Offset = "0x9A0CE00", VA = "0x189A0E400")]
		public Span<RRObject> NUAQFRAIOBD()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E600", Offset = "0x9A0D000", VA = "0x189A0E600")]
		public bool SetParent(RRObject parent, bool worldPositionStays = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E0D0", Offset = "0x9A0CAD0", VA = "0x189A0E0D0")]
		public bool BMKMWBHSQWR(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E850", Offset = "0x9A0D250", VA = "0x189A0E850")]
		public RRObject YFKQJSPYJJL(uint a)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E7C0", Offset = "0x9A0D1C0", VA = "0x189A0E7C0")]
		public RRObjectContainer UYXAWWDKTXF()
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectHierarchy(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C260", Offset = "0x9A0AC60", VA = "0x189A0C260")]
		public static implicit operator bool(RRObjectHierarchy value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E170", Offset = "0x9A0CB70", VA = "0x189A0E170", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectHierarchy other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public readonly struct RRObjectIdentity : IEquatable<RRObjectIdentity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public string WWQWFWDTAVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x9A0EF30", Offset = "0x9A0D930", VA = "0x189A0EF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		public string YWACWIHWNVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x9A0EB00", Offset = "0x9A0D500", VA = "0x189A0EB00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		public string VJJWYLFWBBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x9A0EA50", Offset = "0x9A0D450", VA = "0x189A0EA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		public string EXHFROYTKJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x9A0EBD0", Offset = "0x9A0D5D0", VA = "0x189A0EBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9A0EE70", Offset = "0x9A0D870", VA = "0x189A0EE70")]
		public bool JKOGTIEPBDN([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectIdentity(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9A0EB40", Offset = "0x9A0D540", VA = "0x189A0EB40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectIdentity other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public readonly struct RRObjectInternal : IEquatable<RRObjectInternal>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0EFC0", Offset = "0x9A0D9C0", VA = "0x189A0EFC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectInternal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public readonly struct RRObjectMagneticAnchor : IEquatable<RRObjectMagneticAnchor>
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[Flags]
		public enum ConnectResult
		{
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			SUCCESS = 0,
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			ANCHOR_A_INVALID = 1,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			ANCHOR_B_INVALID = 2,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			ANCHOR_A_ALREADY_CONNECTED = 4,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			ANCHOR_B_ALREADY_CONNECTED = 8
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static Log log;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly RRObjectMagneticAnchor Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		private HGLSGDPNMGD TKUBPHMBRZK
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x9A08100", Offset = "0x9A06B00", VA = "0x189A08100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		private EntityManager JEUBYQQEFWG
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x9A0F0E0", Offset = "0x9A0DAE0", VA = "0x189A0F0E0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x9A10140", Offset = "0x9A0EB40", VA = "0x189A10140")]
		public float TZFMLWDVFMI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x9A0FF80", Offset = "0x9A0E980", VA = "0x189A0FF80")]
		public void QNLSZEBJMOM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9A0FD00", Offset = "0x9A0E700", VA = "0x189A0FD00")]
		public static ConnectResult NWKUDZDZELB(RRObjectMagneticAnchor a, RRObjectMagneticAnchor b)
		{
			return default(ConnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9A0F740", Offset = "0x9A0E140", VA = "0x189A0F740")]
		public bool NGGIZWAXRSU([Out] GameObject a, [Out] GameObject b, [Out] RRObject c, [Out] RRObject d, [Out] Vector3 e, [Out] Vector3 f, [Out] Vector3 g, [Out] RRObject h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9A0F110", Offset = "0x9A0DB10", VA = "0x189A0F110")]
		public bool ITGHTRNUZWU([Out] GameObject a, [Out] GameObject b, [Out] RRObject c, [Out] RRObject d, [Out] Vector3 e, [Out] Vector3 f, [Out] Vector3 g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9A0F380", Offset = "0x9A0DD80", VA = "0x189A0F380")]
		private void JAOEJQBFMRB(Entity a, EntityManager b, MagneticAnchorData c, [Out] GameObject d, [Out] GameObject e, [Out] RRObject f, [Out] RRObject g, [Out] Vector3 h, [Out] Vector3 i, [Out] Vector3 j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectMagneticAnchor(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x9A0F050", Offset = "0x9A0DA50", VA = "0x189A0F050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectMagneticAnchor other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x9A10190", Offset = "0x9A0EB90", VA = "0x189A10190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct RRObjectNetworkComponents : IEquatable<RRObjectNetworkComponents>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x9A10290", Offset = "0x9A0EC90", VA = "0x189A10290", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectNetworkComponents other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct RRObjectObjectInteractionFilter : IEquatable<RRObjectObjectInteractionFilter>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		private KLGCXGVNECR BVOZXUGXNCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x9A10640", Offset = "0x9A0F040", VA = "0x189A10640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public InteractionFilterMode GJZIEZBJWHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x9A108D0", Offset = "0x9A0F2D0", VA = "0x189A108D0")]
			get
			{
				return default(InteractionFilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x9A10320", Offset = "0x9A0ED20", VA = "0x189A10320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		public RentedArray<string> GNJAHYUQIBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x9A106A0", Offset = "0x9A0F0A0", VA = "0x189A106A0")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9A10520", Offset = "0x9A0EF20", VA = "0x189A10520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		public RentedArray<string> QARJJPYPYFH
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x9A10400", Offset = "0x9A0EE00", VA = "0x189A10400")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x9A107B0", Offset = "0x9A0F1B0", VA = "0x189A107B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectObjectInteractionFilter(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x9A10370", Offset = "0x9A0ED70", VA = "0x189A10370", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectObjectInteractionFilter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public readonly struct RRObjectPhysics : IEquatable<RRObjectPhysics>
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly ComponentTypeSet RequiredComponents;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly RRObjectPhysics Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		public Collider NIFPYPZWMVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x9A11710", Offset = "0x9A10110", VA = "0x189A11710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public CollisionLayerEnum JCQNKJVRVCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x9A11170", Offset = "0x9A0FB70", VA = "0x189A11170")]
			get
			{
				return default(CollisionLayerEnum);
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x9A10E70", Offset = "0x9A0F870", VA = "0x189A10E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public CollisionMode TIBJPOJJPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x9A11250", Offset = "0x9A0FC50", VA = "0x189A11250")]
			get
			{
				return default(CollisionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x9A110A0", Offset = "0x9A0FAA0", VA = "0x189A110A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public GrabbableMode YUEFJPLIXJR
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x9A11330", Offset = "0x9A0FD30", VA = "0x189A11330")]
			get
			{
				return default(GrabbableMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x9A11370", Offset = "0x9A0FD70", VA = "0x189A11370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public float DBBPHJDGPZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x9A10970", Offset = "0x9A0F370", VA = "0x189A10970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x9A10BD0", Offset = "0x9A0F5D0", VA = "0x189A10BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public bool OIBRTMINBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x9A109B0", Offset = "0x9A0F3B0", VA = "0x189A109B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x9A10A20", Offset = "0x9A0F420", VA = "0x189A10A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public bool DWZKENAJXSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x9A11020", Offset = "0x9A0FA20", VA = "0x189A11020")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x9A11290", Offset = "0x9A0FC90", VA = "0x189A11290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public bool OEUXXLQMPZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x9A110F0", Offset = "0x9A0FAF0", VA = "0x189A110F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x9A113C0", Offset = "0x9A0FDC0", VA = "0x189A113C0")]
		public static bool TYPNSNXWYML(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x9A10C20", Offset = "0x9A0F620", VA = "0x189A10C20")]
		public static bool GWKJHKBBVLF(RRObject a, [Out] RRObjectPhysics b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x9A10EC0", Offset = "0x9A0F8C0", VA = "0x189A10EC0")]
		public bool JSVGKHMRGJC([Out] YVDKQKBSXKR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x9A11620", Offset = "0x9A10020", VA = "0x189A11620")]
		public bool XORJGYFGUBP([Out] ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x9A10910", Offset = "0x9A0F310", VA = "0x189A10910")]
		public bool AGCSJYMABVG(PhysicsModelEnumFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x9A10B50", Offset = "0x9A0F550", VA = "0x189A10B50")]
		public void FDOTQFXOMPO(PhysicsModelEnumFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9A111B0", Offset = "0x9A0FBB0", VA = "0x189A111B0")]
		public void NPNWVJZLZRZ(PhysicsModelEnumFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectPhysics(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x9A10AC0", Offset = "0x9A0F4C0", VA = "0x189A10AC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectPhysics other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x9A115C0", Offset = "0x9A0FFC0", VA = "0x189A115C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public readonly struct RRObjectPlayer : IEquatable<RRObjectPlayer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public bool NATPCQLEIDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x9A12A80", Offset = "0x9A11480", VA = "0x189A12A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectPlayer(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x9A129F0", Offset = "0x9A113F0", VA = "0x189A129F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectPlayer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public readonly struct RRObjectPlayerInteraction : IEquatable<RRObjectPlayerInteraction>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		private SEEJQVFMKNL SGIMRLSWDMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x9A12990", Offset = "0x9A11390", VA = "0x189A12990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x9A128A0", Offset = "0x9A112A0", VA = "0x189A128A0")]
		public void PMQRLEWNKCP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectPlayerInteraction(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x9A12810", Offset = "0x9A11210", VA = "0x189A12810", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectPlayerInteraction other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public readonly struct RRObjectPlayerInteractionFilter : IEquatable<RRObjectPlayerInteractionFilter>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		private MNUBFSAMNAX AKQGVZANJQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x9A12170", Offset = "0x9A10B70", VA = "0x189A12170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public InteractionFilterMode YYIIDAMQQXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x9A12070", Offset = "0x9A10A70", VA = "0x189A12070")]
			get
			{
				return default(InteractionFilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x9A12700", Offset = "0x9A11100", VA = "0x189A12700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public bool YNANCPNRPRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x9A12670", Offset = "0x9A11070", VA = "0x189A12670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x9A12410", Offset = "0x9A10E10", VA = "0x189A12410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public RentedArray<string> DRUILQCQUYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x9A11B60", Offset = "0x9A10560", VA = "0x189A11B60")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x9A11A40", Offset = "0x9A10440", VA = "0x189A11A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public RentedArray<string> TIYQQTWEAUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x9A121D0", Offset = "0x9A10BD0", VA = "0x189A121D0")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x9A12550", Offset = "0x9A10F50", VA = "0x189A12550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public RentedArray<string> HAXVHFKIHNB
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x9A11C80", Offset = "0x9A10680", VA = "0x189A11C80")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x9A11F50", Offset = "0x9A10950", VA = "0x189A11F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public RentedArray<string> POOPHDLKADP
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x9A122F0", Offset = "0x9A10CF0", VA = "0x189A122F0")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x9A11DA0", Offset = "0x9A107A0", VA = "0x189A11DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x9A124B0", Offset = "0x9A10EB0", VA = "0x189A124B0")]
		public bool WHSNLLMKVRH(ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectPlayerInteractionFilter(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0")]
		public static implicit operator ObjectLocalId(RRObjectPlayerInteractionFilter value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x9A11EC0", Offset = "0x9A108C0", VA = "0x189A11EC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectPlayerInteractionFilter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public readonly struct RRObjectPolicy : IEquatable<RRObjectPolicy>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public bool YUWAJFKTDIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x9A12C90", Offset = "0x9A11690", VA = "0x189A12C90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public bool EMLPIPTJYUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x9A137D0", Offset = "0x9A121D0", VA = "0x189A137D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public bool LHLAOTCLMKY
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x9A139C0", Offset = "0x9A123C0", VA = "0x189A139C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x9A13480", Offset = "0x9A11E80", VA = "0x189A13480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool PDBLYZWZPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x9A12BB0", Offset = "0x9A115B0", VA = "0x189A12BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool ZYDWQRWYRVX
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x9A13010", Offset = "0x9A11A10", VA = "0x189A13010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public bool DIUWDGAIGXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x9A13340", Offset = "0x9A11D40", VA = "0x189A13340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool GGZQONBEMVW
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x9A13970", Offset = "0x9A12370", VA = "0x189A13970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool YPFTRZVXBQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x9A132A0", Offset = "0x9A11CA0", VA = "0x189A132A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public bool LNQHUMZTMSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x9A133E0", Offset = "0x9A11DE0", VA = "0x189A133E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public bool IAIASTTADUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x9A132F0", Offset = "0x9A11CF0", VA = "0x189A132F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		public bool PCLXSSKVKIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x9A12B60", Offset = "0x9A11560", VA = "0x189A12B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public bool QIFTQYDSMBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x9A12EE0", Offset = "0x9A118E0", VA = "0x189A12EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool YQZIMQLLXPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x9A13430", Offset = "0x9A11E30", VA = "0x189A13430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		public bool GQCIXCIWJFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x9A12C00", Offset = "0x9A11600", VA = "0x189A12C00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x9A134A0", Offset = "0x9A11EA0", VA = "0x189A134A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public bool HVQUDWDBEQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x9A13920", Offset = "0x9A12320", VA = "0x189A13920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public NavMeshGenerationMode VPXDUZMDDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x9A12F30", Offset = "0x9A11930", VA = "0x189A12F30")]
			get
			{
				return default(NavMeshGenerationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x9A13250", Offset = "0x9A11C50", VA = "0x189A13250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public bool OJFMAGNRABO
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x9A13060", Offset = "0x9A11A60", VA = "0x189A13060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public CircuitsTransformBehavior TOBRTVTGRPA
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x9A13180", Offset = "0x9A11B80", VA = "0x189A13180")]
			get
			{
				return default(CircuitsTransformBehavior);
			}
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x9A12C40", Offset = "0x9A11640", VA = "0x189A12C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public bool VLCNQWSYILK
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x9A12AD0", Offset = "0x9A114D0", VA = "0x189A12AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		public Vector3 DPHVITQPMJD
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x9A12DE0", Offset = "0x9A117E0", VA = "0x189A12DE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		public Vector3 NFFOVSDJMNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x9A12D60", Offset = "0x9A11760", VA = "0x189A12D60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public bool MMBBDBITUPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x9A13500", Offset = "0x9A11F00", VA = "0x189A13500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		public bool KROZYHGLGAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x9A13820", Offset = "0x9A12220", VA = "0x189A13820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		private EntityManager JEUBYQQEFWG
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x9A0F0E0", Offset = "0x9A0DAE0", VA = "0x189A0F0E0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x9A12FB0", Offset = "0x9A119B0", VA = "0x189A12FB0")]
		public bool NZOMUEJVSYE(ObjectPolicyEnum a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x9A131C0", Offset = "0x9A11BC0", VA = "0x189A131C0")]
		public void OPPYCGTWSRG(ObjectPolicyEnum a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x9A12B10", Offset = "0x9A11510", VA = "0x189A12B10")]
		public bool BJXRROBLDZE(ObjectPolicyUserConfigurableFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x9A12E60", Offset = "0x9A11860", VA = "0x189A12E60")]
		public void KGPYFIUCJYK(ObjectPolicyUserConfigurableFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x9A12F70", Offset = "0x9A11970", VA = "0x189A12F70")]
		public ObjectPolicyUserConfigurableFlags NYJGNWNKNFN()
		{
			return default(ObjectPolicyUserConfigurableFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x9A13390", Offset = "0x9A11D90", VA = "0x189A13390")]
		public bool RVIKYZGNCFV(ObjectPolicyUserConfigurableFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectPolicy(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x9A12CD0", Offset = "0x9A116D0", VA = "0x189A12CD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectPolicy other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public readonly struct RRObjectReferenceGroup : IEquatable<RRObjectReferenceGroup>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		private WPADDSJKNYW QDHXSUBOZYP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x9A13D10", Offset = "0x9A12710", VA = "0x189A13D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x9A13FB0", Offset = "0x9A129B0", VA = "0x189A13FB0")]
		public bool PSSVXDCJMQT(ReferenceGroupKind a, List<RRObject> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x9A13D70", Offset = "0x9A12770", VA = "0x189A13D70")]
		public int IHQAWYNXDKK(ReferenceGroupKind a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x9A14340", Offset = "0x9A12D40", VA = "0x189A14340")]
		public void WIUTRFUYMLU(List<RRObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x9A13E80", Offset = "0x9A12880", VA = "0x189A13E80")]
		public int JZUFNJECDTX(RRObject a, ReferenceGroupKind b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x9A140E0", Offset = "0x9A12AE0", VA = "0x189A140E0")]
		public RRObject VJEJMQGHVES(int a, ReferenceGroupKind b)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x9A14210", Offset = "0x9A12C10", VA = "0x189A14210")]
		public void WHIXOODUHLD(RRObject a, ReferenceGroupKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x9A13BB0", Offset = "0x9A125B0", VA = "0x189A13BB0")]
		public bool GKTMBQLCCIX(RRObject a, ReferenceGroupKind b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x9A13A10", Offset = "0x9A12410", VA = "0x189A13A10")]
		public void EHRIKCCSVGE(ReferenceGroupKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x9A13C60", Offset = "0x9A12660", VA = "0x189A13C60")]
		public bool GPRZJYBVAIK(RRObject a, ReferenceGroupKind b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x9A14450", Offset = "0x9A12E50", VA = "0x189A14450")]
		public bool ZOLXNIFNBXM(ReferenceGroupKind a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectReferenceGroup(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x9A13B20", Offset = "0x9A12520", VA = "0x189A13B20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectReferenceGroup other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public readonly struct RRObjectRenderEffects : IEquatable<RRObjectRenderEffects>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x9A145F0", Offset = "0x9A12FF0", VA = "0x189A145F0")]
		public void FPEEAVMOSUF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x9A14680", Offset = "0x9A13080", VA = "0x189A14680")]
		public void MQGGOZNJAUP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1700", Offset = "0x3ED0100", VA = "0x183ED1700")]
		public a CEFERTLORER<a>() where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectRenderEffects(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x9A14560", Offset = "0x9A12F60", VA = "0x189A14560", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectRenderEffects other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public readonly struct RRObjectReplicatedObject : IEquatable<RRObjectReplicatedObject>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public bool CDLQWHJBDXY
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x9A14940", Offset = "0x9A13340", VA = "0x189A14940")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x9A14860", Offset = "0x9A13260", VA = "0x189A14860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		public bool GKLSACAUSNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x9A147A0", Offset = "0x9A131A0", VA = "0x189A147A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		public int PMFIAEUDIWU
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x9A14820", Offset = "0x9A13220", VA = "0x189A14820")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x9A148B0", Offset = "0x9A132B0", VA = "0x189A148B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectReplicatedObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x9A14710", Offset = "0x9A13110", VA = "0x189A14710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectReplicatedObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public readonly struct RRObjectReplicator : IEquatable<RRObjectReplicator>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public int ZZMZTQOEEYX
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x9A14980", Offset = "0x9A13380", VA = "0x189A14980")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x9A14AF0", Offset = "0x9A134F0", VA = "0x189A14AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public int VKIRUDWANRB
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x9A14B40", Offset = "0x9A13540", VA = "0x189A14B40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x9A14A50", Offset = "0x9A13450", VA = "0x189A14A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public uint TRCTUIKQVCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x9A14B80", Offset = "0x9A13580", VA = "0x189A14B80")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x9A14AA0", Offset = "0x9A134A0", VA = "0x189A14AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectReplicator(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9A149C0", Offset = "0x9A133C0", VA = "0x189A149C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectReplicator other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public readonly struct RRObjectScope : IEquatable<RRObjectScope>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		private OFBOIOQEYYF QUSKILIWPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x9A156B0", Offset = "0x9A140B0", VA = "0x189A156B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		private CSZIKKFPQMN QBOCNNJRBYH
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x9A15020", Offset = "0x9A13A20", VA = "0x189A15020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public bool TDIMDNBXZDX
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x9A15620", Offset = "0x9A14020", VA = "0x189A15620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public bool BVVNRWFWIEY
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x9A15580", Offset = "0x9A13F80", VA = "0x189A15580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public bool UHWFBEUCLDL
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x9A14FF0", Offset = "0x9A139F0", VA = "0x189A14FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public bool FLGJGITUOOB
		{
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x9A15230", Offset = "0x9A13C30", VA = "0x189A15230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public bool OICMOGSHJMD
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x9A15300", Offset = "0x9A13D00", VA = "0x189A15300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public bool LHZNWRWSURC
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x9A14F60", Offset = "0x9A13960", VA = "0x189A14F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public bool BFUWNNAOCSK
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x9A15330", Offset = "0x9A13D30", VA = "0x189A15330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public bool BDLEDFTFTOZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x9A14DF0", Offset = "0x9A137F0", VA = "0x189A14DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public bool ZHZTZWVLDAK
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x9A14BC0", Offset = "0x9A135C0", VA = "0x189A14BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x9A14CF0", Offset = "0x9A136F0", VA = "0x189A14CF0")]
		public bool CYFOHBSAZLF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x9A15190", Offset = "0x9A13B90", VA = "0x189A15190")]
		public RRObject MPREMBBBAYT(RRObject a)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x9A15080", Offset = "0x9A13A80", VA = "0x189A15080")]
		public ObjectLocalId MNYXYXCTPBP()
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x9A154D0", Offset = "0x9A13ED0", VA = "0x189A154D0")]
		public bool RUYOLPRRADH(ObjectLocalId a, [Out] ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectScope(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C260", Offset = "0x9A0AC60", VA = "0x189A0C260")]
		public static implicit operator bool(RRObjectScope value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x9A14D60", Offset = "0x9A13760", VA = "0x189A14D60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectScope other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public readonly struct RRObjectShape : IEquatable<RRObjectShape>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly RRObjectShape Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public EShapeType ZKCHRVVXIRP
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x9A16880", Offset = "0x9A15280", VA = "0x189A16880")]
			get
			{
				return default(EShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public RenderableColor SEPYTNPFUCP
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x9A16670", Offset = "0x9A15070", VA = "0x189A16670")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x9A166B0", Offset = "0x9A150B0", VA = "0x189A166B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public RenderableMaterial DMNWOMXIVEB
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x9A16420", Offset = "0x9A14E20", VA = "0x189A16420")]
			get
			{
				return default(RenderableMaterial);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x9A16780", Offset = "0x9A15180", VA = "0x189A16780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public float NEZAQXRHPED
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x9A168C0", Offset = "0x9A152C0", VA = "0x189A168C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x9A16460", Offset = "0x9A14E60", VA = "0x189A16460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public Vector3 OUVYZJQDQBC
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x9A16A10", Offset = "0x9A15410", VA = "0x189A16A10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x9A16700", Offset = "0x9A15100", VA = "0x189A16700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public float QKOZPLDHNVO
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x9A16500", Offset = "0x9A14F00", VA = "0x189A16500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public ShapeConfigFlags ADXQLHXVAYV
		{
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x9A165A0", Offset = "0x9A14FA0", VA = "0x189A165A0")]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x9A16830", Offset = "0x9A15230", VA = "0x189A16830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public bool ZYNYZUKHJJB
		{
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x9A16900", Offset = "0x9A15300", VA = "0x189A16900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x9A167D0", Offset = "0x9A151D0", VA = "0x189A167D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public RRObjectTransform QSGLKOZVOYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public RRObjectHierarchy ELOFUECFTHN
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x9A16940", Offset = "0x9A15340", VA = "0x189A16940")]
		public RRObjectShapePrimitive UYNWBSQSTDT()
		{
			return default(RRObjectShapePrimitive);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x9A164B0", Offset = "0x9A14EB0", VA = "0x189A164B0")]
		public RRObjectShapeSpline BXPWCPJXYVT()
		{
			return default(RRObjectShapeSpline);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x9A16550", Offset = "0x9A14F50", VA = "0x189A16550")]
		private bool CSFXBQVBCDX(ShapeConfigFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x9A16990", Offset = "0x9A15390", VA = "0x189A16990")]
		public void WUOUXNQFXGW(ShapeConfigFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectShape(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C260", Offset = "0x9A0AC60", VA = "0x189A0C260")]
		public static implicit operator bool(RRObjectShape value)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x9A08470", Offset = "0x9A06E70", VA = "0x189A08470")]
		public static bool JSGIPYLAFHN(RRObjectShape a, RRObjectShape b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x9A165E0", Offset = "0x9A14FE0", VA = "0x189A165E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectShape other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public readonly struct RRObjectShapePrimitive : IEquatable<RRObjectShapePrimitive>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public RRObjectShape MMARXKFLOFX
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectShape);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public PrimitiveShapeType MRQCUKKDQBD
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x9A157A0", Offset = "0x9A141A0", VA = "0x189A157A0")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectShapePrimitive(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C260", Offset = "0x9A0AC60", VA = "0x189A0C260")]
		public static implicit operator bool(RRObjectShapePrimitive value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x9A15710", Offset = "0x9A14110", VA = "0x189A15710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectShapePrimitive other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public readonly struct RRObjectShapeSpline : IEquatable<RRObjectShapeSpline>
	{
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly RRObjectShapeSpline Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		private WXWCHJUHGCZ ICHUJIYNFAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x9A162B0", Offset = "0x9A14CB0", VA = "0x189A162B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public RRObjectShape MMARXKFLOFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectShape);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public SplineParameters ZGQHJCVXKPL
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x9A16100", Offset = "0x9A14B00", VA = "0x189A16100")]
			get
			{
				return default(SplineParameters);
			}
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x9A15FE0", Offset = "0x9A149E0", VA = "0x189A15FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public IEnumerable<RRObjectSplinePoint> EMNMMPAXAJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0x9A159A0", Offset = "0x9A143A0", VA = "0x189A159A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public RRObjectSplinePoint this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x9A16310", Offset = "0x9A14D10", VA = "0x189A16310")]
			get
			{
				return default(RRObjectSplinePoint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public int KQOHZIVUHAP
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x9A16220", Offset = "0x9A14C20", VA = "0x189A16220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public RRObjectTransform QSGLKOZVOYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x9A15B90", Offset = "0x9A14590", VA = "0x189A15B90")]
		public RRObjectSplinePoint HSHRCEPTJZO(float3? a, [Optional] quaternion? b, [Optional] Vector3? c)
		{
			return default(RRObjectSplinePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x9A15DB0", Offset = "0x9A147B0", VA = "0x189A15DB0")]
		public RRObjectSplinePoint Insert(int index, float3? position, [Optional] quaternion? rotation, [Optional] Vector3? scale)
		{
			return default(RRObjectSplinePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x9A157E0", Offset = "0x9A141E0", VA = "0x189A157E0")]
		public void BLPASJBTPOR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x9A15880", Offset = "0x9A14280", VA = "0x189A15880")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectShapeSpline(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C260", Offset = "0x9A0AC60", VA = "0x189A0C260")]
		public static implicit operator bool(RRObjectShapeSpline value)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D550", Offset = "0x9A0BF50", VA = "0x189A0D550")]
		public static bool OTUOIXXRZSY(RRObjectShapeSpline a, RRObjectShapeSpline b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x9A15910", Offset = "0x9A14310", VA = "0x189A15910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectShapeSpline other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public readonly struct RRObjectSplinePoint : IEquatable<RRObjectSplinePoint>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public RRObjectShapeSpline KWJHMOIBSWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x9A16D20", Offset = "0x9A15720", VA = "0x189A16D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public float3 OYWTYXOICNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x9A16BB0", Offset = "0x9A155B0", VA = "0x189A16BB0")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x9A16C10", Offset = "0x9A15610", VA = "0x189A16C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public quaternion SILHDFYWFMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x9A16DA0", Offset = "0x9A157A0", VA = "0x189A16DA0")]
			get
			{
				return default(quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x9A16AD0", Offset = "0x9A154D0", VA = "0x189A16AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public float3 AQJHARNXCDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x9A16E00", Offset = "0x9A15800", VA = "0x189A16E00")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x9A16C70", Offset = "0x9A15670", VA = "0x189A16C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public FractionalIndex BRYTFKXJLZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x9A16A90", Offset = "0x9A15490", VA = "0x189A16A90")]
			get
			{
				return default(FractionalIndex);
			}
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x9A16CD0", Offset = "0x9A156D0", VA = "0x189A16CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x9A16DF0", Offset = "0x9A157F0", VA = "0x189A16DF0")]
		public void XXUWMUKVYQN(RRObjectShapeSpline a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectSplinePoint(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x9A16B20", Offset = "0x9A15520", VA = "0x189A16B20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectSplinePoint other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public readonly struct RRObjectStudioObject : IEquatable<RRObjectStudioObject>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public bool NDVPCOVPKDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x9A16EF0", Offset = "0x9A158F0", VA = "0x189A16EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectStudioObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x9A16E60", Offset = "0x9A15860", VA = "0x189A16E60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectStudioObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public readonly struct RRObjectTerrain : IEquatable<RRObjectTerrain>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly RRObjectTerrain Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		private FXLUUMPLGOH LMZRRPRAPGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x9A17A90", Offset = "0x9A16490", VA = "0x189A17A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public uint WHMWHUHHIBP
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x9A175C0", Offset = "0x9A15FC0", VA = "0x189A175C0")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0x9A174E0", Offset = "0x9A15EE0", VA = "0x189A174E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public TerrainLayerRoughness YCNXNKQHDNC
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x9A17580", Offset = "0x9A15F80", VA = "0x189A17580")]
			get
			{
				return default(TerrainLayerRoughness);
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x9A17920", Offset = "0x9A16320", VA = "0x189A17920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public float YLJAEUBFELA
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x9A179B0", Offset = "0x9A163B0", VA = "0x189A179B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x9A17490", Offset = "0x9A15E90", VA = "0x189A17490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public float FETZIYMSWIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x9A17640", Offset = "0x9A16040", VA = "0x189A17640")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x9A17AF0", Offset = "0x9A164F0", VA = "0x189A17AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public TerrainPlayAreaShape TFOGOBOTNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x9A17600", Offset = "0x9A16000", VA = "0x189A17600")]
			get
			{
				return default(TerrainPlayAreaShape);
			}
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x9A17030", Offset = "0x9A15A30", VA = "0x189A17030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public float ZZSPJSGKTIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x9A17100", Offset = "0x9A15B00", VA = "0x189A17100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x9A16FE0", Offset = "0x9A159E0", VA = "0x189A16FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public float EZJEAQVROFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x9A17530", Offset = "0x9A15F30", VA = "0x189A17530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public float HTUHCJZERMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x9A17080", Offset = "0x9A15A80", VA = "0x189A17080")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public float OUHRKNGPIRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x9A176C0", Offset = "0x9A160C0", VA = "0x189A176C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x9A17A40", Offset = "0x9A16440", VA = "0x189A17A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public RenderableColor VMPKGEWUNXI
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x9A16FA0", Offset = "0x9A159A0", VA = "0x189A16FA0")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x9A173F0", Offset = "0x9A15DF0", VA = "0x189A173F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public RenderableColor XMTAXLYWXUM
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x9A17970", Offset = "0x9A16370", VA = "0x189A17970")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x9A173A0", Offset = "0x9A15DA0", VA = "0x189A173A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public float OXJGACWTAAR
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x9A16F60", Offset = "0x9A15960", VA = "0x189A16F60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x9A179F0", Offset = "0x9A163F0", VA = "0x189A179F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public TerrainWaterMaterial UPEPREQLERI
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x9A170C0", Offset = "0x9A15AC0", VA = "0x189A170C0")]
			get
			{
				return default(TerrainWaterMaterial);
			}
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x9A17440", Offset = "0x9A15E40", VA = "0x189A17440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public WaterOverrides TZGHYKBKLLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x9A17680", Offset = "0x9A16080", VA = "0x189A17680")]
			get
			{
				return default(WaterOverrides);
			}
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x9A17810", Offset = "0x9A16210", VA = "0x189A17810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public ReadOnlySpan<TerrainGenerationLayer> CSRHWEGYYCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x9A172E0", Offset = "0x9A15CE0", VA = "0x189A172E0")]
			get
			{
				return default(ReadOnlySpan<TerrainGenerationLayer>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x9A17700", Offset = "0x9A16100", VA = "0x189A17700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public ReadOnlySpan<TerrainCustomMaterialLayer> BQTUZCMRCXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x9A17860", Offset = "0x9A16260", VA = "0x189A17860")]
			get
			{
				return default(ReadOnlySpan<TerrainCustomMaterialLayer>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x9A171D0", Offset = "0x9A15BD0", VA = "0x189A171D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectTerrain(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0")]
		public static implicit operator ObjectLocalId(RRObjectTerrain value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x9A17140", Offset = "0x9A15B40", VA = "0x189A17140", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectTerrain other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public readonly struct RRObjectToolCleanup : IEquatable<RRObjectToolCleanup>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		private JFATBHNVEZY ZPLLRWBYSUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x9A18220", Offset = "0x9A16C20", VA = "0x189A18220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public bool WRKVOOFGRFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x9A181D0", Offset = "0x9A16BD0", VA = "0x189A181D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x9A18060", Offset = "0x9A16A60", VA = "0x189A18060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public bool BYBYZVRJLUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x9A17D10", Offset = "0x9A16710", VA = "0x189A17D10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x9A17E00", Offset = "0x9A16800", VA = "0x189A17E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public float OEGUXXSZVEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x9A17E60", Offset = "0x9A16860", VA = "0x189A17E60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x9A18620", Offset = "0x9A17020", VA = "0x189A18620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public bool VFHATAVNTKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x9A185D0", Offset = "0x9A16FD0", VA = "0x189A185D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x9A18670", Offset = "0x9A17070", VA = "0x189A18670")]
		public void ZGAGHIXHLHR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x9A180C0", Offset = "0x9A16AC0", VA = "0x189A180C0")]
		public bool LSWUGSIUJEO([Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x9A17D60", Offset = "0x9A16760", VA = "0x189A17D60")]
		public void ForceCleanup(bool forceImmediate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x9A18280", Offset = "0x9A16C80", VA = "0x189A18280")]
		public bool QQATOJJAZGA(ToolCleanupFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x9A18550", Offset = "0x9A16F50", VA = "0x189A18550")]
		public void TREMARWQWOB(ToolCleanupFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x9A17B40", Offset = "0x9A16540", VA = "0x189A17B40")]
		public void EENNHECSRPA(float a, float b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x9A182D0", Offset = "0x9A16CD0", VA = "0x189A182D0")]
		public void SLHMRMFSSLP(float3 a, quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x9A18420", Offset = "0x9A16E20", VA = "0x189A18420")]
		public bool SVXDUYQRNQM([Out] float3 a, [Out] quaternion b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x9A17EA0", Offset = "0x9A168A0", VA = "0x189A17EA0")]
		public bool KWASSRGVJPY([Out] float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x9A17FD0", Offset = "0x9A169D0", VA = "0x189A17FD0")]
		public void LIQYPVDURER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectToolCleanup(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x9A17C80", Offset = "0x9A16680", VA = "0x189A17C80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectToolCleanup other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public readonly struct RRObjectTransform : IEquatable<RRObjectTransform>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		private JBWPPFUIGUI EFYTWSXHUFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x9A19820", Offset = "0x9A18220", VA = "0x189A19820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public Vector3 OYWTYXOICNS
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x9A19380", Offset = "0x9A17D80", VA = "0x189A19380")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x9A19660", Offset = "0x9A18060", VA = "0x189A19660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public Quaternion SILHDFYWFMV
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x9A1A240", Offset = "0x9A18C40", VA = "0x189A1A240")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x9A18AF0", Offset = "0x9A174F0", VA = "0x189A18AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public Vector3 KTLLGOTLHUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x9A1A4C0", Offset = "0x9A18EC0", VA = "0x189A1A4C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x9A1A170", Offset = "0x9A18B70", VA = "0x189A1A170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public Quaternion GRORAHEHWTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x9A19520", Offset = "0x9A17F20", VA = "0x189A19520")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x9A18A20", Offset = "0x9A17420", VA = "0x189A18A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public float BHARUBFJFYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x9A18EC0", Offset = "0x9A178C0", VA = "0x189A18EC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x9A19B50", Offset = "0x9A18550", VA = "0x189A19B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public float YRCLGCUIWQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0x9A1A030", Offset = "0x9A18A30", VA = "0x189A1A030")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public Matrix4x4 WJINSIXLOCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0x9A1A6A0", Offset = "0x9A190A0", VA = "0x189A1A6A0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public RRObjectHierarchy ELOFUECFTHN
		{
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		private HGLSGDPNMGD TKUBPHMBRZK
		{
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x9A08100", Offset = "0x9A06B00", VA = "0x189A08100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x9A194D0", Offset = "0x9A17ED0", VA = "0x189A194D0")]
		public RRTransform KFYTCETMWSA()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x9A18910", Offset = "0x9A17310", VA = "0x189A18910")]
		public void DWYGAYSHXXA([Out] Matrix4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x9A18D10", Offset = "0x9A17710", VA = "0x189A18D10")]
		public void FBDWHUGOPFI([In] Vector3 localPosition, [In] Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x9A18C50", Offset = "0x9A17650", VA = "0x189A18C50")]
		public void FBDWHUGOPFI([In] RigidTransform parentFromLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x9A19AA0", Offset = "0x9A184A0", VA = "0x189A19AA0")]
		public void PSPVEYGGUNY([Out] RigidTransform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x9A199A0", Offset = "0x9A183A0", VA = "0x189A199A0")]
		public void PNOQRNMPMLP([In] Vector3 worldPosition, [In] Quaternion worldRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x9A198E0", Offset = "0x9A182E0", VA = "0x189A198E0")]
		public void PNOQRNMPMLP([In] RigidTransform worldFromLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x9A192A0", Offset = "0x9A17CA0", VA = "0x189A192A0")]
		public void JIITRGRYLQV([Out] Vector3 a, [Out] Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A191F0", Offset = "0x9A17BF0", VA = "0x189A191F0")]
		public void JIITRGRYLQV([Out] RigidTransform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x9A197F0", Offset = "0x9A181F0", VA = "0x189A197F0")]
		public UniformTRS NVLKYKHYPLF()
		{
			return default(UniformTRS);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x9A19730", Offset = "0x9A18130", VA = "0x189A19730")]
		public void NVLKYKHYPLF([Out] UniformTRS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x9A19C00", Offset = "0x9A18600", VA = "0x189A19C00")]
		public UniformTRS RUJMITCCMJA()
		{
			return default(UniformTRS);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x9A19C30", Offset = "0x9A18630", VA = "0x189A19C30")]
		public void RUJMITCCMJA([Out] UniformTRS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x9A18F60", Offset = "0x9A17960", VA = "0x189A18F60")]
		public Vector3 HPPGHSPIXHW()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x9A19CF0", Offset = "0x9A186F0", VA = "0x189A19CF0")]
		public void SetLocalPosition([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x9A18710", Offset = "0x9A17110", VA = "0x189A18710")]
		public Vector3 AUIMQUFWNSP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x9A19E90", Offset = "0x9A18890", VA = "0x189A19E90")]
		public void SetWorldPosition([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A380", Offset = "0x9A18D80", VA = "0x189A1A380")]
		public Quaternion XVHCUHLEFFP()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x9A19DC0", Offset = "0x9A187C0", VA = "0x189A19DC0")]
		public void SetLocalRotation([In] Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x9A190B0", Offset = "0x9A17AB0", VA = "0x189A190B0")]
		public Quaternion IZXTQOKXPDA()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x9A19F60", Offset = "0x9A18960", VA = "0x189A19F60")]
		public void SetWorldRotation([In] Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A0D0", Offset = "0x9A18AD0", VA = "0x189A1A0D0")]
		public float UNDRNOLGIGV()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x9A18E10", Offset = "0x9A17810", VA = "0x189A18E10")]
		public void HLPOFDITTGF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A6E0", Offset = "0x9A190E0", VA = "0x189A1A6E0")]
		public float ZGITZTHVDAC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x9A18860", Offset = "0x9A17260", VA = "0x189A18860")]
		public void CIYLWIXSSJQ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A610", Offset = "0x9A19010", VA = "0x189A1A610")]
		public Vector3 YYQRCBRQAUN([In] Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectTransform(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x9A18BC0", Offset = "0x9A175C0", VA = "0x189A18BC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectTransform other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public readonly struct RRObjectUserTags : IEquatable<RRObjectUserTags>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		private KSRPNGZZEHB MXWLVMRCPAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x9A1A810", Offset = "0x9A19210", VA = "0x189A1A810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public RRObject RCALHTVDCWH
		{
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		private MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A340", Offset = "0x9A08D40", VA = "0x189A0A340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A870", Offset = "0x9A19270", VA = "0x189A1A870")]
		public void IBIRKHERLVB(string a, NativeObjectLocalIdList b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRObjectUserTags(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A780", Offset = "0x9A19180", VA = "0x189A1A780", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRObjectUserTags other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AAC0", Offset = "0x9A094C0", VA = "0x189A0AAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public readonly struct RRScene : IEquatable<RRScene>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public NetworkCreatorId VYKGGCXQKGF
		{
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x9A1CB90", Offset = "0x9A1B590", VA = "0x189A1CB90")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRScene(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x9A1CB00", Offset = "0x9A1B500", VA = "0x189A1CB00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRScene other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public readonly struct RRSceneEntityRemap : IEquatable<RRSceneEntityRemap>
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public struct RetainScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private ObjectLocalId localId;

			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x9A1CFF0", Offset = "0x9A1B9F0", VA = "0x189A1CFF0")]
			public RetainScope(ObjectLocalId localId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x9A1CF60", Offset = "0x9A1B960", VA = "0x189A1CF60", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x9A1BCB0", Offset = "0x9A1A6B0", VA = "0x189A1BCB0")]
		public RetainScope CXQSWZJTCPT()
		{
			return default(RetainScope);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x9A1BC30", Offset = "0x9A1A630", VA = "0x189A1BC30")]
		public EntityRemapArray BRRXBWKPWJM(Allocator a = Allocator.Temp)
		{
			return default(EntityRemapArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x9A1BE70", Offset = "0x9A1A870", VA = "0x189A1BE70")]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> EXMKNCWHWTA(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x9A1BB00", Offset = "0x9A1A500", VA = "0x189A1BB00")]
		public NativeArray<ObjectNetworkId> AFTIRBMNGUB(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<ObjectNetworkId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C290", Offset = "0x9A1AC90", VA = "0x189A1C290")]
		public NativeArray<ObjectNetworkId> QYZFXJFUDKE(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<ObjectNetworkId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C160", Offset = "0x9A1AB60", VA = "0x189A1C160")]
		public NativeObjectLocalIdArray NUJFZTHTBLI(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C030", Offset = "0x9A1AA30", VA = "0x189A1C030")]
		public NativeObjectLocalIdArray GEIGQFMUMCX(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x9A1BD40", Offset = "0x9A1A740", VA = "0x189A1BD40")]
		public NativeObjectLocalIdArray DAWKYAQFZMD(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRSceneEntityRemap(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x9A1BFA0", Offset = "0x9A1A9A0", VA = "0x189A1BFA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRSceneEntityRemap other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C3C0", Offset = "0x9A1ADC0", VA = "0x189A1C3C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct SceneLoadResultMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int objectCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int removeCount;
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public readonly struct RRSceneLoadOperation : IEquatable<RRSceneLoadOperation>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public RRSceneEntityRemap NXXBWEBUBWA
		{
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRSceneEntityRemap);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public RRSceneLoadResult QYXPWVJMNON
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRSceneLoadResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public RRScene NDFBKTYMQPW
		{
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRScene);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C750", Offset = "0x9A1B150", VA = "0x189A1C750")]
		public bool NJHKZSQGGAR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C7F0", Offset = "0x9A1B1F0", VA = "0x189A1C7F0")]
		public bool NKYYZHRMSNN([Out] Exception a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C960", Offset = "0x9A1B360", VA = "0x189A1C960")]
		public void XLLHVIKARQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRSceneLoadOperation(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0")]
		public static implicit operator ObjectLocalId(RRSceneLoadOperation value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C6C0", Offset = "0x9A1B0C0", VA = "0x189A1C6C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRSceneLoadOperation other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C3C0", Offset = "0x9A1ADC0", VA = "0x189A1C3C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public readonly struct RRSceneLoadOperationSubgraph : IDisposable, IEquatable<RRSceneLoadOperationSubgraph>
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public static readonly RRSceneLoadOperationSubgraph Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public RRSceneLoadOperation FBOUOXKOISZ
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRSceneLoadOperation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public RRSceneEntityRemap NXXBWEBUBWA
		{
			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(RRSceneEntityRemap);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x60004EB")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C540", Offset = "0x9A1AF40", VA = "0x189A1C540")]
		public void OKULMFFMSNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C3E0", Offset = "0x9A1ADE0", VA = "0x189A1C3E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRSceneLoadOperationSubgraph(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C4B0", Offset = "0x9A1AEB0", VA = "0x189A1C4B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "5")]
		public bool Equals(RRSceneLoadOperationSubgraph other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C5C0", Offset = "0x9A1AFC0", VA = "0x189A1C5C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public readonly struct RRSceneLoadResult : IEquatable<RRSceneLoadResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public bool QKUUZKHXELA
		{
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x9A1CA70", Offset = "0x9A1B470", VA = "0x189A1CA70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x13E9790", Offset = "0x13E8190", VA = "0x1813E9790")]
		public RRSceneLoadResult(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x9A083F0", Offset = "0x9A06DF0", VA = "0x189A083F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C9E0", Offset = "0x9A1B3E0", VA = "0x189A1C9E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x9A08250", Offset = "0x9A06C50", VA = "0x189A08250", Slot = "4")]
		public bool Equals(RRSceneLoadResult other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C3C0", Offset = "0x9A1ADC0", VA = "0x189A1C3C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public static class INQCHMDLIZM
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private struct EntityGuidInterop
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public Guid guid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public ObjectGuid objectGuid;
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct ObjectGuid
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public int value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public int creator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int magic;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int reserved;

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x9A07A40", Offset = "0x9A06440", VA = "0x189A07A40")]
			public bool QBZJNOKPAWR([Out] ObjectNetworkId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x9A07AE0", Offset = "0x9A064E0", VA = "0x189A07AE0")]
			public ObjectGuid(ObjectNetworkId networkId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x9A05540", Offset = "0x9A03F40", VA = "0x189A05540")]
		public static Guid TIWWBNWRZQY(this ObjectNetworkId a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x9A05520", Offset = "0x9A03F20", VA = "0x189A05520")]
		public static bool GGSPWUCHECS(this Guid a, [Out] ObjectNetworkId b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	internal static class BXGXKYMKHIY
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x9A03440", Offset = "0x9A01E40", VA = "0x189A03440")]
		public static MRGKOGFFBPH APQIWCRQTPI(this ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x9A03720", Offset = "0x9A02120", VA = "0x189A03720")]
		public static VRTQSTAVQZS World(this ObjectLocalId id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x9A03610", Offset = "0x9A02010", VA = "0x189A03610")]
		public static EntityManager JEUBYQQEFWG(this ObjectLocalId a)
		{
			return default(EntityManager);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x3726B40", Offset = "0x3725540", VA = "0x183726B40")]
		internal static bool ZQVBDUIXOQU<a>(this ObjectLocalId a, bool b) where a : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x9A034D0", Offset = "0x9A01ED0", VA = "0x189A034D0")]
		public static bool HIRSEZVZEKJ(this ObjectLocalId a, NetworkProperty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x3726030", Offset = "0x3724A30", VA = "0x183726030")]
		public static bool CBKPGXMKAPW<b>(this ObjectLocalId a) where b : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x3726C40", Offset = "0x3725640", VA = "0x183726C40")]
		public static bool ZZAKRXRCFQK<c>(this ObjectLocalId a) where c : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x37262B0", Offset = "0x3724CB0", VA = "0x1837262B0")]
		[MustUseRefValueWithoutStoring]
		internal static NativeArray<T> EEYCSLOZXRJ<T>(this ObjectLocalId a, Allocator b) where T : struct, IBufferElementData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x3725A30", Offset = "0x3724430", VA = "0x183725A30")]
		[MustUseRefValueWithoutStoring]
		public static T BOKRMIMRFAX<T>(this ObjectLocalId a) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x3725C20", Offset = "0x3724620", VA = "0x183725C20")]
		[MustUseRefValueWithoutStoring]
		public static d BTHAYOWFXNF<d>(this ObjectLocalId a) where d : struct, IComponentData
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x3726850", Offset = "0x3725250", VA = "0x183726850")]
		public static bool ORGVWVSXSPR<e>(this ObjectLocalId a, [Out] e b) where e : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x37266C0", Offset = "0x37250C0", VA = "0x1837266C0")]
		public static f IJAHRLZAOBM<f>(this ObjectLocalId a) where f : struct, IComponentData
		{
			return (f)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x37264B0", Offset = "0x3724EB0", VA = "0x1837264B0")]
		public static g FCYBDRQKLYH<g>(this ObjectLocalId a) where g : class, IComponentData
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	internal static class WFQOBYCCSQB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[DefaultMember("Item")]
	public struct EntityRemapArray : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private NativeObjectLocalIdArray src;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> srcToDst;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x802CA10", Offset = "0x802B410", VA = "0x18802CA10")]
		public EntityRemapArray(NativeObjectLocalIdArray src, NativeArray<EntityRemapUtility.EntityRemapInfo> srcToDst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x9A04440", Offset = "0x9A02E40", VA = "0x189A04440")]
		public LocalId DRPWYUNMYYR(LocalId a)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x9A04480", Offset = "0x9A02E80", VA = "0x189A04480")]
		public LocalId DRPWYUNMYYR(int a)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x9A044F0", Offset = "0x9A02EF0", VA = "0x189A044F0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface YHMFXWNXIXZ
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HRSTMQMXQAK(ObjectLocalId a, [Out] uint b);

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RIGCKBLQIAQ(ObjectLocalId a, [Out] uint b);

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JGBVCZVAKSV(ObjectLocalId a, uint b);

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XLJERYLZJCE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string MWOVDCDXCQQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CRULZHCSYWA(ObjectLocalId a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JKOGTIEPBDN(ObjectLocalId a, [Out] string b);

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void WNDMUMTGRQA(ObjectLocalId a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface HELIEAOPKLU
	{
		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		Guid JHSVSRNCVBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		Guid AWEQDABMOUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool AYEJJKXMKGV(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task USNRLUTWFLN(RRObject a);

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Guid UVDROOLSAMC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NDMYDMJILTL(ObjectLocalId a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VPEOXUPQIKF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task NCRKSWAGFVG(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void EQPMRZVAKSX(ObjectLocalId a, ObjectNetworkId b);
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface VMMRCEWWSEO
	{
		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		Guid JHSVSRNCVBZ
		{
			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BUTRVUHLKAY(NativeList<Guid> a, NativeList<Guid> b, NativeList<FixedString64Bytes> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface KDJXJUYDJJS
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NativeObjectLocalIdArray CKSDMFXBQCL(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeObjectLocalIdArray DIIBPBBWUXY(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool YIROXOYLSRX(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool GKLSACAUSNZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool QZPBCXAYNOL(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool CDLQWHJBDXY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void IENBHHQXAKE(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId AHRCHETGJBB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void DKVMMNWPJGL(NativeObjectLocalIdArray a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HGBLJLRDOUA(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void KMGEVZVRKBO(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		int TRDMINGSESR();

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void IQSGTZFQEUY(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface VISHFKXSWVQ
	{
		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<ObjectLocalId, ObjectLocalId> CDKBFIFMLOG;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<ObjectLocalId, ObjectLocalId> BPTGUABKDAU;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action<ObjectLocalId, ObjectLocalId, ObjectLocalId> HKBHVBIQCVQ;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<ObjectLocalId> HTWCOCIZFSN;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool ZPBQJWGOKAO(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(Slot = "9")]
		ObjectLocalId HWRUDMSLTMO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(Slot = "10")]
		NativeObjectLocalIdArray DVEMSNXODWV(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ObjectLocalId AUQGPRVMGBE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void LNEBNDBARWM(ObjectLocalId a, Vector3 b, Quaternion c);

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void MBXKBQLQBUH(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool UJZNXJGURNL(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool EJFQJNGYAZX(ObjectLocalId a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool MSIWOUPCHMC(ObjectLocalId a, [Out] float b);

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		float3 FIHEBFDMSSB(RRObjectConnectable a);

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		quaternion PNPQVLNHLQM(RRObjectConnectable a);

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(Slot = "19")]
		RigidTransform GTAVHNXUNDW(RRObjectConnectable a);
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public static class DPDINXXGTQM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface KXHORJIXWCW
	{
		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		object DJVDQVBYTUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface LVZGTYFWXRW
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void APBGKCTHAEG(ObjectLocalId a, EKVACRJICQQ b);

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MZCYKRIAKQP(EKVACRJICQQ a);

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RLXOZLYZZHD(ObjectLocalId a, [Out] EKVACRJICQQ b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZIKDCTRMNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AAXGTEBYYQX(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeArray<ObjectLocalId> OYCYFBLFBGL();
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[Flags]
	public enum DescendantFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		IncludeSelf = 1,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		IncludeChildren = 2,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		IncludeDescendants = 6,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		IncludeMask = 7,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Disembodied = 8,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		Embodied = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		IgnoreEmbodiment = 0x18,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		EmbodimentMask = 0x18,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Runtime = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Authored = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		AuthoredAndRuntime = 0x60,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		HierarchyMask = 0x60,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		HintInputsAreDisjoint = 0x80
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface HELMVNLONSC
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public ref struct SnapPointPreviewInformation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public ReadOnlySpan<ObjectLocalId> MyPoints;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public ReadOnlySpan<ObjectLocalId> NearbyPoints;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public ObjectLocalId ProposedSnapPointSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public ObjectLocalId ProposedSnapPointOther;
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool MYRJQKFIBFZ(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VIFZBRSZRTN(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool AWLQHIJNDVL(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KPKRXCZZHLM(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool JYACPFGBEMC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool DZLUAISKVIS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ObjectLocalId TFCEDTGLUMU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ReadOnlySpan<ObjectLocalId> LNHHXIDNIVQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		ReadOnlySpan<ObjectLocalId> IHXROQHXUQL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "9")]
		SnapPointPreviewInformation BMXLUAUCWIJ(ObjectLocalId a, float b, float c);

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool EGNEBCCCSIR(ObjectLocalId a, [Out] ElementGroupStatusData b);

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void NDEMQFGNRUT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void HADUTKVAJLY(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public readonly struct GameConfig<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x644EF50", Offset = "0x644D950", VA = "0x18644EF50")]
		public GameConfig(T defaultValue, [Optional][CallerMemberName] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[Obfuscation(ApplyToMembers = false)]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static readonly GameConfig<int> MUBJNSBEJYS;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly GameConfig<int> JUSVTHLRDGK;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static readonly GameConfig<int> KPPEMWGDGMI;
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum GameConfigState
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Enabled,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Indeterminate
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public static class LZZMYRHSTVF
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x153A670", Offset = "0x1539070", VA = "0x18153A670")]
		public static bool IsEnabled(this GameConfigState state)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x1940CA0", Offset = "0x193F6A0", VA = "0x181940CA0")]
		public static bool IYCGFQBBDMY(this GameConfigState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x3287460", Offset = "0x3285E60", VA = "0x183287460")]
		public static bool MOKLTGQXKBF(this GameConfigState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x153A680", Offset = "0x1539080", VA = "0x18153A680")]
		public static bool TGOPDYHLRRW(this GameConfigState a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface HUJCMRRZRDC
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public enum State
		{
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			Unloaded,
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			Loading,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			Loaded,
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			Error
		}

		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public enum EditReadyPreference
		{
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			NeverEditReady,
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			AlwaysEditReady
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		State KZWVMITGCXP
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		bool AMYJMIBEMML
		{
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		bool PBIJQSXOEQB
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		EditReadyPreference MHOSZWIHJRI
		{
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[ServiceLifetime(Lifetime.Application)]
	public interface KKTAWPVNWXM
	{
		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		GameConfigState JDLMVBNCTGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		GameConfigState VWSEMVCWDYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		GameConfigState KMXNNCAABBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		GameConfigState RNHIEXJNXQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		GameConfigState XQWSZAHWPXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		GameConfigState XKOYJMFOKLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		GameConfigState YHQHOODRCAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		GameConfigState HQFZTWIWZWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		GameConfigState AMCUWEQRKPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		GameConfigState EHPVCQPVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		GameConfigState EHMDMYWZOLR
		{
			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		GameConfigState TFPKDUVCMJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		GameConfigState TGGCHOXVKQN
		{
			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		GameConfigState UDAZWFCCDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		GameConfigState ULXJKSZJZPA
		{
			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		GameConfigState TXYRIADPNPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		GameConfigState TNYORNXQPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		GameConfigState QIWKTEKAXTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		GameConfigState KKLWQGRRWNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		GameConfigState HMJHXAJAPNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int Get(GameConfig<int> config);
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface VPZOBIBRUKV
	{
		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event ALVUFJXDTSX.ParentsChangedCallback PUQYDQIHWTV;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ObjectLocalId OFZLWMNRRBC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NativeObjectLocalIdArray KZQYODZXZQF(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(Slot = "4")]
		FractionalIndex FPZEMQLKXGO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool QAJOTPGRYPH(IEnumerable<ObjectLocalId> a);

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		FractionalIndex Move(ObjectLocalId parent, ObjectLocalId src, bool isBefore, ObjectLocalId target);

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId VJFUNKCPWDC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool SetParent(ObjectLocalId localId, ObjectLocalId parent, bool worldPositionStays = false);

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool AAWPPEOQVBA(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool JOTIEJWEJUZ(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[Obsolete("Use IHierarchyService.GetChildren() instead")]
		NativeObjectLocalIdArray QYZDTAMXLIU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool BTMOBRMDPXR(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "13")]
		NativeObjectLocalIdArray XYXQNNQUIVS(NativeObjectLocalIdArray a, DescendantFlags b, Allocator c);

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool BMKMWBHSQWR(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(Slot = "15")]
		ObjectLocalId WCATVMDPXHQ(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool XNICQOWGHXH(ObjectLocalId a, ObjectLocalId b, [Out] ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ObjectLocalId SQPLDCHUKEE(ObjectLocalId[] a);

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(Slot = "18")]
		ObjectLocalId YFKQJSPYJJL(ObjectLocalId a, uint b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public static class PTXRZYABBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x9A09BE0", Offset = "0x9A085E0", VA = "0x189A09BE0")]
		public static bool QXSCYEDOSSQ(this VPZOBIBRUKV a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x9A09C90", Offset = "0x9A08690", VA = "0x189A09C90")]
		public static NativeObjectLocalIdArray XYXQNNQUIVS(this VPZOBIBRUKV a, ObjectLocalId b, DescendantFlags c, Allocator d)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x9A09B20", Offset = "0x9A08520", VA = "0x189A09B20")]
		public static NativeObjectLocalIdArray MZGCIZMSKPW(this VPZOBIBRUKV a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x9A09B60", Offset = "0x9A08560", VA = "0x189A09B60")]
		public static NativeObjectLocalIdArray NUAQFRAIOBD(this VPZOBIBRUKV a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x9A09C50", Offset = "0x9A08650", VA = "0x189A09C50")]
		public static NativeObjectLocalIdArray TSSZTZGPWZG(this VPZOBIBRUKV a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x9A09990", Offset = "0x9A08390", VA = "0x189A09990")]
		public static NativeObjectLocalIdArray GRGFBDMQBJL(this VPZOBIBRUKV a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x9A09BA0", Offset = "0x9A085A0", VA = "0x189A09BA0")]
		public static NativeObjectLocalIdArray QAVZNJLDWHJ(this VPZOBIBRUKV a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x9A099D0", Offset = "0x9A083D0", VA = "0x189A099D0")]
		public static NativeObjectLocalIdArray IHUAUEXFNFX(this VPZOBIBRUKV a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x9A09A10", Offset = "0x9A08410", VA = "0x189A09A10")]
		public static NativeObjectLocalIdArray IHUAUEXFNFX(this VPZOBIBRUKV a, NativeObjectLocalIdArray b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GKMWLZXCMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x9A04A10", Offset = "0x9A03410", VA = "0x189A04A10", Slot = "0")]
		Task<RRSceneLoadOperation> LoadMain(SerializedDataWrapper serializedDataWrapper, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "1")]
		void ASVHHUQABHN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface FPZNZAZPOHQ
	{
		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event ALVUFJXDTSX.ParentsChangedCallback PUQYDQIHWTV;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ObjectLocalId VJFUNKCPWDC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ReadOnlySpan<ObjectLocalId> UKJUAEEFZXY();

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ReadOnlySpan<ObjectLocalId> BFYJHYIFQRJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool QEBSTIUMUGI(ObjectLocalId a, ObjectLocalId b, [Out] FractionalIndex c);

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ECZQRIKTGID(ObjectLocalId a, ObjectLocalId b, [Out] FractionalIndex c);

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool DJSUEARAPTJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool AAWPPEOQVBA(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		FractionalIndex UTJQPKAEVEC(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface KOJFEFOOEKP
	{
		[Cpp2IlInjected.Token(Token = "0x17000206")]
		bool ZWNJHZDLWIG
		{
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		bool SIHAJRWFIXO
		{
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		bool RVFMSPQNCJT
		{
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface VGDONBQDMMZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface VZBFZEFFTKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AIGOREFFSTA(ObjectLocalId a, NetworkProperty b);

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NWCHWVZPMRT(ObjectLocalId a, NetworkProperty b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface KLGCXGVNECR
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RentedArray<string> CKKGJVWWQHK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RentedArray<string> PQTJGXNJFAR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SQQDMPFYOBH(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HZJHBBIWLUQ(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool EFLPAMKNLZD(ObjectLocalId a, ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface MNUBFSAMNAX
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		InteractionFilterMode UQKIKTWAUUB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JJXILALTCKB(ObjectLocalId a, InteractionFilterMode b);

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool VGLQMUOPHHV(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PYSRCYTTFGT(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RentedArray<string> STRGLZORSAT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PRZDYWWZXJR(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		RentedArray<string> WQUSALDPBWV(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void XIYMUILXTGR(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		RentedArray<string> PSYUTGHNNVN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void ATWNNFOZDZJ(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		RentedArray<string> JLGTMIBKMDT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void NONUOMRURNP(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool WHSNLLMKVRH(ObjectLocalId a, ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WBWASEGVKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Raycast([In] float3 origin, [In] float3 direction, float maxDistance, [Out] RayIntersection intersection, [Out] ObjectLocalId spline);

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int OverlapSphere([In] float3 origin, float radius, List<ObjectLocalId> localIds);

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int XKREHKDQPCX(Plane[] a, float3 b, float3 c, quaternion d, List<ObjectLocalId> e);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WZOWZPXQFXS
	{
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Raycast([In] NativeArray<Entity> entities, [In] float3 origin, [In] float3 direction, [In] NativeArray<RayIntersection> outRayIntersections);

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeList<Entity> OverlapSphere([In] NativeArray<Entity> entities, [In] float3 origin, float radius);

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NativeList<Entity> XKREHKDQPCX([In] NativeArray<Entity> entities, [In] NativeArray<float4> frustumPlanes);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public struct PhysicsSceneColliderHandle : KIWRLLDVYGF, IEquatable<PhysicsSceneColliderHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000209")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0xF535F0", Offset = "0xF51FF0", VA = "0x180F535F0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x15AB7E0", Offset = "0x15AA1E0", VA = "0x1815AB7E0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x30B9B60", Offset = "0x30B8560", VA = "0x1830B9B60", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x30B9B70", Offset = "0x30B8570", VA = "0x1830B9B70", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A2A0", Offset = "0x9A08CA0", VA = "0x189A0A2A0", Slot = "8")]
		public bool Equals(PhysicsSceneColliderHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A2F0", Offset = "0x9A08CF0", VA = "0x189A0A2F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public struct RayIntersection
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public float distance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float3 normal;
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface LLOVQTIKRED
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface HGLSGDPNMGD
	{
		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		MRGKOGFFBPH APQIWCRQTPI
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		ObjectServiceHandle SCXLHVWCOSO
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		int TVWLBLTNVIK
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		int ZGNWDLOJMNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		int JLYCJCHDZJB
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		int YFLAIZCCBTY
		{
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		int TYOSIDKNDJV
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<NativeObjectLocalIdArray, NativeArray<RRObjectPrefabData>> DJTFJYETUFW;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action<NativeObjectLocalIdArray> AOTKMBMZYUE;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeObjectLocalIdArray FXFFBCNKBGB();

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(Slot = "12")]
		NativeObjectLocalIdArray SVVEZMGNYPP();

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(Slot = "13")]
		ObjectType IGYZFLEWPCP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(Slot = "14")]
		RRObjectPrefabData CRKOLHRNVVU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void TQCUJUKDDRU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(Slot = "16")]
		RRObject Embody(ObjectLocalId localId);

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool UUFQBJTBDNR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool TCBROOSDKLT(ObjectLocalId a, [Out] Transform b);

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		ObjectLocalId UNMVSDJRIPY(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(Slot = "20")]
		bool BCLKRKKCYAD(ObjectNetworkId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(Slot = "21")]
		ObjectNetworkId OWIUIPDZJLB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(Slot = "22")]
		NativeObjectLocalIdArray UNMVSDJRIPY(NativeArray<ObjectNetworkId> a, Allocator b, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool EUJFHSEECZJ(NativeArray<ObjectCreationData> a, NativeArray<ObjectNetworkId> b, NativeArray<Entity> c, RentedArray<XDVRHPNXVJM> d);

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		RRObject HMGYBYUUYJQ();

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(Slot = "25")]
		RRObject CreateObject(RRObjectPrefabData prefabType, [Optional] CreationInstantiationParameters instantiationParameters);

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(Slot = "26")]
		RRObjectContainer EULVWEIIIPR();

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(Slot = "27")]
		RRObjectShapeSpline VICLTZYPPJD();

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(Slot = "28")]
		RRObjectShapePrimitive OQJEVGMATAF(PrimitiveShapeType a);

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void MIAHOQJGPRV(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void EMBYHOZIGEK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool ECFZKFWTVIA(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(Slot = "32")]
		NativeObjectLocalIdArray TNEXUDMGJJO(NativeObjectLocalIdArray a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		bool Exists(ObjectLocalId localId);

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool VXQDTYNZIFW(ObjectLocalId a, ComponentTypeSet b);

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		ObjectLocalId SGXUJQOOWFD(Transform a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public static class BZRXTVQBUAM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x9A03DD0", Offset = "0x9A027D0", VA = "0x189A03DD0")]
		internal static ObjectLocalId ZEEWYRZGOFT(this Entity a, HGLSGDPNMGD b)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x9A03920", Offset = "0x9A02320", VA = "0x189A03920")]
		public static RRObject LIMPVNDKIPR(this HGLSGDPNMGD a, LocalId b)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x9A03B50", Offset = "0x9A02550", VA = "0x189A03B50")]
		public static ObjectLocalId UNMVSDJRIPY(this HGLSGDPNMGD a, LocalId b)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x9A03AE0", Offset = "0x9A024E0", VA = "0x189A03AE0")]
		public static ObjectNetworkId OWIUIPDZJLB(this HGLSGDPNMGD a, LocalId b)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x9A03780", Offset = "0x9A02180", VA = "0x189A03780")]
		public static RRObjectContainer FVZYXLEBLDJ(this HGLSGDPNMGD a, RigidTransform b)
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x9A03930", Offset = "0x9A02330", VA = "0x189A03930")]
		public static RRObjectShapePrimitive MPKENRFGYPX(this HGLSGDPNMGD a, PrimitiveShapeType b, RigidTransform c)
		{
			return default(RRObjectShapePrimitive);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x9A03C00", Offset = "0x9A02600", VA = "0x189A03C00")]
		public static RRObjectShapeSpline UPSERHULRDT(this HGLSGDPNMGD a, RigidTransform b)
		{
			return default(RRObjectShapeSpline);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x9A03DA0", Offset = "0x9A027A0", VA = "0x189A03DA0")]
		private static void YTRUXAPGHVF(RRObject a, RigidTransform b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	internal interface AYWJAOPGXJY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OFBOIOQEYYF
	{
		[Cpp2IlInjected.Token(Token = "0x17000212")]
		bool XAKWIZFAGKU
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		ObjectLocalId YZQXOKRRQWG
		{
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		RRObject LSMTQFVNZDN
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event ScopeChangedEventHandler PLBOUURBYIM;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId WCATVMDPXHQ(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool XNICQOWGHXH(ObjectLocalId a, ObjectLocalId b, [Out] ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void AQNNNJBOBTS();

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void ECMSZZSXRBO();

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool TDIMDNBXZDX(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool LHZNWRWSURC(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public delegate void ScopeChangedEventHandler(RRObject oldScope, RRObject newScope);
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public static class HABSRJUDRXT
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x9A04DA0", Offset = "0x9A037A0", VA = "0x189A04DA0")]
		public static bool YSUCLNCOUIH(this OFBOIOQEYYF a, RRObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x9A04C40", Offset = "0x9A03640", VA = "0x189A04C40")]
		public static bool BHYGMQRYCGY(this OFBOIOQEYYF a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x9A04D20", Offset = "0x9A03720", VA = "0x189A04D20")]
		public static bool FLGJGITUOOB(this OFBOIOQEYYF a, ObjectLocalId b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface JYNIUEISHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HZIFUTTJSIA(NativeList<RRObjectPrefabData> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WPADDSJKNYW
	{
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PSSVXDCJMQT(RRObject a, ReferenceGroupKind b, List<RRObject> c);

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int IHQAWYNXDKK(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WIUTRFUYMLU(RRObject a, List<RRObject> b);

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int JZUFNJECDTX(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RRObject VJEJMQGHVES(RRObject a, int b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void WHIXOODUHLD(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool GKTMBQLCCIX(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void EHRIKCCSVGE(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool GPRZJYBVAIK(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void UZFHEOXLAZH(Entity a, Entity b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RJUJWAVULWZ(Entity a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool ZOLXNIFNBXM(RRObject a, ReferenceGroupKind b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZGPWBPTXIHW
	{
		[Cpp2IlInjected.Token(Token = "0x17000215")]
		RRScene DJQTEQIZJRA
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NetworkCreatorId RLCNDTDWHMJ(RRScene a);

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RRScene RSBSAOMOXDA();

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RRScene FLLPPKMXXOK();
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface CSZIKKFPQMN
	{
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool RUYOLPRRADH(ObjectLocalId a, [Out] ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WKIRUWJGXVY
	{
		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<ObjectLocalId> SOFXOIJEFHX;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FPEEAVMOSUF(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MQGGOZNJAUP(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BSMMHPJFXKD(ObjectLocalId a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WXWCHJUHGCZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ObjectLocalId> PTYYFDYHPLH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ObjectLocalId VPNTTBMKUJJ(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int JTWHUEGZAZT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(Slot = "3")]
		SplineParameters ZKCGIBVVTQQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MFQLICPJUII(ObjectLocalId a, SplineParameters b);

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ObjectLocalId NFDJLZAHNZE(ObjectLocalId a, [Optional] float3? b, [Optional] quaternion? c, [Optional] float3? d);

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ObjectLocalId BGDBRSJKQYN(ObjectLocalId a, int b, [Optional] float3? c, [Optional] quaternion? d, [Optional] float3? e);

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void JTOVWGFTYJN(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void SLLEPASTIGI(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface MOIMXCKGOEI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface FXLUUMPLGOH
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KLDRWLAPKHG(ObjectLocalId a, ReadOnlySpan<TerrainGenerationLayer> b);

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BLDCEVHJEAX(ObjectLocalId a, ReadOnlySpan<TerrainCustomMaterialLayer> b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface XHVENZHSDKN
	{
		[Cpp2IlInjected.Token(Token = "0x17000216")]
		bool GGVIREENZAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IFUMOTQPLKN();

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void YDHWZULUZTY();

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JGYVAZCSWMG();

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XIOEWYVTXCL();

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AYKOJKVGUHP();

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DNAPMFQWMJG();

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void BJOBKQSAFFI();

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void DZFFPGTODMK();

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void DFLULDXLYNQ();

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void KAGUFACAUTS();

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void INYWYRLIECV();

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void JJNGIAZTBKC();
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface JFATBHNVEZY
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LSWUGSIUJEO(ObjectLocalId a, [Out] int b);

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZGAGHIXHLHR(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ForceCleanup(ObjectLocalId target, bool forceImmediate);

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EENNHECSRPA(ObjectLocalId a, float b, float c, float d);

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool KWASSRGVJPY(ObjectLocalId a, [Out] float b, [Out] float c);

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SLHMRMFSSLP(ObjectLocalId a, float3 b, quaternion c);

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool SVXDUYQRNQM(ObjectLocalId a, [Out] float3 b, [Out] quaternion c);

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void LIQYPVDURER(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface JBWPPFUIGUI
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetLocalPosition(Entity entity, [In] float3 value);

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float3 HPPGHSPIXHW(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetLocalRotation(Entity entity, [In] quaternion value);

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(Slot = "3")]
		quaternion XVHCUHLEFFP(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FBDWHUGOPFI(Entity a, [In] float3 position, [In] quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PSPVEYGGUNY(Entity a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void PNOQRNMPMLP(Entity a, [In] float3 position, [In] quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void JIITRGRYLQV(Entity a, [Out] float3 b, [Out] quaternion c);

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void JIITRGRYLQV(Entity a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void HLPOFDITTGF(Entity a, float b);

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		float UNDRNOLGIGV(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void SetWorldPosition(Entity entity, [In] float3 value);

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(Slot = "12")]
		float3 AUIMQUFWNSP(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void SetWorldRotation(Entity entity, [In] quaternion value);

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(Slot = "14")]
		quaternion IZXTQOKXPDA(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void CIYLWIXSSJQ(Entity a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(Slot = "16")]
		float ZGITZTHVDAC(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void YJOOHZDQCXM(Entity a, [Out] float4x4 b);

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void WVTWQIPMJBQ(Entity a, [In] float4x4 localToWorld);

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void NotifyTransformParentChanged(Entity entity);

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void APNEHRZCQVX(Entity a, Entity b, Entity c);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public static class YNYJQFLRKYC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface MJXOFICRIZK
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PWJNLRNTQTG(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface KSRPNGZZEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZGOYYUZIUVC(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WMCFYDNISMS(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TQUNTITPDBQ(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JIBPTLWWQPO(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WGPODNFFCJN(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YACIWOLTUKB(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int LHUVSVXQHBD(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int LCCPPJSBDNS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "8")]
		int WQRKUJAZFTY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(Slot = "9")]
		YYDWYZOTBEZ<string> KPVIDPQHWUY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool YXIONXXAUBI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(Slot = "11")]
		YYDWYZOTBEZ<string> BQYYHFHVCZM(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool XXAUKLFJUVD(ObjectLocalId a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ZIKMVYBHPTD(string a, NativeObjectLocalIdList b);

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(Slot = "14")]
		ObjectLocalId VCMAGLVDXSY(string a);

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void KGXVACUXUKS(string a, NativeObjectLocalIdList b);

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void IBIRKHERLVB(ObjectLocalId a, string b, NativeObjectLocalIdList c);

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		YYDWYZOTBEZ<string> DMEWUFMFDFD();
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public static class ROHWLEUSPFY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WCXDTARINTF
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		World OWPFXBKRPFV(string a = "Main");

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		World KSNBUKDNGMI(string a = "Shadow");

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		World UIHAQCCZNHR(string a = "Deserialization");

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(Slot = "3")]
		World XYQQXXNZAGU(string a = "Serialization");
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface VRTQSTAVQZS
	{
		[Cpp2IlInjected.Token(Token = "0x17000217")]
		World XGXYTLWLEOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		World YHHTBTOEDNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000219")]
		EntityManager JEUBYQQEFWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ComponentSystemBase HNLCOHXJXLP(Type a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public static class UXYQFOZRIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x9A1D370", Offset = "0x9A1BD70", VA = "0x189A1D370")]
		public static ComponentSystemBase VXYEQDSJQLT(this World a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x4084CD0", Offset = "0x40836D0", VA = "0x184084CD0")]
		public static a HNLCOHXJXLP<a>(this VRTQSTAVQZS a) where a : ComponentSystemBase
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface MPFXATQZZZF
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KEBUGQWJILU(NativeListAsync<Entity> a);

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MJCXAGCUFAB(CollisionIslandGeneratorState a);

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DDNQEHOCOOG(NativeListAsync<Entity> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TOCZOFZMYDC();

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CGUTREZYNCB(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface JSXKOMWKSKB
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool QGKRIJTXHGO(Collider a, [Out] ObjectLocomotionSettings b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface FYAYARYRYXJ
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Collider ZJYBNBJHPVO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject XBPAZACTSJX(ObjectLocalId a, GameObject b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TLZZIERVCIT(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(Slot = "3")]
		a UPSTTIAWHQT<a>(GameObject a) where a : Collider;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IOVFJFYKFAX(Collider a);

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "5")]
		GameObject YZYUWGQMGLF<b>(string a) where b : Collider;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "6")]
		YVDKQKBSXKR LCPHAGKUCII(ObjectLocalId a, ObjectLocalId b, PrimitiveShapeType c, float3 d, quaternion e, float3 f);

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool JSVGKHMRGJC(ObjectLocalId a, [Out] YVDKQKBSXKR b);

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool PHUZSWVFKNW(ObjectLocalId a, [Out] ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public enum ColliderType
	{
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Sphere,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		Mesh,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		CapsuleX,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		CapsuleY,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		CapsuleZ,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		COUNT
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface EOLRSBNGNPP
	{
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		public struct ShapePrefab
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public int shapeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public GameObject prefab;
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HRXCGGNQQZB(ObjectLocalId a, CollisionLayerEnum b, bool c, PhysicsModelEnumFlags d);

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LUQNWVPGCKT(ObjectLocalId a, CollisionLayerEnum b, bool c, bool d, bool e);

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(Slot = "2")]
		XMKRLUICWWE XOHPGVIIOIF(ObjectLocalId a, List<ObjectLocalId> b);

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		YVDKQKBSXKR NZRHBFQXDEW(GameObject a, GameObject b);

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IPYBZCLJILY(GameObject a, List<GameObject> b);

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SLTNAIOFPCM(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		a UPSTTIAWHQT<a>(GameObject a) where a : Collider;

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void IOVFJFYKFAX(Collider a);

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		GameObject ESJQYIJKOXP<b>(string a) where b : Collider;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HCHFNSBIRZS(Collider a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool JXZWFFQXLMI(ObjectLocalId a, [Out] ObjectLocomotionSettings b);

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeArray<ColliderType> FPWHDRMHSMK(Allocator a = Allocator.TempJob);

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Mesh[] SVJMGGQHSQA();
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface XSCAJHIXDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JTOEXZFXZXN(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DPCKNIKDXKK(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int EHKUJTPWPIZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ObjectLocalId AOZKAPIMUAG(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NativeObjectLocalIdArray KXWUUDJNRII(ObjectLocalId a, Allocator b = Allocator.Temp);

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void BNPLRHCJASY(ObjectLocalId a, object b, ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void WEUEZZJUESN(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool MUNIHVPJSAJ(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void YMDZDCWDJQD(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool FIKJHCDZKWT(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void UQBRPZXBYJG(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool UYZVALWCEII(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void TIMMMOCIDTR(ObjectLocalId a, (Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool QUUFVABGRAE(ObjectLocalId a, [Out] quaternion b, [Out] float3 c);

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void RSMIYOJVFET(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(Slot = "15")]
		[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
		float3 XBYASDXIJWT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(Slot = "16")]
		float3 AGYVIGQMNIM(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void VUUCUGZPTPC(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void OYALYCNWZNX(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(Slot = "19")]
		float TUUKPIWZMXC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(Slot = "20")]
		float OPJAGOZOUTN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void PLIBBLCHQOD(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void AYGITYVCCVO(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(Slot = "23")]
		CollisionDetectionMode BQSKIAOWGDE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void OOGPZLDHXRA(ObjectLocalId a, CollisionDetectionMode b);

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(Slot = "25")]
		TransformTrackRate ZQOVKOGPGKP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void FYYQRITLETJ(ObjectLocalId a, TransformTrackRate b);

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool WZROYUOJOVZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void NFNCGAUYTBJ(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(Slot = "29")]
		ObjectLocalId OFZLWMNRRBC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void QHPYOQCIFLK(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(Slot = "31")]
		ObjectLocalId VJFUNKCPWDC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void SetParent(ObjectLocalId localId, ObjectLocalId value);

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(Slot = "33")]
		RbexInterpolationMode PGONSCFLFIS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void BUSBSPUUXAO(ObjectLocalId a, RbexInterpolationMode b);

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool CKZLOAOJHVZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void DMDDDVUFRKL(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(Slot = "37")]
		bool CPSUKVHXPXM(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void PESWPGRGCXM(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(Slot = "39")]
		RigidbodyConstraints IWCMBZBMIOF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void MEDQHLEATPT(ObjectLocalId a, RigidbodyConstraints b);

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "41")]
		float VUXAXCSUOPU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void WVXFVFQUJJQ(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "43")]
		float XYBEGNORVPG(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void LJVISYPDZYA(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(Slot = "45")]
		bool WTXSWFBXZLN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void RNKLJVRGIBR(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(Slot = "47")]
		bool BYSVVORNBRI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void QIJRBDXSKAC(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void PBQVOWFTBFY(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "50")]
		ZOVUKJMZZZX GTJIELXRWLU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void IAJCSXBDPJI(ObjectLocalId a, ZOVUKJMZZZX b);

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "52")]
		VHPXXKFPOWQ EGFHEGASBYB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void QBRPNCYGAWV(ObjectLocalId a, VHPXXKFPOWQ b);

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "54")]
		float NMSTUXBEZLV(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void VMGSHYNAUWX(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void UEWRJEVOGDC(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void CXSQVCOGWXD(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(Slot = "58")]
		bool TXMYDTRTQXI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void LFJUNKMWWUY(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(Slot = "60")]
		void CQTUBCSZOHN(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(Slot = "61")]
		bool JGQDQIZSFSY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(Slot = "62")]
		bool HMLXFQKBZTY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(Slot = "63")]
		Rigidbody TARSHXQGEAL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void PIKGRQRPBKP(ObjectLocalId a, Rigidbody b);

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(Slot = "65")]
		void DXKCMOTVTOD(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(Slot = "66")]
		void SJBKOBVMAWG(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(Slot = "67")]
		bool KCPEWXAVVDZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(Slot = "68")]
		void CMUFHUNAPDW(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(Slot = "69")]
		void XTWVHYRQPZI(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(Slot = "70")]
		bool OWJHYZEVRMX(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(Slot = "71")]
		bool IMULOORKBDD(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(Slot = "72")]
		bool AFOBOGMJGQR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(Slot = "73")]
		void JLEHMDFHOHI(ObjectLocalId a, object b, bool c);

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(Slot = "74")]
		void KMGWKTLQECO(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(Slot = "75")]
		void IKJVORUCYLW(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(Slot = "76")]
		bool UNXMNJEITTV(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface PFVWJGBVFCX
	{
		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IDIUEKUMIGB(Entity a);

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LZFKNBMLPWD(Entity a);

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SPIWXSLJLEZ(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface SEEJQVFMKNL
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YKRQFSWSTZO(ObjectLocalId a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public delegate void BulkPropertyChangeCallback(BulkPropertyChangeData propertyChangeData);
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public readonly ref struct BulkPropertyChangeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly NativeObjectLocalIdArray objectIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly NativeArray<byte> prev;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly NativeArray<byte> curr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly NetworkProperty property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly int propertySize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly Type propertyType;

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public NativeObjectLocalIdArray TQSJHPWJLML
		{
			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0x304EC10", Offset = "0x304D610", VA = "0x18304EC10")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public int FUKZCZVBGQY
		{
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0x9A03E80", Offset = "0x9A02880", VA = "0x189A03E80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		public NetworkProperty ZKCBLCFMUPP
		{
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(RVA = "0xD01150", Offset = "0xCFFB50", VA = "0x180D01150")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x9A03EA0", Offset = "0x9A028A0", VA = "0x189A03EA0")]
		public BulkPropertyChangeData(NativeObjectLocalIdArray objectIds, NativeArray<byte> prev, NativeArray<byte> curr, NetworkProperty property, int propertySize, Type propertyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x37D49E0", Offset = "0x37D33E0", VA = "0x1837D49E0")]
		public NativeArray<a> ZDRFHZJSYSR<a>() where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x37D46E0", Offset = "0x37D30E0", VA = "0x1837D46E0")]
		public NativeArray<b> ABRDYUMQLMB<b>() where b : struct
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x37D47C0", Offset = "0x37D31C0", VA = "0x1837D47C0")]
		public (NativeObjectLocalIdArray, NativeArray<T>, NativeArray<T>) Get<T>() where T : struct
		{
			return default((NativeObjectLocalIdArray, NativeArray<T>, NativeArray<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C947A0", Offset = "0x5C931A0", VA = "0x185C947A0")]
		public ObjectIdBulkPropertyChangeData QFIPOYDXGNR()
		{
			return default(ObjectIdBulkPropertyChangeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public interface SHZEQMCKDZQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		string JSPICTWKAHO
		{
			[Cpp2IlInjected.Token(Token = "0x60006DF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		SHZEQMCKDZQ YPYDICGZQFV
		{
			[Cpp2IlInjected.Token(Token = "0x60006E0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		IEnumerable<SHZEQMCKDZQ> EABTTBHIVTQ
		{
			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface EOZHHJLHPOL
	{
		[Cpp2IlInjected.Token(Token = "0x17000221")]
		SHZEQMCKDZQ QAVOSMBVOJN
		{
			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		NativeArray<NetworkProperty> ZLLPQQGBLSE
		{
			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool YMZQEXBKUXQ(NetworkProperty a, [Out] SHZEQMCKDZQ b);

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QCIVJGOFOSZ(NetworkProperty a, BulkPropertyChangeCallback b);

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JLFJVASZUFA(NetworkProperty a, BulkPropertyChangeCallback b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface SKLFILYOTQI
	{
		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QCIVJGOFOSZ(NetworkProperty a, BulkPropertyChangeCallback b);

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JLFJVASZUFA(NetworkProperty a, BulkPropertyChangeCallback b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public static class QYNKBHSTUCS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface AMSFFYCYSGP
	{
		[Cpp2IlInjected.Token(Token = "0x17000223")]
		bool ZCVPQJNQPVP
		{
			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		ReplicationData AOPFCVICAEK
		{
			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MWTBKAYKHBL(NetworkCreatorId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool PPQPCKKDEMG(ObjectNetworkId a, NetworkProperty b);

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FPGDWSHSQTH(NativeArray<ObjectNetworkId> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public static class NXBJQMRYSMV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public readonly ref struct ObjectIdBulkPropertyChangeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly BulkPropertyChangeData data;

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		public NativeObjectLocalIdArray TQSJHPWJLML
		{
			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x304EC10", Offset = "0x304D610", VA = "0x18304EC10")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x9A08070", Offset = "0x9A06A70", VA = "0x189A08070")]
		public ObjectIdBulkPropertyChangeData(BulkPropertyChangeData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x9A07F40", Offset = "0x9A06940", VA = "0x189A07F40")]
		public NativeObjectLocalIdArray ZDRFHZJSYSR()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x9A07B20", Offset = "0x9A06520", VA = "0x189A07B20")]
		public NativeObjectLocalIdArray ABRDYUMQLMB()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x9A07C50", Offset = "0x9A06650", VA = "0x189A07C50")]
		public (NativeObjectLocalIdArray, NativeObjectLocalIdArray, NativeObjectLocalIdArray) Get()
		{
			return default((NativeObjectLocalIdArray, NativeObjectLocalIdArray, NativeObjectLocalIdArray));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public static class CQEAZYDCEMH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public readonly struct ReplicationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly NativeBitArray bitArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly NativeParallelHashMap<ObjectNetworkId, int> bitOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly NativeParallelHashSet<NetworkCreatorId> denyCreatorIds;

		[Cpp2IlInjected.Token(Token = "0x17000226")]
		public bool ETDMPSEJVRO
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0x9A1CD20", Offset = "0x9A1B720", VA = "0x189A1CD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		public bool ZCVPQJNQPVP
		{
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0x9A1CD40", Offset = "0x9A1B740", VA = "0x189A1CD40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x9A1CF40", Offset = "0x9A1B940", VA = "0x189A1CF40")]
		public ReplicationData(NativeBitArray bitArray, NativeParallelHashMap<ObjectNetworkId, int> bitOffsets, NativeParallelHashSet<NetworkCreatorId> denyCreatorIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x9A1CD70", Offset = "0x9A1B770", VA = "0x189A1CD70")]
		public bool PPQPCKKDEMG(ObjectNetworkId a, NetworkProperty b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZUUHPIBBMFQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000228")]
		OutlineEffectType RVSOZHHISNX
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface KTSDCOPCQBO
	{
		[Cpp2IlInjected.Token(Token = "0x17000229")]
		int MYLJASPCLPO
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		int EEZGXQVTSLF
		{
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ELCZTTELLZD(ObjectLocalId a, MutableRef b);

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RootHandle BGBIKPXRVXH();

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RootHandle GUQMHWOTDEE();
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZFNJLVZBFXH
	{
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IASMSEGWJMX(World a);

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XYFKWLORXMB(World a);

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ComponentSystemBase GHFQVHQTMSI(World a);

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BYYXUFXOGIU(World a);

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WNSWDTUVWIX(World a);

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YSMIPRCRGBU(World a);

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZZWWLOVYYVR(World a);

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(Slot = "7")]
		NativeParallelHashSet<ComponentTypeIndex> JSCYXCCECQK();
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ECPMBIYFXPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JYWLWATCAEG(ObjectLocalId a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public readonly struct BulkInstantiationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly IEnumerable<InstantiationRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly IReadOnlyList<GameObject> instantiations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly IReadOnlyList<int> requestIndexByInstantiation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly IReadOnlyList<(ObjectNetworkId, ObjectNetworkId)> srcDstNetworkIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly int rootCount;
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public struct InventionParameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public InventionIdData id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public InventionInstanceIdData instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public bool overwriteIdData;

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x9A05700", Offset = "0x9A04100", VA = "0x189A05700")]
		public InventionParameters(long id, Guid instanceId, bool overwriteIdData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[ServiceLifetime(Lifetime.Application)]
	public interface HBUUTDQRDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RRSceneLoadOperation NOZKCUQNXIA(SerializedDataWrapper a, int b = 0, bool c = false);

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RRSceneLoadOperationSubgraph JSDUFMGERNQ(SerializedDataWrapper a, ObjectLocalId b, [In] UniformTRS parentFromWorldTransform, XJKGWJSBQPR c, [Optional] InventionParameters d, bool e = true, bool f = false, bool g = false, bool h = false);

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAINHYKOULU GIQKBSGDLZF();

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAINHYKOULU HOZGSODOHKX(NativeObjectLocalIdArray a, [In] UniformTRS serializedSceneFromCommonParentOfSerializedRoots, [Optional] XJKGWJSBQPR b);

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool NJHKZSQGGAR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NKYYZHRMSNN(ObjectLocalId a, [Out] Exception b);

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void XLLHVIKARQT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(Slot = "7")]
		NativeArray<ObjectNetworkId> AFTIRBMNGUB(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(Slot = "8")]
		NativeArray<ObjectNetworkId> QYZFXJFUDKE(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(Slot = "9")]
		NativeObjectLocalIdArray NUJFZTHTBLI(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(Slot = "10")]
		NativeObjectLocalIdArray GEIGQFMUMCX(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeObjectLocalIdArray MWBKZBATFPZ(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(Slot = "12")]
		NativeArray<EntityRemapUtility.EntityRemapInfo> EXMKNCWHWTA(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool XHWBPSARQIE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(Slot = "14")]
		int IELQCUYQDOC(ObjectLocalId a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[ServiceLifetime(Lifetime.Application)]
	public interface NCYMHFNRNPX
	{
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xF65E70", Offset = "0xF64870", VA = "0x180F65E70", Slot = "0")]
		bool CDBQJAFJOGY(object a, LSHBYQPFVGF b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public static class NTZYXYSQTBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x9A05EF0", Offset = "0x9A048F0", VA = "0x189A05EF0")]
		public static bool CDBQJAFJOGY(this NCYMHFNRNPX a, object b, [Out] LSHBYQPFVGF c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public enum GamePropertyKey : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		MaxPlayers = 255,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		IsVisible = 254,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		IsOpen = 253,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		PlayerCount = 252,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Removed = 251,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		PropsListedInLobby = 250,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		CleanupCacheOnLeave = 249,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		MasterClientId = 248,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		ExpectedUsers = 247,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		PlayerTtl = 246,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		EmptyRoomTtl = 245,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		HasDedicatedMaster = 87
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public interface LSHBYQPFVGF
	{
		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		NetworkEventType MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		PlayerId TNCIAZFLYKB
		{
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		bool ACPGONEGDUC
		{
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		bool GUHDKPMSIIX
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object HMWJLIQFSIQ();

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool UKMBSGZMALM([Out] PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "6")]
		(PlayerId, object) XVFMKAQKZHE()
		{
			return default((PlayerId, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "7")]
		(ObjectNetworkId, PlayerId) ZEYHQXMIGBM()
		{
			return default((ObjectNetworkId, PlayerId));
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "8")]
		AAQAIJYTKPD<(ObjectNetworkId, PlayerId)> ODOUVVDEQRT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "9")]
		(OutOfBandMessageType, byte[]) JMOTPEHVJQZ()
		{
			return default((OutOfBandMessageType, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "10")]
		(PacketSource, byte[]) PNMADSRFNSW()
		{
			return default((PacketSource, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0", Slot = "11")]
		a HUOGTGQXMFZ<a>()
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public static class XLSQEOGQQVB
	{
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x9A1D580", Offset = "0x9A1BF80", VA = "0x189A1D580")]
		public static bool JPTMBKPVCNM(this LSHBYQPFVGF a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public interface WKYBKRPQKSX : AAQAIJYTKPD<NetworkTransformSyncData>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public interface AAQAIJYTKPD<a>
	{
		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		int FUKZCZVBGQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public enum NetworkEventType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		BulkInstantiate = 1,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		BulkDestroy = 2,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		OMSendPacket = 4,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		RR_OutOfBandMessage = 5,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		RR_FastForwardMarker = 6,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		RR_SelfJoinMarker = 7,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		RR_DebugOp = 10,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		RR_CachedEvent = 11,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		RRRoomRequestEvent = 20,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		RRRoomRequestFailedResponseEvent = 21,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		RRBufferedRoomEvent = 22,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		RRClearBufferedRoomEvent = 23,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		RR_CreationOp = 24,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		RR_CreationOpResponse = 25,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		RR_CreationOp_Unchecked = 26,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		RR_MasterLockBlockComplete = 27,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		RR_NetworkSynchronization = 28,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		RR_NetworkInstantiate = 29,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		RR_BulkInstantiate = 31,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		RR_Destroy = 32,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		RR_BulkDestroy = 33,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		RR_TransferOwnership = 34,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		RR_OwnershipUpdate = 35,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		RR_RPC = 36,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		RR_JoinRequest = 100,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		RR_JoinResponse = 101,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RR_RoomUpdate = 102,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		RR_PlayerUpdate = 103,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		RR_RemotePlayerJoined = 104,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		RR_RemotePlayerLeft = 105,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		RR_Leave = 106,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		RPC = 200,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		SendSerialize = 201,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Instantiation = 202,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		CloseConnection = 203,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Destroy = 204,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		RemoveCachedRPCs = 205,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		SendSerializeReliable = 206,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		DestroyPlayer = 207,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		OwnershipRequest = 209,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		OwnershipTransfer = 210,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		VacantViewIds = 211,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		OwnershipUpdate = 212,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		AuthEvent = 223,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		LobbyStats = 224,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		AppStats = 226,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Match = 227,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		QueueState = 228,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		GameListUpdate = 229,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		GameList = 230,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		CacheSliceChanged = 250,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		ErrorInfo = 251,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		PropertiesChanged = 253,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Leave = 254,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Join = 255
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public enum OutOfBandMessageType : uint
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		None = 0u,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		NetworkTransformInitializationData = 1314146628u,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		RestoreCreationData = 1380140064u,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		OldestCachedPacketId = 1329811529u,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		SnapshotPublished = 1397773634u,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		SnapshotPayload = 1397771332u,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		SnapshotClear = 1129337683u,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		RequestNetworkTransformInitialization = 1380865097u
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public static class DGHGJDJUJZG
	{
		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x9A03F20", Offset = "0x9A02920", VA = "0x189A03F20")]
		public static ObjectNetworkId EHXDMXZVSVV(this ObjectNetworkIdComponentData a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x9A03EE0", Offset = "0x9A028E0", VA = "0x189A03EE0")]
		public static ObjectNetworkId DAHZRGXOGPX([In] this ObjectNetworkIdComponentData data)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x98457E0", Offset = "0x98441E0", VA = "0x1898457E0")]
		public static ObjectNetworkId QITOMTJKRLW(this ObjectNetworkIdComponentData a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x98457E0", Offset = "0x98441E0", VA = "0x1898457E0")]
		public static ViewId EOAGKJMZJBH(this ObjectNetworkIdComponentData a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x9A03F50", Offset = "0x9A02950", VA = "0x189A03F50")]
		public static FixedString64Bytes KZWKCUYOHRL(this NetworkCreatorId a)
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x9A041B0", Offset = "0x9A02BB0", VA = "0x189A041B0")]
		public static FixedString64Bytes PHSABJSPFZW(this ObjectNetworkId a)
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x9A04120", Offset = "0x9A02B20", VA = "0x189A04120")]
		public static FixedString32Bytes KZWKCUYOHRL(this Entity a)
		{
			return default(FixedString32Bytes);
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OVPKMGEPSBB : LWWFNSLLQUY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public enum OpCode
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		End,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Create,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		Destroy,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		SetProp,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		Event,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		COUNT
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OVXPTUNEMUV
	{
		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<object> JKOHIUMUCUX;

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "2")]
		void GHNIFDUJHLZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "3")]
		void FDMOBOIXKXP(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
		void ADIJDMNHUJX(OutOfBandMessageType a, ReadOnlySpan<byte> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface KWPCRBXYIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PacketSource JWBIXTLTQOS(ReadOnlySpan<byte> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface IUHAKADKMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UMZYUASZGCH(PacketSource a, ReadOnlySpan<byte> b);

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UKSCXPWICFD(ReadOnlySpan<PacketSource> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public struct Chunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public PacketSource source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public ReadOnlyMemory<byte> payload;
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public struct PacketSource
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static PacketSource SnapshotPacketSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public NetworkCreatorId creatorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int packetId;

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public static NetworkCreatorId LQLEFAHBAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A090", Offset = "0x9A08A90", VA = "0x189A0A090")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x692FE50", Offset = "0x692E850", VA = "0x18692FE50")]
		public PacketSource(NetworkCreatorId creatorId, int packetId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A0E0", Offset = "0x9A08AE0", VA = "0x189A0A0E0")]
		public static bool OTUOIXXRZSY([In] PacketSource lhs, [In] PacketSource rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x9A09F30", Offset = "0x9A08930", VA = "0x189A09F30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A030", Offset = "0x9A08A30", VA = "0x189A0A030", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A170", Offset = "0x9A08B70", VA = "0x189A0A170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x9A09F20", Offset = "0x9A08920", VA = "0x189A09F20")]
		public void EVYASMPCYUQ([Out] NetworkCreatorId a, [Out] int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public static class QPWFTKAHCWW
	{
	}
}
namespace RecRoom.ObjectModel.Interop
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public struct InstantiationRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public string prefabName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Vector3 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int photonViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CreationInstantiationParameters parameters;

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x9A055E0", Offset = "0x9A03FE0", VA = "0x189A055E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecRoom.ObjectModel.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	public enum DeserializationOperationType
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Player,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Scene,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		SubgraphAdditive,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		SubgraphRestore,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		RestoreCreationData,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		InventionPreview
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public static class TMFIWIJUEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x9A1D120", Offset = "0x9A1BB20", VA = "0x189A1D120")]
		public static bool PNTAFWRFAKK(this DeserializationOperationType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x9A1D140", Offset = "0x9A1BB40", VA = "0x189A1D140")]
		public static bool QTWHYXLKIQU(this DeserializationOperationType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x9A1D110", Offset = "0x9A1BB10", VA = "0x189A1D110")]
		public static bool FZOUSYMYCEE(this DeserializationOperationType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[Flags]
	public enum DeserializePhases
	{
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		ParseProtobuf = 1,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		PreInstantiate = 2,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		BulkInstantiate = 4,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		PostInstantiate = 8,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		NotifyInstantiated = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		DisposeProtobuf = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		NotifyCompleted = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		WorldPhasesClient = 0x7B,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		WorldPhases = 0x7B,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		AdditivePhases = 0x7B,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		RestoreCreationData = 0x2B
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public interface XJKGWJSBQPR
	{
		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HYBBASYPRWW([In] Guid src, [Out] Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[Flags]
	public enum WorldDeserializePhases
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		Parse = 1,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		PreInstantiate = 2,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		BulkInstantiate = 4,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		PostInstantiate = 0x18,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		LoadCompleted = 0x60,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		All = 0x7F
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public interface TAINHYKOULU : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000232")]
		GESQGHHUKIG ZVNBKVNVHDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ByteString JBHABLAGIDE();
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public enum SerializationOperationType
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		World,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		Subgraph
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
	public struct LocalBoundsData : ICleanupComponentData, IComponentData, IEquatable<LocalBoundsData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public float3 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float3 extents;

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x9A05CE0", Offset = "0x9A046E0", VA = "0x189A05CE0", Slot = "4")]
		public bool Equals(LocalBoundsData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface UVNSJINMWHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ReadOnlySpan<ObjectLocalId> GSPKIGUVRAR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool YBPGEUOPFQN(ObjectLocalId a, [Out] ObjectLocalId b);
	}
}
namespace RecRoom.ObjectModel.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BCQSXCQRIOV
	{
		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IXPGGLHMTXG(long a);

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MOWPISWWEGU(NativeParallelHashSet<long> a);

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NOBEQPOTGZU(World a, NativeParallelHashMap<Guid, long> b);

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool HDNMFBGNEZD(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool TRUJFUGFBUW(ObjectNetworkId a, [Out] Guid b, [Out] long c);

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HEGWYRBKZVX(ObjectNetworkId a, Guid b, long c);

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool YHQJUVECYZG(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool ULBHZJAHWRT(Guid a, [Out] int b, [Out] int c);

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void TXQCFMQBTJE(Guid a, int b, int c);

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void CSYZGCSAREN(Guid a);
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

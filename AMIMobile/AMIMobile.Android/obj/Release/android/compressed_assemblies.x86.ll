; ModuleID = 'obj/Release/android/compressed_assemblies.x86.ll'
source_filename = "obj/Release/android/compressed_assemblies.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.CompressedAssemblyDescriptor = type {
	i32,; uint32_t uncompressed_file_size
	i8,; bool loaded
	i8*; uint8_t* data
}

%struct.CompressedAssemblies = type {
	i32,; uint32_t count
	%struct.CompressedAssemblyDescriptor*; CompressedAssemblyDescriptor* descriptors
}
@__CompressedAssemblyDescriptor_data_0 = internal global [648704 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_1 = internal global [883200 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_2 = internal global [29088 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_3 = internal global [204288 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_4 = internal global [111104 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_5 = internal global [19336 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_6 = internal global [504320 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_7 = internal global [162816 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_8 = internal global [32128 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_9 = internal global [30600 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_10 = internal global [31610368 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_11 = internal global [241664 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_12 = internal global [695336 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_13 = internal global [29696 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_14 = internal global [4608 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_15 = internal global [6656 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_16 = internal global [218624 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_17 = internal global [258560 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_18 = internal global [1084928 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_19 = internal global [29696 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_20 = internal global [1926144 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_21 = internal global [161280 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_22 = internal global [5120 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_23 = internal global [18432 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_24 = internal global [115712 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_25 = internal global [282624 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_26 = internal global [12288 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_27 = internal global [119808 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_28 = internal global [866816 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_29 = internal global [12288 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_30 = internal global [218624 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_31 = internal global [32256 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_32 = internal global [214528 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_33 = internal global [137728 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_34 = internal global [2442752 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_35 = internal global [1959936 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_36 = internal global [106896 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_37 = internal global [33168 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_38 = internal global [159632 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_39 = internal global [75656 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_40 = internal global [1040384 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_41 = internal global [31096 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_42 = internal global [24976 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_43 = internal global [22920 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_44 = internal global [48528 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_45 = internal global [289168 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_46 = internal global [30600 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_47 = internal global [75152 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_48 = internal global [32656 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_49 = internal global [898448 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_50 = internal global [621448 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_51 = internal global [102784 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_52 = internal global [1633672 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_53 = internal global [57224 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_54 = internal global [63880 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_55 = internal global [28040 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_56 = internal global [59792 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_57 = internal global [54664 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_58 = internal global [281472 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_59 = internal global [22408 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_60 = internal global [34696 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_61 = internal global [19856 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_62 = internal global [14728 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_63 = internal global [43408 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_64 = internal global [30600 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_65 = internal global [24976 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_66 = internal global [26000 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_67 = internal global [35208 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_68 = internal global [21896 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_69 = internal global [62344 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_70 = internal global [19840 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_71 = internal global [392592 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_72 = internal global [14216 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_73 = internal global [91016 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_74 = internal global [77200 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_75 = internal global [36240 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_76 = internal global [266240 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_77 = internal global [22928 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_78 = internal global [591752 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_79 = internal global [29584 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_80 = internal global [44424 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_81 = internal global [67472 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_82 = internal global [18304 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_83 = internal global [141312 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_84 = internal global [45456 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_85 = internal global [31616 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_86 = internal global [107920 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_87 = internal global [83840 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_88 = internal global [54160 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_89 = internal global [752544 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_90 = internal global [218000 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_91 = internal global [1228208 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_92 = internal global [968704 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_93 = internal global [264104 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_94 = internal global [114592 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_95 = internal global [1714176 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_96 = internal global [18072 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_97 = internal global [4504576 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_98 = internal global [90624 x i8] zeroinitializer, align 1


; Compressed assembly data storage
@compressed_assembly_descriptors = internal global [99 x %struct.CompressedAssemblyDescriptor] [
	; 0
	%struct.CompressedAssemblyDescriptor {
		i32 648704, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([648704 x i8], [648704 x i8]* @__CompressedAssemblyDescriptor_data_0, i32 0, i32 0); data
	}, 
	; 1
	%struct.CompressedAssemblyDescriptor {
		i32 883200, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([883200 x i8], [883200 x i8]* @__CompressedAssemblyDescriptor_data_1, i32 0, i32 0); data
	}, 
	; 2
	%struct.CompressedAssemblyDescriptor {
		i32 29088, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([29088 x i8], [29088 x i8]* @__CompressedAssemblyDescriptor_data_2, i32 0, i32 0); data
	}, 
	; 3
	%struct.CompressedAssemblyDescriptor {
		i32 204288, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([204288 x i8], [204288 x i8]* @__CompressedAssemblyDescriptor_data_3, i32 0, i32 0); data
	}, 
	; 4
	%struct.CompressedAssemblyDescriptor {
		i32 111104, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([111104 x i8], [111104 x i8]* @__CompressedAssemblyDescriptor_data_4, i32 0, i32 0); data
	}, 
	; 5
	%struct.CompressedAssemblyDescriptor {
		i32 19336, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([19336 x i8], [19336 x i8]* @__CompressedAssemblyDescriptor_data_5, i32 0, i32 0); data
	}, 
	; 6
	%struct.CompressedAssemblyDescriptor {
		i32 504320, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([504320 x i8], [504320 x i8]* @__CompressedAssemblyDescriptor_data_6, i32 0, i32 0); data
	}, 
	; 7
	%struct.CompressedAssemblyDescriptor {
		i32 162816, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([162816 x i8], [162816 x i8]* @__CompressedAssemblyDescriptor_data_7, i32 0, i32 0); data
	}, 
	; 8
	%struct.CompressedAssemblyDescriptor {
		i32 32128, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([32128 x i8], [32128 x i8]* @__CompressedAssemblyDescriptor_data_8, i32 0, i32 0); data
	}, 
	; 9
	%struct.CompressedAssemblyDescriptor {
		i32 30600, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([30600 x i8], [30600 x i8]* @__CompressedAssemblyDescriptor_data_9, i32 0, i32 0); data
	}, 
	; 10
	%struct.CompressedAssemblyDescriptor {
		i32 31610368, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([31610368 x i8], [31610368 x i8]* @__CompressedAssemblyDescriptor_data_10, i32 0, i32 0); data
	}, 
	; 11
	%struct.CompressedAssemblyDescriptor {
		i32 241664, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([241664 x i8], [241664 x i8]* @__CompressedAssemblyDescriptor_data_11, i32 0, i32 0); data
	}, 
	; 12
	%struct.CompressedAssemblyDescriptor {
		i32 695336, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([695336 x i8], [695336 x i8]* @__CompressedAssemblyDescriptor_data_12, i32 0, i32 0); data
	}, 
	; 13
	%struct.CompressedAssemblyDescriptor {
		i32 29696, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([29696 x i8], [29696 x i8]* @__CompressedAssemblyDescriptor_data_13, i32 0, i32 0); data
	}, 
	; 14
	%struct.CompressedAssemblyDescriptor {
		i32 4608, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([4608 x i8], [4608 x i8]* @__CompressedAssemblyDescriptor_data_14, i32 0, i32 0); data
	}, 
	; 15
	%struct.CompressedAssemblyDescriptor {
		i32 6656, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([6656 x i8], [6656 x i8]* @__CompressedAssemblyDescriptor_data_15, i32 0, i32 0); data
	}, 
	; 16
	%struct.CompressedAssemblyDescriptor {
		i32 218624, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([218624 x i8], [218624 x i8]* @__CompressedAssemblyDescriptor_data_16, i32 0, i32 0); data
	}, 
	; 17
	%struct.CompressedAssemblyDescriptor {
		i32 258560, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([258560 x i8], [258560 x i8]* @__CompressedAssemblyDescriptor_data_17, i32 0, i32 0); data
	}, 
	; 18
	%struct.CompressedAssemblyDescriptor {
		i32 1084928, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1084928 x i8], [1084928 x i8]* @__CompressedAssemblyDescriptor_data_18, i32 0, i32 0); data
	}, 
	; 19
	%struct.CompressedAssemblyDescriptor {
		i32 29696, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([29696 x i8], [29696 x i8]* @__CompressedAssemblyDescriptor_data_19, i32 0, i32 0); data
	}, 
	; 20
	%struct.CompressedAssemblyDescriptor {
		i32 1926144, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1926144 x i8], [1926144 x i8]* @__CompressedAssemblyDescriptor_data_20, i32 0, i32 0); data
	}, 
	; 21
	%struct.CompressedAssemblyDescriptor {
		i32 161280, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([161280 x i8], [161280 x i8]* @__CompressedAssemblyDescriptor_data_21, i32 0, i32 0); data
	}, 
	; 22
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([5120 x i8], [5120 x i8]* @__CompressedAssemblyDescriptor_data_22, i32 0, i32 0); data
	}, 
	; 23
	%struct.CompressedAssemblyDescriptor {
		i32 18432, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([18432 x i8], [18432 x i8]* @__CompressedAssemblyDescriptor_data_23, i32 0, i32 0); data
	}, 
	; 24
	%struct.CompressedAssemblyDescriptor {
		i32 115712, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([115712 x i8], [115712 x i8]* @__CompressedAssemblyDescriptor_data_24, i32 0, i32 0); data
	}, 
	; 25
	%struct.CompressedAssemblyDescriptor {
		i32 282624, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([282624 x i8], [282624 x i8]* @__CompressedAssemblyDescriptor_data_25, i32 0, i32 0); data
	}, 
	; 26
	%struct.CompressedAssemblyDescriptor {
		i32 12288, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([12288 x i8], [12288 x i8]* @__CompressedAssemblyDescriptor_data_26, i32 0, i32 0); data
	}, 
	; 27
	%struct.CompressedAssemblyDescriptor {
		i32 119808, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([119808 x i8], [119808 x i8]* @__CompressedAssemblyDescriptor_data_27, i32 0, i32 0); data
	}, 
	; 28
	%struct.CompressedAssemblyDescriptor {
		i32 866816, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([866816 x i8], [866816 x i8]* @__CompressedAssemblyDescriptor_data_28, i32 0, i32 0); data
	}, 
	; 29
	%struct.CompressedAssemblyDescriptor {
		i32 12288, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([12288 x i8], [12288 x i8]* @__CompressedAssemblyDescriptor_data_29, i32 0, i32 0); data
	}, 
	; 30
	%struct.CompressedAssemblyDescriptor {
		i32 218624, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([218624 x i8], [218624 x i8]* @__CompressedAssemblyDescriptor_data_30, i32 0, i32 0); data
	}, 
	; 31
	%struct.CompressedAssemblyDescriptor {
		i32 32256, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([32256 x i8], [32256 x i8]* @__CompressedAssemblyDescriptor_data_31, i32 0, i32 0); data
	}, 
	; 32
	%struct.CompressedAssemblyDescriptor {
		i32 214528, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([214528 x i8], [214528 x i8]* @__CompressedAssemblyDescriptor_data_32, i32 0, i32 0); data
	}, 
	; 33
	%struct.CompressedAssemblyDescriptor {
		i32 137728, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([137728 x i8], [137728 x i8]* @__CompressedAssemblyDescriptor_data_33, i32 0, i32 0); data
	}, 
	; 34
	%struct.CompressedAssemblyDescriptor {
		i32 2442752, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([2442752 x i8], [2442752 x i8]* @__CompressedAssemblyDescriptor_data_34, i32 0, i32 0); data
	}, 
	; 35
	%struct.CompressedAssemblyDescriptor {
		i32 1959936, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1959936 x i8], [1959936 x i8]* @__CompressedAssemblyDescriptor_data_35, i32 0, i32 0); data
	}, 
	; 36
	%struct.CompressedAssemblyDescriptor {
		i32 106896, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([106896 x i8], [106896 x i8]* @__CompressedAssemblyDescriptor_data_36, i32 0, i32 0); data
	}, 
	; 37
	%struct.CompressedAssemblyDescriptor {
		i32 33168, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([33168 x i8], [33168 x i8]* @__CompressedAssemblyDescriptor_data_37, i32 0, i32 0); data
	}, 
	; 38
	%struct.CompressedAssemblyDescriptor {
		i32 159632, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([159632 x i8], [159632 x i8]* @__CompressedAssemblyDescriptor_data_38, i32 0, i32 0); data
	}, 
	; 39
	%struct.CompressedAssemblyDescriptor {
		i32 75656, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([75656 x i8], [75656 x i8]* @__CompressedAssemblyDescriptor_data_39, i32 0, i32 0); data
	}, 
	; 40
	%struct.CompressedAssemblyDescriptor {
		i32 1040384, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1040384 x i8], [1040384 x i8]* @__CompressedAssemblyDescriptor_data_40, i32 0, i32 0); data
	}, 
	; 41
	%struct.CompressedAssemblyDescriptor {
		i32 31096, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([31096 x i8], [31096 x i8]* @__CompressedAssemblyDescriptor_data_41, i32 0, i32 0); data
	}, 
	; 42
	%struct.CompressedAssemblyDescriptor {
		i32 24976, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([24976 x i8], [24976 x i8]* @__CompressedAssemblyDescriptor_data_42, i32 0, i32 0); data
	}, 
	; 43
	%struct.CompressedAssemblyDescriptor {
		i32 22920, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([22920 x i8], [22920 x i8]* @__CompressedAssemblyDescriptor_data_43, i32 0, i32 0); data
	}, 
	; 44
	%struct.CompressedAssemblyDescriptor {
		i32 48528, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([48528 x i8], [48528 x i8]* @__CompressedAssemblyDescriptor_data_44, i32 0, i32 0); data
	}, 
	; 45
	%struct.CompressedAssemblyDescriptor {
		i32 289168, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([289168 x i8], [289168 x i8]* @__CompressedAssemblyDescriptor_data_45, i32 0, i32 0); data
	}, 
	; 46
	%struct.CompressedAssemblyDescriptor {
		i32 30600, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([30600 x i8], [30600 x i8]* @__CompressedAssemblyDescriptor_data_46, i32 0, i32 0); data
	}, 
	; 47
	%struct.CompressedAssemblyDescriptor {
		i32 75152, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([75152 x i8], [75152 x i8]* @__CompressedAssemblyDescriptor_data_47, i32 0, i32 0); data
	}, 
	; 48
	%struct.CompressedAssemblyDescriptor {
		i32 32656, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([32656 x i8], [32656 x i8]* @__CompressedAssemblyDescriptor_data_48, i32 0, i32 0); data
	}, 
	; 49
	%struct.CompressedAssemblyDescriptor {
		i32 898448, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([898448 x i8], [898448 x i8]* @__CompressedAssemblyDescriptor_data_49, i32 0, i32 0); data
	}, 
	; 50
	%struct.CompressedAssemblyDescriptor {
		i32 621448, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([621448 x i8], [621448 x i8]* @__CompressedAssemblyDescriptor_data_50, i32 0, i32 0); data
	}, 
	; 51
	%struct.CompressedAssemblyDescriptor {
		i32 102784, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([102784 x i8], [102784 x i8]* @__CompressedAssemblyDescriptor_data_51, i32 0, i32 0); data
	}, 
	; 52
	%struct.CompressedAssemblyDescriptor {
		i32 1633672, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1633672 x i8], [1633672 x i8]* @__CompressedAssemblyDescriptor_data_52, i32 0, i32 0); data
	}, 
	; 53
	%struct.CompressedAssemblyDescriptor {
		i32 57224, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([57224 x i8], [57224 x i8]* @__CompressedAssemblyDescriptor_data_53, i32 0, i32 0); data
	}, 
	; 54
	%struct.CompressedAssemblyDescriptor {
		i32 63880, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([63880 x i8], [63880 x i8]* @__CompressedAssemblyDescriptor_data_54, i32 0, i32 0); data
	}, 
	; 55
	%struct.CompressedAssemblyDescriptor {
		i32 28040, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([28040 x i8], [28040 x i8]* @__CompressedAssemblyDescriptor_data_55, i32 0, i32 0); data
	}, 
	; 56
	%struct.CompressedAssemblyDescriptor {
		i32 59792, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([59792 x i8], [59792 x i8]* @__CompressedAssemblyDescriptor_data_56, i32 0, i32 0); data
	}, 
	; 57
	%struct.CompressedAssemblyDescriptor {
		i32 54664, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([54664 x i8], [54664 x i8]* @__CompressedAssemblyDescriptor_data_57, i32 0, i32 0); data
	}, 
	; 58
	%struct.CompressedAssemblyDescriptor {
		i32 281472, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([281472 x i8], [281472 x i8]* @__CompressedAssemblyDescriptor_data_58, i32 0, i32 0); data
	}, 
	; 59
	%struct.CompressedAssemblyDescriptor {
		i32 22408, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([22408 x i8], [22408 x i8]* @__CompressedAssemblyDescriptor_data_59, i32 0, i32 0); data
	}, 
	; 60
	%struct.CompressedAssemblyDescriptor {
		i32 34696, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([34696 x i8], [34696 x i8]* @__CompressedAssemblyDescriptor_data_60, i32 0, i32 0); data
	}, 
	; 61
	%struct.CompressedAssemblyDescriptor {
		i32 19856, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([19856 x i8], [19856 x i8]* @__CompressedAssemblyDescriptor_data_61, i32 0, i32 0); data
	}, 
	; 62
	%struct.CompressedAssemblyDescriptor {
		i32 14728, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14728 x i8], [14728 x i8]* @__CompressedAssemblyDescriptor_data_62, i32 0, i32 0); data
	}, 
	; 63
	%struct.CompressedAssemblyDescriptor {
		i32 43408, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([43408 x i8], [43408 x i8]* @__CompressedAssemblyDescriptor_data_63, i32 0, i32 0); data
	}, 
	; 64
	%struct.CompressedAssemblyDescriptor {
		i32 30600, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([30600 x i8], [30600 x i8]* @__CompressedAssemblyDescriptor_data_64, i32 0, i32 0); data
	}, 
	; 65
	%struct.CompressedAssemblyDescriptor {
		i32 24976, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([24976 x i8], [24976 x i8]* @__CompressedAssemblyDescriptor_data_65, i32 0, i32 0); data
	}, 
	; 66
	%struct.CompressedAssemblyDescriptor {
		i32 26000, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([26000 x i8], [26000 x i8]* @__CompressedAssemblyDescriptor_data_66, i32 0, i32 0); data
	}, 
	; 67
	%struct.CompressedAssemblyDescriptor {
		i32 35208, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([35208 x i8], [35208 x i8]* @__CompressedAssemblyDescriptor_data_67, i32 0, i32 0); data
	}, 
	; 68
	%struct.CompressedAssemblyDescriptor {
		i32 21896, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([21896 x i8], [21896 x i8]* @__CompressedAssemblyDescriptor_data_68, i32 0, i32 0); data
	}, 
	; 69
	%struct.CompressedAssemblyDescriptor {
		i32 62344, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([62344 x i8], [62344 x i8]* @__CompressedAssemblyDescriptor_data_69, i32 0, i32 0); data
	}, 
	; 70
	%struct.CompressedAssemblyDescriptor {
		i32 19840, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([19840 x i8], [19840 x i8]* @__CompressedAssemblyDescriptor_data_70, i32 0, i32 0); data
	}, 
	; 71
	%struct.CompressedAssemblyDescriptor {
		i32 392592, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([392592 x i8], [392592 x i8]* @__CompressedAssemblyDescriptor_data_71, i32 0, i32 0); data
	}, 
	; 72
	%struct.CompressedAssemblyDescriptor {
		i32 14216, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14216 x i8], [14216 x i8]* @__CompressedAssemblyDescriptor_data_72, i32 0, i32 0); data
	}, 
	; 73
	%struct.CompressedAssemblyDescriptor {
		i32 91016, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([91016 x i8], [91016 x i8]* @__CompressedAssemblyDescriptor_data_73, i32 0, i32 0); data
	}, 
	; 74
	%struct.CompressedAssemblyDescriptor {
		i32 77200, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([77200 x i8], [77200 x i8]* @__CompressedAssemblyDescriptor_data_74, i32 0, i32 0); data
	}, 
	; 75
	%struct.CompressedAssemblyDescriptor {
		i32 36240, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([36240 x i8], [36240 x i8]* @__CompressedAssemblyDescriptor_data_75, i32 0, i32 0); data
	}, 
	; 76
	%struct.CompressedAssemblyDescriptor {
		i32 266240, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([266240 x i8], [266240 x i8]* @__CompressedAssemblyDescriptor_data_76, i32 0, i32 0); data
	}, 
	; 77
	%struct.CompressedAssemblyDescriptor {
		i32 22928, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([22928 x i8], [22928 x i8]* @__CompressedAssemblyDescriptor_data_77, i32 0, i32 0); data
	}, 
	; 78
	%struct.CompressedAssemblyDescriptor {
		i32 591752, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([591752 x i8], [591752 x i8]* @__CompressedAssemblyDescriptor_data_78, i32 0, i32 0); data
	}, 
	; 79
	%struct.CompressedAssemblyDescriptor {
		i32 29584, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([29584 x i8], [29584 x i8]* @__CompressedAssemblyDescriptor_data_79, i32 0, i32 0); data
	}, 
	; 80
	%struct.CompressedAssemblyDescriptor {
		i32 44424, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([44424 x i8], [44424 x i8]* @__CompressedAssemblyDescriptor_data_80, i32 0, i32 0); data
	}, 
	; 81
	%struct.CompressedAssemblyDescriptor {
		i32 67472, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([67472 x i8], [67472 x i8]* @__CompressedAssemblyDescriptor_data_81, i32 0, i32 0); data
	}, 
	; 82
	%struct.CompressedAssemblyDescriptor {
		i32 18304, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([18304 x i8], [18304 x i8]* @__CompressedAssemblyDescriptor_data_82, i32 0, i32 0); data
	}, 
	; 83
	%struct.CompressedAssemblyDescriptor {
		i32 141312, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([141312 x i8], [141312 x i8]* @__CompressedAssemblyDescriptor_data_83, i32 0, i32 0); data
	}, 
	; 84
	%struct.CompressedAssemblyDescriptor {
		i32 45456, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([45456 x i8], [45456 x i8]* @__CompressedAssemblyDescriptor_data_84, i32 0, i32 0); data
	}, 
	; 85
	%struct.CompressedAssemblyDescriptor {
		i32 31616, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([31616 x i8], [31616 x i8]* @__CompressedAssemblyDescriptor_data_85, i32 0, i32 0); data
	}, 
	; 86
	%struct.CompressedAssemblyDescriptor {
		i32 107920, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([107920 x i8], [107920 x i8]* @__CompressedAssemblyDescriptor_data_86, i32 0, i32 0); data
	}, 
	; 87
	%struct.CompressedAssemblyDescriptor {
		i32 83840, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([83840 x i8], [83840 x i8]* @__CompressedAssemblyDescriptor_data_87, i32 0, i32 0); data
	}, 
	; 88
	%struct.CompressedAssemblyDescriptor {
		i32 54160, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([54160 x i8], [54160 x i8]* @__CompressedAssemblyDescriptor_data_88, i32 0, i32 0); data
	}, 
	; 89
	%struct.CompressedAssemblyDescriptor {
		i32 752544, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([752544 x i8], [752544 x i8]* @__CompressedAssemblyDescriptor_data_89, i32 0, i32 0); data
	}, 
	; 90
	%struct.CompressedAssemblyDescriptor {
		i32 218000, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([218000 x i8], [218000 x i8]* @__CompressedAssemblyDescriptor_data_90, i32 0, i32 0); data
	}, 
	; 91
	%struct.CompressedAssemblyDescriptor {
		i32 1228208, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1228208 x i8], [1228208 x i8]* @__CompressedAssemblyDescriptor_data_91, i32 0, i32 0); data
	}, 
	; 92
	%struct.CompressedAssemblyDescriptor {
		i32 968704, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([968704 x i8], [968704 x i8]* @__CompressedAssemblyDescriptor_data_92, i32 0, i32 0); data
	}, 
	; 93
	%struct.CompressedAssemblyDescriptor {
		i32 264104, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([264104 x i8], [264104 x i8]* @__CompressedAssemblyDescriptor_data_93, i32 0, i32 0); data
	}, 
	; 94
	%struct.CompressedAssemblyDescriptor {
		i32 114592, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([114592 x i8], [114592 x i8]* @__CompressedAssemblyDescriptor_data_94, i32 0, i32 0); data
	}, 
	; 95
	%struct.CompressedAssemblyDescriptor {
		i32 1714176, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1714176 x i8], [1714176 x i8]* @__CompressedAssemblyDescriptor_data_95, i32 0, i32 0); data
	}, 
	; 96
	%struct.CompressedAssemblyDescriptor {
		i32 18072, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([18072 x i8], [18072 x i8]* @__CompressedAssemblyDescriptor_data_96, i32 0, i32 0); data
	}, 
	; 97
	%struct.CompressedAssemblyDescriptor {
		i32 4504576, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([4504576 x i8], [4504576 x i8]* @__CompressedAssemblyDescriptor_data_97, i32 0, i32 0); data
	}, 
	; 98
	%struct.CompressedAssemblyDescriptor {
		i32 90624, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([90624 x i8], [90624 x i8]* @__CompressedAssemblyDescriptor_data_98, i32 0, i32 0); data
	}
], align 4; end of 'compressed_assembly_descriptors' array


; compressed_assemblies
@compressed_assemblies = local_unnamed_addr global %struct.CompressedAssemblies {
	i32 99, ; count
	%struct.CompressedAssemblyDescriptor* getelementptr inbounds ([99 x %struct.CompressedAssemblyDescriptor], [99 x %struct.CompressedAssemblyDescriptor]* @compressed_assembly_descriptors, i32 0, i32 0); descriptors
}, align 4


!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-4 @ 13ba222766e8e41d419327749426023194660864"}

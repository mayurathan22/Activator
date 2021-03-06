﻿using Amazon;
using System;

namespace Activator.Models
{
    class MyAWSConfigs
    {
        public static readonly String refImagesBucketName = "refimagesbucket";
        public static readonly String faceCollectionID = "RefCollection";
        public static readonly String refPersonsDBTableName = "ref_persons";
        public static readonly String logsDBTableName = "logs";

        public static readonly String streamProcessorName = "my-stream-processor";
        public static readonly String kinesisVideoStreamArn = "arn:aws:kinesisvideo:us-west-2:358403828169:stream/demo-stream/1574012507733";
        public static readonly String kinesisDataStreamArn = "arn:aws:kinesis:us-west-2:358403828169:stream/AmazonRekognition-my-data-stream";
        public static readonly String kinesisDataStreamName = "my-data-stream";
        public static readonly String roleArn = "arn:aws:iam::358403828169:role/RekognitionServiceRole";

        public static readonly RegionEndpoint refImagesBucketRegion = RegionEndpoint.USWest2;
        public static readonly RegionEndpoint faceCollectionRegion = RegionEndpoint.USWest2;
        public static readonly RegionEndpoint dynamodbRegion = RegionEndpoint.APSoutheast2;
    }
}
